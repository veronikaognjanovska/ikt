#pragma checksum "C:\Users\veron\Documents\GitHub\ikt\Cinema\Cinema.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92935aa72aa24ec7cbf373f092ad6cb725b8c26b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\veron\Documents\GitHub\ikt\Cinema\Cinema.Web\Views\_ViewImports.cshtml"
using Cinema.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92935aa72aa24ec7cbf373f092ad6cb725b8c26b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f7ae69a80ab22fe8bf02a1f02e20d308d71e09c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("join-now"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tickets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\veron\Documents\GitHub\ikt\Cinema\Cinema.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"homepage\">\r\n    <div class=\"main\">\r\n        <div id=\"overlay\"></div>\r\n        <h1 class=\"tagline\">\r\n            CINEMATIX<br /> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92935aa72aa24ec7cbf373f092ad6cb725b8c26b4482", async() => {
                WriteLiteral("CHECK OUT");
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
            WriteLiteral(@"
        </h1>
      
        <img src=""https://github.com/kabirbatra03/WebStream-animation/blob/master/assets/bucket.png?raw=true"" class=""bucket"" />
        <canvas id=""3dglass"">
            Your browser does not support the HTML canvas tag.
        </canvas>
        <div id=""glasses"">
            <div id=""red""></div>
            <div id=""blue""></div>
        </div>
        <div class=""popcorn"" id=""0""></div>
        <div class=""popcorn"" id=""1""></div>
        <div class=""popcorn"" id=""2""></div>
        <div class=""popcorn"" id=""3""></div>
        <div class=""popcorn"" id=""4""></div>
        <div class=""popcorn"" id=""5""></div>
        <div class=""popcorn"" id=""6""></div>
        <div class=""popcorn"" id=""7""></div>
        <div class=""popcorn"" id=""8""></div>
        <div class=""popcorn"" id=""9""></div>
        <div class=""popcorn"" id=""10""></div>
        <div class=""popcorn"" id=""11""></div>
        <div class=""popcorn"" id=""12""></div>
        <div class=""popcorn"" id=""13""></div>
        <div class=""pop");
            WriteLiteral(@"corn"" id=""14""></div>
        <div class=""popcorn"" id=""15""></div>
        <div class=""popcorn"" id=""16""></div>
        <div class=""popcorn"" id=""17""></div>
        <div class=""popcorn"" id=""18""></div>
        <div class=""popcorn"" id=""19""></div>
        <div class=""popcorn"" id=""20""></div>
        <div class=""popcorn"" id=""21""></div>
        <div class=""popcorn"" id=""22""></div>
        <div class=""popcorn"" id=""23""></div>
        <div class=""popcorn"" id=""24""></div>
        <div class=""popcorn"" id=""25""></div>
        <div class=""popcorn"" id=""26""></div>
        <div class=""popcorn"" id=""27""></div>
        <div class=""popcorn"" id=""28""></div>
        <div class=""popcorn"" id=""29""></div>
        <div class=""popcorn"" id=""31""></div>
        <div class=""popcorn"" id=""32""></div>
        <div class=""popcorn"" id=""33""></div>
        <div class=""popcorn"" id=""34""></div>
        <div class=""popcorn"" id=""35""></div>
        <div class=""popcorn"" id=""36""></div>
        <div class=""popcorn"" id=""37""></div>
        <div");
            WriteLiteral(@" class=""popcorn"" id=""38""></div>
        <div class=""popcorn"" id=""39""></div>
        <div class=""popcorn"" id=""40""></div>
        <div class=""popcorn"" id=""41""></div>
        <div class=""popcorn"" id=""42""></div>
        <div class=""popcorn"" id=""43""></div>
        <div class=""popcorn"" id=""44""></div>
        <div class=""popcorn"" id=""45""></div>
        <div class=""popcorn"" id=""46""></div>
        <div class=""popcorn"" id=""47""></div>
        <div class=""popcorn"" id=""48""></div>
        <div class=""popcorn"" id=""49""></div>
        <div class=""popcorn"" id=""50""></div>
        <div class=""popcorn"" id=""51""></div>
        <div class=""popcorn"" id=""52""></div>
        <div class=""popcorn"" id=""53""></div>
        <div class=""popcorn"" id=""54""></div>
        <div class=""popcorn"" id=""55""></div>
        <div class=""popcorn"" id=""56""></div>
        <div class=""popcorn"" id=""57""></div>
        <div class=""popcorn"" id=""58""></div>
        <div class=""popcorn"" id=""59""></div>
        <div class=""popcorn"" id=""60""></div>
 ");
            WriteLiteral(@"       <div class=""popcorn"" id=""61""></div>
        <div class=""popcorn"" id=""62""></div>
        <div class=""popcorn"" id=""63""></div>
        <div class=""popcorn"" id=""64""></div>
        <div class=""popcorn"" id=""65""></div>
        <div class=""popcorn"" id=""66""></div>
        <div class=""popcorn"" id=""67""></div>
        <div class=""popcorn"" id=""68""></div>
        <div class=""popcorn"" id=""69""></div>
        <div class=""popcorn"" id=""70""></div>
        <div class=""popcorn"" id=""71""></div>
        <div class=""popcorn"" id=""72""></div>
        <div class=""popcorn"" id=""73""></div>
        <div class=""popcorn"" id=""74""></div>
        <div class=""popcorn"" id=""75""></div>
        <div class=""popcorn"" id=""76""></div>
        <div class=""popcorn"" id=""77""></div>
        <div class=""popcorn"" id=""78""></div>
        <div class=""popcorn"" id=""79""></div>
        <div class=""popcorn"" id=""80""></div>
        <div class=""popcorn"" id=""81""></div>
        <div class=""popcorn"" id=""82""></div>
        <div class=""popcorn"" id=""83");
            WriteLiteral(@"""></div>
        <div class=""popcorn"" id=""84""></div>
        <div class=""popcorn"" id=""85""></div>
        <div class=""popcorn"" id=""86""></div>
        <div class=""popcorn"" id=""87""></div>
        <div class=""popcorn"" id=""88""></div>
        <div class=""popcorn"" id=""89""></div>
        <div class=""popcorn"" id=""90""></div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
