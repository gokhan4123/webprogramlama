#pragma checksum "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\Hakkimizda.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3513cf072868c67df47fa3dfb11d9ddd874d4372"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Hakkimizda), @"mvc.1.0.view", @"/Views/Home/Hakkimizda.cshtml")]
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
#line 4 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\Hakkimizda.cshtml"
using Ciftlik.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\Hakkimizda.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3513cf072868c67df47fa3dfb11d9ddd874d4372", @"/Views/Home/Hakkimizda.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c50d8e89e696002726e597bd66175017c5fb702", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Hakkimizda : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark btn-lg float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SatinAl", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\Hakkimizda.cshtml"
  
    ViewData["Title"] = "Hakkımızda";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\Hakkimizda.cshtml"
   
    ViewData["BizKimiz"] = SharedLocalizer.GetLocalizedHtmlString("BizKimiz");
    ViewData["HakkimizdaIcerik1"] = SharedLocalizer.GetLocalizedHtmlString("HakkimizdaIcerik1");
    ViewData["HakkimizdaIcerik2"] = SharedLocalizer.GetLocalizedHtmlString("HakkimizdaIcerik2");
    ViewData["KayitOl"] = SharedLocalizer.GetLocalizedHtmlString("KayitOl");
    ViewData["SimdiSatinAl"] = SharedLocalizer.GetLocalizedHtmlString("SimdiSatinAl");

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"jumbotron mt-5 shadow\">\n    <h1 class=\"display-4\">");
#nullable restore
#line 17 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\Hakkimizda.cshtml"
                     Write(ViewData["BizKimiz"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("?</h1>\n    <p class=\"lead\">\n        ");
#nullable restore
#line 19 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\Hakkimizda.cshtml"
   Write(ViewData["HakkimizdaIcerik1"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </p>\n    <hr class=\"my-4\">\n    <p>");
#nullable restore
#line 22 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\Hakkimizda.cshtml"
  Write(ViewData["HakkimizdaIcerik2"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p class=\"lead\">\n");
#nullable restore
#line 24 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\Hakkimizda.cshtml"
         if (!SignInManager.IsSignedIn(User))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3513cf072868c67df47fa3dfb11d9ddd874d43727903", async() => {
#nullable restore
#line 26 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\Hakkimizda.cshtml"
                                                                                                                     Write(ViewData["KayitOl"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("...");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 27 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\Hakkimizda.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3513cf072868c67df47fa3dfb11d9ddd874d437210025", async() => {
#nullable restore
#line 30 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\Hakkimizda.cshtml"
                                                                                                                   Write(ViewData["SimdiSatinAl"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("...");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 31 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Views\Home\Hakkimizda.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </p>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
