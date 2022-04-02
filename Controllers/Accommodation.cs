using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RestSharp;
using TTU_CORE_ASP_ADMISSION_PORTAL.Data;
using TTU_CORE_ASP_ADMISSION_PORTAL.Models;
using TTU_CORE_ASP_ADMISSION_PORTAL.Services;

namespace TTU_CORE_ASP_ADMISSION_PORTAL.Controllers
{
   
    public class Accommodation : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SMSService sms;

        private readonly ApplicationDbContext _dbContext;

        private readonly IHelper _helper;
        private UserManager<ApplicationUser> _userManager;
        
        
        public Accommodation(ILogger<HomeController> logger, IHelper helper, UserManager<ApplicationUser> userManager,
            ApplicationDbContext dbContext)
        {
            _logger = logger;
            _userManager = userManager;
            _dbContext = dbContext;
            _helper = helper;
        }

        // GET
       
        public async Task<IActionResult> Index()
        {
            //_logger.LogInformation("User booked room.");

            FormService _formService = new FormService(_dbContext);

            var ApplicantId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            //Console.WriteLine("sss"+ApplicantId);
           
            var applicantModel = await _dbContext.ApplicantModel.FirstOrDefaultAsync(a => a.ApplicationUserId == ApplicantId);
            ViewData["years"] = applicantModel.YearOfAdmission;
            ViewData["genders"] = applicantModel.Gender.Substring(0, 1).ToUpper();
            //ViewData["hall"] = applicantModel.HallAdmitted;
            ViewData["halls"] = applicantModel.HallAdmitted;
            ViewData["room"] = applicantModel.RoomNo;

            Console.WriteLine("year"+applicantModel.YearOfAdmission + "gender"+ applicantModel.Gender.Substring(0, 1).ToUpper() +"hall " +applicantModel.HallAdmitted);
            return View("booking");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveAysnc()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId


            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);

            var ApplicantForm = applicationUser?.FormNo;
            var room = HttpContext.Request.Form["room"];
            var bed = HttpContext.Request.Form["bed"];
            var orientation = HttpContext.Request.Form["orientation"];
            var acccommodation = room + " - " + bed + " - " + orientation;
            var applicantModel = await _dbContext.ApplicantModel.FirstOrDefaultAsync(a => a.ApplicationUserId == userId);
            applicantModel.RoomNo = acccommodation;
             
            if (await _dbContext.SaveChangesAsync() == 1)
            {
                
                
                var applicantInfo =
                    await _dbContext.ApplicantModel.FirstOrDefaultAsync(a => a.ApplicationUserId == userId);

                // update srms that the room has been booked
                var client = new RestClient($"https://srms.ttuportal.com/api/rooms/update");
                var request = new RestRequest(Method.POST);
                request.AddJsonBody(new
                {
                    id = bed,
                    applicant=ApplicantForm,
                    room=room,
                    hall=applicantInfo.HallAdmitted
                });
                
                
                IRestResponse response = await client.ExecuteAsync(request);
                if (response.IsSuccessful)
                {
                    var applicantData =
                        await _dbContext.ApplicantModel.FirstOrDefaultAsync(a => a.ApplicationUserId == userId);

                    var message = "Hi " + applicantData.FirstName + " your room no is "  + room + " at " + _helper.GetHallName(applicantData.HallAdmitted) + ".Pay GHS"+applicantData.Hall.Fees+ "at any branch of Ecobank or UBA within 48hrs to avoid loosing the room.";
                     // notify applicant of the room reservation
                    _helper.SendSMSNotification(applicantData.Phone, message);
                    TempData["message"] = "Room booked  successfully!!";
                    TempData["type"] = "success";
                    return RedirectToAction("Index", "Accommodation");
                }
                else
                {
                    TempData["message"] = "Error contacting room reservation service. Try again later!!";
                    TempData["type"] = "error";
                    return RedirectToAction("Index", "Accommodation");
                }

              
            }
            else {
                TempData["message"] = "Error processing bookings!!";
                TempData["type"] = "error";
                return RedirectToAction("Index", "Accommodation");
            }

            return Ok();
        }
    }
}