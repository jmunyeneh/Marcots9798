#pragma checksum "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc41e789f26ce61e428b8ad134d97b2302546b85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MarcotsContactApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace MarcotsContactApp.Pages
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
#line 1 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\_ViewImports.cshtml"
using MarcotsContactApp.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\_ViewImports.cshtml"
using MarcotsContactApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\_ViewImports.cshtml"
using MarcotsContactApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\_ViewImports.cshtml"
using MarcotsContactApp.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\_ViewImports.cshtml"
using MarcotsContactApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc41e789f26ce61e428b8ad134d97b2302546b85", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ef681e84ad6d51e2c28f7f0d9c1842b75368fd9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";
    int monthNumber = DateTime.Now.Month;
    string monthName = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <div id=""carouselExampleSlidesOnly"" class=""carousel slide"" data-ride=""carousel"">
        <div class=""carousel-inner"">
            <div class=""carousel-item active"">
                <img class=""d-block w-100"" src=""/images/shutterstock.png"" alt=""First slide"">
            </div>
            <div class=""carousel-item"">
                <img class=""d-block w-100"" src=""/images/Togetherness.png"" alt=""Second slide"">
            </div>
            <div class=""carousel-item"">
                <img class=""d-block w-100"" src=""/images/shutterstock.png"" alt=""Third slide"">
            </div>
        </div>
    </div>
</div>



");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IContactService service { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MarcotsContactApp.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MarcotsContactApp.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MarcotsContactApp.Pages.IndexModel>)PageContext?.ViewData;
        public MarcotsContactApp.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
