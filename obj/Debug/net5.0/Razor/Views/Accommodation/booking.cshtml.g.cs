#pragma checksum "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d632862f2c79b315fb00f26bf70292c5f2cbb0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accommodation_booking), @"mvc.1.0.view", @"/Views/Accommodation/booking.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/_ViewImports.cshtml"
using TTU_CORE_ASP_ADMISSION_PORTAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/_ViewImports.cshtml"
using TTU_CORE_ASP_ADMISSION_PORTAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml"
using Humanizer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d632862f2c79b315fb00f26bf70292c5f2cbb0a", @"/Views/Accommodation/booking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9178357f7ee190d9f2837aee3634b55e976fe929", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Accommodation_booking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("wizard_advanced_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("uk-form-stacked"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Accommodation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveAysnc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept-charset", new global::Microsoft.AspNetCore.Html.HtmlString("utf-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("updateForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/select2.full.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml"
   var user = await UserManager.GetUserAsync(User); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml"
  
    ViewBag.Title = "Accommodation - Bookings";

    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("Style", async() => {
                WriteLiteral("\n    <style>\n        input {\n            text-transform: uppercase;\n        }\n        select {\n            text-transform: uppercase;\n        } \n    </style>\n\n\n");
            }
            );
            WriteLiteral("\n");
#nullable restore
#line 26 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml"
 if ((user.Started) == 1)
{
    //var date = ViewBag.applicant.DateOfBirth.ToString("yyy-MM-dd");
}
else
{
    var date = "";
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml"
 if (TempData["message"] != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml"
     if (TempData["type"].ToString() == "success")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"text-align: center\" class=\"uk-alert uk-alert-success\" data-uk-alert=\"\"> ");
#nullable restore
#line 38 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml"
                                                                                       Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\n");
#nullable restore
#line 39 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"text-align: center\" class=\"uk-alert uk-alert-danger\" data-uk-alert=\"\"> ");
#nullable restore
#line 42 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml"
                                                                                      Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\n");
#nullable restore
#line 43 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>room no is  ");
#nullable restore
#line 45 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml"
          Write(ViewBag.room);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
            WriteLiteral("<h6 class=\"heading_b uk-margin-bottom\">Room Reservation - Please select all required (T = Top bed, D= Down bed).</h6>\n<div class=\"uk-width-xLarge-1-10\">\n    <div class=\"md-card\">\n        <div class=\"md-card-content\"");
            BeginWriteAttribute("style", " style=\"", 1287, "\"", 1295, 0);
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 51 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml"
 if ( ViewBag.room == null ||  ViewBag.room=="")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d632862f2c79b315fb00f26bf70292c5f2cbb0a10711", async() => {
                WriteLiteral("\n        ");
#nullable restore
#line 54 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n\n        <div class=\"uk-grid\" data-uk-grid-margin=\"\">\n            <div class=\"uk-width-medium-2-10\" style=\"margin-top: 16px\">\n\n\n                <select required=\"required\" class=\"md-input room select\" v-model=\"room\"");
                BeginWriteAttribute("v-form-ctrl", " v-form-ctrl=\"", 1786, "\"", 1800, 0);
                EndWriteAttribute();
                WriteLiteral("\n                        v-select=\"room\" name=\"room\">\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d632862f2c79b315fb00f26bf70292c5f2cbb0a11682", async() => {
                    WriteLiteral("--select room no ---");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                </select>
                <p class="" uk-text-danger uk-text-small"" v-if=""updateForm.room.$error.required"">Please
                    select room</p>

            </div>

            <div class=""uk-width-medium-2-10"" style=""margin-top: 19px"" v-if=""room"">


                <select required=""required"" class=""md-input bed select"" v-model=""bed""");
                BeginWriteAttribute("v-form-ctrl", " v-form-ctrl=\"", 2280, "\"", 2294, 0);
                EndWriteAttribute();
                WriteLiteral("\n                        v-select=\"bed\" name=\"bed\">\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d632862f2c79b315fb00f26bf70292c5f2cbb0a13517", async() => {
                    WriteLiteral("--select bed ---");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


                </select>
                <p class="" uk-text-danger uk-text-small"" v-if=""updateForm.bed.$error.required"">Please
                    select bed </p>
            </div>


            <div class=""uk-width-medium-2-10"" style=""margin-top: 19px"">

                <input v-show=""updateForm.$valid"" class=""md-btn md-btn-primary uk-margin-small-top""
                       type=""submit"" name=""submit_order"" value=""Book"" v-on:click=""submit_form""/>

                <button type=""reset"" class=""md-btn md-btn-flat"">Cancel</button>
            </div>

        </div>


    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("v-form", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral(@"    <div class=""uk-modal"" id=""confirm_modal"">
        <div class=""uk-modal-dialog"" v-el:confirm_modal>
            <div class=""uk-modal-header uk-text-large uk-text-success uk-text-center"">Confirm Data</div>
            Are you certain of all the info

        </div>
    </div>
");
#nullable restore
#line 105 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"uk-margin-remove\">\n       Room already booked.\n    </p>\n");
#nullable restore
#line 111 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n\n    </div>\n\n\n</div>\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n\n");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d632862f2c79b315fb00f26bf70292c5f2cbb0a18587", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>$(document).ready(function () {
    $('selectssssss').select2({ dropdownAutoWidth: true });
    

        });</script>


    <script>//code for ensuring vuejs can work with select2 select boxes
        Vue.directive('select', {
            twoWay: true,
            priority: 1000,
            params: ['options'],
            bind: function () {
                var self = this
                $(this.el)
                    .select2({
                        data: this.params.options,
                        width: ""resolve""
                    })
                    .on('change', function () {
                        self.vm.$set(this.name, this.value)
                        Vue.set(self.vm.$data, this.name, this.value)
                    })
            },
            update: function (newValue, oldValue) {
                $(this.el).val(newValue).trigger('change')
            },
            unbind: function () {
                $(this.el).off().select2('destroy')
            }
        })
      ");
                WriteLiteral(@"  var vm = new Vue({
            el: ""body"",
            ready: function () {
            },
            data: {

                
                options: [
                ],
                in_payment_section: false,
            },
            methods: {
                go_to_payment_section: function (event) {
                    UIkit.modal.confirm(vm.$els.confirm_modal.innerHTML, function () {

                        vm.$data.in_payment_section = true
                    })
                },
                submit_form: function () {
                    return (function (modal) { modal = UIkit.modal.blockUI(""<div class='uk-text-center'>Booking Room...<br/><img class='uk-thumbnail uk-margin-top' src='https://apply.ttuportal.com/assets/img/spinners/spinner_success.gif' /></div>""); setTimeout(function () { modal.hide() }, 50000) })();
                },

                go_to_fill_form_section: function (event) {
                    vm.$data.in_payment_section = false
                }
            }
    ");
                WriteLiteral("    })</script>\n       \n    <script type=\"text/javascript\">\n        \n            $(document).ready(function () {\n                \n                 var hall =\'");
#nullable restore
#line 200 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml"
                       Write(Html.Raw( @ViewBag.halls));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';  \n                 var gender =\'");
#nullable restore
#line 201 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml"
                         Write(Html.Raw( @ViewBag.genders));

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\n                 var year = \'");
#nullable restore
#line 202 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Accommodation/booking.cshtml"
                        Write(Html.Raw( @ViewBag.years));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
                  
                 console.log(""Gender"" + gender);
                    
                    var url = ""https://srms.ttuportal.com/api/room/""+hall+""/hall/""+gender+""/gender/""+year+""/year"";
        console.log(url);
                    $.getJSON(url, function (data) {
                        $.each(data, function (index, value) {
                            // APPEND OR INSERT DATA TO SELECT ELEMENT.
                            $('.room').append('<option value=""' + value.room + '"">' + value.room + '</option>');
                        });
        
                    });
                    
            });
             
        
        $('.room').on('change', function() {
              var room = this.value;
              $.ajax({
                 url: ""https://srms.ttuportal.com/api/bed/""+room+""/bed"",
                 type: ""POST"",
                 data: {
                    room: room
                 },
                 cache: false,
                 success: function(result){
          ");
                WriteLiteral(@"             $('.bed').empty();
                      
                           $('.bed').append('<option>--select bed ---</option>');
                          
                   $.each(result, function (index, value) {
                          
                          $('.bed').append('<option value=""' + value.bed + '"">' + value.bed +"" - "" +value.orientation + '</option>');
                          
                         
                        });
                    
        
                   
                 }
              });
           });   
        
        </script>

");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public TTU_CORE_ASP_ADMISSION_PORTAL.Services.IHelper form { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
