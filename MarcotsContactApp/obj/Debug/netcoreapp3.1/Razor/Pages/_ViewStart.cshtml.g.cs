#pragma checksum "C:\Users\JaydenExpress\source\repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\_ViewStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7091c65830b0329e613be026ede8a57552863778"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MarcotsContactApp.Pages.Pages__ViewStart), @"mvc.1.0.view", @"/Pages/_ViewStart.cshtml")]
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
#line 1 "C:\Users\JaydenExpress\source\repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\_ViewImports.cshtml"
using MarcotsContactApp.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JaydenExpress\source\repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JaydenExpress\source\repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\_ViewImports.cshtml"
using MarcotsContactApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JaydenExpress\source\repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\_ViewImports.cshtml"
using MarcotsContactApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\JaydenExpress\source\repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\_ViewImports.cshtml"
using MarcotsContactApp.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\JaydenExpress\source\repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\JaydenExpress\source\repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\_ViewImports.cshtml"
using MarcotsContactApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7091c65830b0329e613be026ede8a57552863778", @"/Pages/_ViewStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ef681e84ad6d51e2c28f7f0d9c1842b75368fd9", @"/Pages/_ViewImports.cshtml")]
    public class Pages__ViewStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\JaydenExpress\source\repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\_ViewStart.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
