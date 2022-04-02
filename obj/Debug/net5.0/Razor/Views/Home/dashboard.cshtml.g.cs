#pragma checksum "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83a2d6b9fd7e4d866c1f3379f3010d3d3ea9cf73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_dashboard), @"mvc.1.0.view", @"/Views/Home/dashboard.cshtml")]
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
#line 2 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml"
using Humanizer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83a2d6b9fd7e4d866c1f3379f3010d3d3ea9cf73", @"/Views/Home/dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9178357f7ee190d9f2837aee3634b55e976fe929", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("md-btn   md-btn-primary uk-margin-small-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Form", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Upload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Preview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 6 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml"
  
    ViewBag.Title = "Dashboard";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml"
   var user = await UserManager.GetUserAsync(User); 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""uk-grid uk-grid-width-large-1-4 uk-grid-width-medium-1-2 uk-grid-medium uk-sortable sortable-handler hierarchical_show"" data-uk-sortable data-uk-grid-margin>

    <div>
        <div class=""md-card"">
            <div class=""md-card-content"">
                <div class=""uk-float-right uk-margin-top uk-margin-small-right""><span class=""peity_sale peity_data"">5,3,9,6,5,9,7,3,5,2</span></div>
                <span class=""uk-text-muted uk-text-small"">Last Login</span>
                <h4 class=""uk-margin-remove""><span class=""countUpMe"" style=""text-transform:capitalize"">  ");
#nullable restore
#line 19 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml"
                                                                                                     Write(user.LastLogin.Humanize());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h4>
            </div>
        </div>
    </div>

    <div>
        <div class=""md-card"">
            <div class=""md-card-content"">
                <div class=""uk-float-right uk-margin-top uk-margin-small-right""><span class=""peity_visitors peity_data"">5,3,9,6,5,9,7</span></div>
                <span class=""uk-text-muted uk-text-small"">Form No.</span>
                <h4 class=""uk-margin-remove"">
                    <span class=""countUpMew"">

                         ");
#nullable restore
#line 32 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml"
                     Write(user.FormNo );

#line default
#line hidden
#nullable disable
            WriteLiteral(" -  ");
#nullable restore
#line 32 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml"
                                        Write(user.Type );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



                    </span>
                </h4>
            </div>
        </div>
    </div>

    <div>
        <div class=""md-card"">
            <div class=""md-card-content"">
                <div class=""uk-float-right uk-margin-top uk-margin-small-right""><span class=""peity_orders peity_data"">64/100</span></div>
                <span class=""uk-text-muted uk-text-small"">Picture Upload</span>




");
#nullable restore
#line 51 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml"
                 if ((user.PictureUploaded) == 1)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4 class=\"uk-margin-remove\"><span class=\"countUpMe\">Yes</span></h4>\n");
#nullable restore
#line 55 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4 class=\"uk-margin-remove\"><span class=\"countUpMe\">No</span></h4>\n");
#nullable restore
#line 60 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




            </div>
        </div>
    </div>
    <div>
        <div class=""md-card"">
            <div class=""md-card-content"">
                <div class=""uk-float-right uk-margin-top uk-margin-small-right""><span class=""peity_live peity_data"">5,3,9,6,5,9,7,3,5,2,5,3,9,6,5,9,7,3,5,2</span></div>
                <span class=""uk-text-muted uk-text-small"">Form Completed</span>


");
#nullable restore
#line 76 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml"
                 if ((user.FormCompleted) == 1)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4 class=\"uk-margin-remove\" id=\"peity_live_text\">\n                        Yes.\n                    </h4>\n");
#nullable restore
#line 82 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4 class=\"uk-margin-remove\" id=\"peity_live_text\">\n                        No.\n                    </h4>\n");
#nullable restore
#line 89 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



            </div>
        </div>
    </div>
</div>

<div class=""uk-grid"">
    <div class=""uk-width-1-1"">
        <div class=""md-card"">

            <div class=""md-card-content"">

                <p><center><strong>INSTRUCTIONS IN FILLING THE FORM </strong></center></p>
                <hr>
                <p>All Ghanaian applicants for the  ");
#nullable restore
#line 107 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml"
                                               Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 107 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml"
                                                                  Write(DateTime.Now.AddYears(+1).Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Academic year admission are required to use Takoradi Technical University online admission portal.<br /> The procedure for the online application process is as follows:</p>

                <p><strong>I</strong>. In completing the online form, applicants will be required to upload their passport size photograph (not more than 250KB) with a white background.</p>
                <p><strong>II. </strong>Applicants are advised to check thoroughly all details entered before they finally submit their online applications. A form, once submitted, can be viewed, but cannot be edited.</p>
                <p><strong>III.</strong> Applicants should print out application form; attach result slips, certificates  and all other relevant documents.</p>
                <p><strong>IV. </strong>The application documents as specified (III) above should sent by post to

                <p align=""center""><strong>The Registrar</strong></p>
                <p align=""center""><strong>Takoradi Technical University</strong></p>
        ");
            WriteLiteral(@"        <p align=""center""><strong>P. O Box 256, Takoradi, W/R.</strong></p>

                <center><p><strong>For more information call 0508333992 / 0553777777 / 0243348522 / 0508335033</strong></p></center>
                &nbsp;
                <div class=""form-actions"" data-qa-continue="""">
                    <center>
                        <table align=""center"">

                            <tr>
                                <td>
");
#nullable restore
#line 126 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml"
                                     if ((user.PictureUploaded) == 1)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83a2d6b9fd7e4d866c1f3379f3010d3d3ea9cf7313348", async() => {
                WriteLiteral("Start Application");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 130 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml"


                                    }
                                    else
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83a2d6b9fd7e4d866c1f3379f3010d3d3ea9cf7315323", async() => {
                WriteLiteral("Upload Picture");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 137 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml"

                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml"
                                     if ((user.Finalized) == 1)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83a2d6b9fd7e4d866c1f3379f3010d3d3ea9cf7317469", async() => {
                WriteLiteral("Preview Form");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 143 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Home/dashboard.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                            </tr>\n                        </table>\n\n                    </center>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n");
        }
        #pragma warning restore 1998
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
