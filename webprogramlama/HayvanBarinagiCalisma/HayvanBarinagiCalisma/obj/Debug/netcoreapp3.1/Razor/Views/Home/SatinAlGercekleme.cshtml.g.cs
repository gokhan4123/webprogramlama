#pragma checksum "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db7d64c446c8f3f6e1c902e757c6273e651907b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SatinAlGercekleme), @"mvc.1.0.view", @"/Views/Home/SatinAlGercekleme.cshtml")]
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
#line 1 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\_ViewImports.cshtml"
using Ciftlik;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\_ViewImports.cshtml"
using Ciftlik.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\_ViewImports.cshtml"
using Ciftlik.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
using Ciftlik.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db7d64c446c8f3f6e1c902e757c6273e651907b4", @"/Views/Home/SatinAlGercekleme.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c50d8e89e696002726e597bd66175017c5fb702", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SatinAlGercekleme : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hayvan>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SatinAl", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark w-25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
  
    ViewData["SatinAl"] = SharedLocalizer.GetLocalizedHtmlString("SatinAl");
    ViewData["Cinsiyet"] = SharedLocalizer.GetLocalizedHtmlString("Cinsiyet");
    ViewData["CErkek"] = SharedLocalizer.GetLocalizedHtmlString("CErkek");
    ViewData["CDisi"] = SharedLocalizer.GetLocalizedHtmlString("CDisi");
    ViewData["Yas"] = SharedLocalizer.GetLocalizedHtmlString("Yas");
    ViewData["Tur"] = SharedLocalizer.GetLocalizedHtmlString("Tur");
    ViewData["Cins"] = SharedLocalizer.GetLocalizedHtmlString("Cins");
    ViewData["SatinAlGercekleme"] = SharedLocalizer.GetLocalizedHtmlString("SatinAlGercekleme");
    ViewData["Tebrik"] = SharedLocalizer.GetLocalizedHtmlString("Tebrik");
    ViewData["SatinAlDon"] = SharedLocalizer.GetLocalizedHtmlString("SatinAlDon");

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
  
    ViewData["Title"] = "Sat??nalma Ger??eklestirme";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card m-auto w-75\">\n    <div class=\"card-body text-center\">\n        ");
#nullable restore
#line 25 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
   Write(ViewData["Tebrik"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
                       Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ! <b>");
#nullable restore
#line 25 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
                                                Write(Model.Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> ");
#nullable restore
#line 25 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
                                                               Write(ViewData["SatinAlGercekleme"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1289, "\"", 1306, 1);
#nullable restore
#line 27 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
WriteAttributeValue("", 1295, Model.Foto, 1295, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\n    <div class=\"card-body\">\n        <h5 class=\"card-title\">");
#nullable restore
#line 29 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
                          Write(Model.Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        <p class=\"card-text\">");
#nullable restore
#line 30 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
                        Write(Model.EkBilgiler);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>\n    <ul class=\"list-group list-group-flush\">\n        <li class=\"list-group-item\">");
#nullable restore
#line 33 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
                               Write(ViewData["Tur"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 33 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
                                                 Write(ViewBag.Turu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li class=\"list-group-item\">");
#nullable restore
#line 34 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
                               Write(ViewData["Cins"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 34 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
                                                  Write(ViewBag.Cinsi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li class=\"list-group-item\">");
#nullable restore
#line 35 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
                               Write(ViewData["Yas"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 35 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
                                                 Write(Model.Yasi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 36 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
         if (Model.Cinsiyet)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item\">");
#nullable restore
#line 38 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
                                   Write(ViewData["Cinsiyet"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 38 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
                                                          Write(ViewData["CErkek"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 39 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item\">");
#nullable restore
#line 42 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
                                   Write(ViewData["Cinsiyet"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 42 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
                                                          Write(ViewData["CDisi"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 43 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </ul>\n    <div class=\"card-body text-center\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db7d64c446c8f3f6e1c902e757c6273e651907b412655", async() => {
#nullable restore
#line 48 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\SatinAlGercekleme.cshtml"
                                                                                   Write(ViewData["SatinAlDon"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<CustomUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<CustomUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LocService SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hayvan> Html { get; private set; }
    }
}
#pragma warning restore 1591
