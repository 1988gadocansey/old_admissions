#pragma checksum "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/TTU_CORE_ASP_ADMISSION_PORTAL/Views/Form/wizzard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c681bfe0ae555a3a1d6c95b0ec1179a67e0d84b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Form_wizzard), @"mvc.1.0.razor-page", @"/Views/Form/wizzard.cshtml")]
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
#line 1 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/TTU_CORE_ASP_ADMISSION_PORTAL/Views/_ViewImports.cshtml"
using TTU_CORE_ASP_ADMISSION_PORTAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Applications/www/TTU_CORE_ASP_ADMISSION_PORTAL/TTU_CORE_ASP_ADMISSION_PORTAL/Views/_ViewImports.cshtml"
using TTU_CORE_ASP_ADMISSION_PORTAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c681bfe0ae555a3a1d6c95b0ec1179a67e0d84b4", @"/Views/Form/wizzard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9178357f7ee190d9f2837aee3634b55e976fe929", @"/Views/_ViewImports.cshtml")]
    public class Views_Form_wizzard : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h2 class=""heading_b uk-margin-bottom"">UIkit Get Started</h2>

<div class=""md-card"">
    <div class=""md-card-content"">
        <div id=""wizard_vertical"">

            <h3>Get started</h3>
            <section>
                <h2 class=""heading_b"">
                    Get started
                    <span class=""sub-heading"">Get familiar with the basic setup and structure of UIkit.</span>
                </h2>
                <hr class=""md-hr"">
                <h3 class=""heading_a"">File structure</h3>
                <p>In the ZIP file you will find all CSS, JavaScript and font files ready to use for your project. The core framework of UIkit has almost no styling in order to keep it slim. Therefore we provide two addidional distributions with a gradient and an almost flat style. Each style comes as a single CSS file as well as a minified version.</p>
<pre class=""line-numbers""><code class=""language-markup"">
    /css
    &lt;!-- UIkit with the basic style --&gt;
    uikit.css
    uikit.min.css

    &lt;!-- UIki");
            WriteLiteral(@"t with Gradient style --&gt;
    uikit.gradient.css
    uikit.gradient.min.css

    &lt;!-- UIkit with Almost flat style --&gt;
    uikit.almost-flat.css
    uikit.almost-flat.min.css

    &lt;!-- Advanced components --&gt;
    /components

    /fonts
    &lt;!-- FontAwesome webfont --&gt;
    fontawesome-webfont.eot
    fontawesome-webfont.ttf
    fontawesome-webfont.woff
    FontAwesome.otf

    /js
    &lt;!-- JavaScript and minified version --&gt;
    uikit.js
    uikit.min.js

    &lt;!-- Advanced components --&gt;
    /components

    &lt;!-- Core components --&gt;
    /core</code></pre>
                <p class=""uk-text-large"">&hellip;</p>
            </section>
            <h3>How to customize</h3>
            <section>
                <h2 class=""heading_b"">
                    How to customize
                    <span class=""sub-heading"">Create your own style with the customizer.</span>
                </h2>
                <hr class=""md-hr"">
                <p>UIkit comes with a customizer that ena");
            WriteLiteral(@"bles you to make adjustments to the theme you are using with just a few clicks and no need for any CSS knowledge. You can then download your new CSS and even the pending Less variables, all ready to use.</p>
                <p><span class=""uk-badge uk-badge-primary"">NOTE</span> To optimize performance, we recommend disabling add-ons, like Web Developer and Firebug in <code>Firefox</code></p>
                <h3 class=""heading_a"">Usage</h3>
                <p>Choose the theme that you would like to customize from the select box. Click inside a color square to open the dialog and change your color. To adjust a numeric value, like width or margin, just click in the text area and type your own value. You can even use a different unit and the customizer will recalculate automatically. Once you are satisfied with your adjustments, hit Get CSS to download your new theme and copy it into your UIkit <code>/css</code> folder.</p>
                <h4 class=""heading_c"">Advanced mode</h4>
                <p>The variables ");
            WriteLiteral(@"within the customizer are separated into two main parts. First, variables which are displayed by default and variables which only appear in the Advanced Mode. The visible variables are often the global ones, because they usually define the value of component variables. To see the component variables, just check the Advanced mode box.</p>
                <h4 class=""heading_c"">More</h4>
                <p>By default, variables whose value is defined through another variable are hidden. In Advanced mode you can see a (More) button next to groups that include these kinds of variables. This option is extremely powerful as it enables you to set your own value for any component variable.</p>
            </section>
            <h3>Less & Sass files</h3>
            <section>
                <h2 class=""heading_b"">
                    Less & Sass files
                    <span class=""sub-heading"">A separate Bower UIkit repository contains all distribution files including Less and Sass.</span>
                </h2>
   ");
            WriteLiteral(@"             <hr class=""md-hr"">
                <p>The great thing about UIkit is that you can easily integrate its source files in your project to keep your custom project workflow for building assets and stay with your preferred CSS preprocessor.</p>
                <p>UIkit uses the package manager <a href=""https://bower.io/"">Bower</a> to load assets. Therefore UIkit automatically generates the distributions into a separate <a href=""https://github.com/uikit/bower-uikit"">Bower UIkit repository</a>. It contains all CSS, Less, SCSS and JavaScript files from UIkit and its components.</p>
                <p class=""uk-text-large"">&hellip;</p>
            </section>

        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Views_Form_wizzard> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Form_wizzard> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Form_wizzard>)PageContext?.ViewData;
        public Views_Form_wizzard Model => ViewData.Model;
    }
}
#pragma warning restore 1591
