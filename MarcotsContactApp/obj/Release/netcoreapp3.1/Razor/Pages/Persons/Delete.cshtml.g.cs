#pragma checksum "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0df2a9c0a6d822f0ef5fd2af7c68eca2cb6b799"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MarcotsContactApp.Pages.Persons.Pages_Persons_Delete), @"mvc.1.0.razor-page", @"/Pages/Persons/Delete.cshtml")]
namespace MarcotsContactApp.Pages.Persons
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0df2a9c0a6d822f0ef5fd2af7c68eca2cb6b799", @"/Pages/Persons/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ef681e84ad6d51e2c28f7f0d9c1842b75368fd9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Persons_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Contact</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.OwnerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.OwnerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.MidName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.MidName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Telephone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Telephone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 59 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Kids));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Kids));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 65 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 68 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 71 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 74 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 77 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.InsertedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 80 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.InsertedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 83 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.ModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 86 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.ModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 89 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.ContactStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 92 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.ContactStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 95 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.BirthDayNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 98 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.BirthDayNavigation.DayId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 101 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.BirthMonthNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 104 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.BirthMonthNavigation.MonthId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 107 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 110 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Status.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0df2a9c0a6d822f0ef5fd2af7c68eca2cb6b79917408", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0df2a9c0a6d822f0ef5fd2af7c68eca2cb6b79917675", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 115 "C:\Users\JaydenExpress\Source\Repos\jmunyeneh\Marcots9798\MarcotsContactApp\Pages\Persons\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Contact.PersonId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0df2a9c0a6d822f0ef5fd2af7c68eca2cb6b79919501", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MarcotsContactApp.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MarcotsContactApp.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MarcotsContactApp.DeleteModel>)PageContext?.ViewData;
        public MarcotsContactApp.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
