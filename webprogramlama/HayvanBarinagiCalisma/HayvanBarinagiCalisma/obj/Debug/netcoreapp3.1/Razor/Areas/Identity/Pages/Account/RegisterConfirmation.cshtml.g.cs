#pragma checksum "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfca38f8abb10a04a4d355003619e84947532a6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#line 1 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\_ViewImports.cshtml"
using HayvanBarinagiCalisma.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\_ViewImports.cshtml"
using HayvanBarinagiCalisma.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using HayvanBarinagiCalisma.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfca38f8abb10a04a4d355003619e84947532a6c", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2be460b80625fb2a21c6c2412abb3aeba42824d", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd4021b40914f93f2b6f7df0fead0d6a7e08c0e3", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Register confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 7 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 8 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    if (@Model.DisplayConfirmAccountLink)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\n    This app does not currently have a real email sender registered, see <a href=\"https://aka.ms/aspaccountconf\">these docs</a> for how to configure a real email sender.\n    Normally this would be emailed: <a id=\"confirm-link\"");
            BeginWriteAttribute("href", " href=\"", 403, "\"", 437, 1);
#nullable restore
#line 13 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
WriteAttributeValue("", 410, Model.EmailConfirmationUrl, 410, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Click here to confirm your account</a>\n</p>\n");
#nullable restore
#line 15 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\n        Please check your email to confirm your account.\n</p>\n");
#nullable restore
#line 21 "D:\Users\gugras\Desktop\webprogramlama\HayvanBarinagiCalisma\HayvanBarinagiCalisma\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
