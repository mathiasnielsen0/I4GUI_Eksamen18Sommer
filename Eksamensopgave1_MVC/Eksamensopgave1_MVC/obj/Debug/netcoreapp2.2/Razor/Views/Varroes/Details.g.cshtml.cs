#pragma checksum "C:\Users\Mathias\source\repos\Eksamensopgave1_MVC\Eksamensopgave1_MVC\Views\Varroes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e901f7b41c11f39daa13ea77e142670cab17396d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Varroes_Details), @"mvc.1.0.view", @"/Views/Varroes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Varroes/Details.cshtml", typeof(AspNetCore.Views_Varroes_Details))]
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
#line 1 "C:\Users\Mathias\source\repos\Eksamensopgave1_MVC\Eksamensopgave1_MVC\Views\_ViewImports.cshtml"
using Eksamensopgave1_MVC;

#line default
#line hidden
#line 2 "C:\Users\Mathias\source\repos\Eksamensopgave1_MVC\Eksamensopgave1_MVC\Views\_ViewImports.cshtml"
using Eksamensopgave1_MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e901f7b41c11f39daa13ea77e142670cab17396d", @"/Views/Varroes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d24405cb24f3836711db232ac104ef59de0edd24", @"/Views/_ViewImports.cshtml")]
    public class Views_Varroes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Eksamensopgave1_MVC.Models.Varro>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mathias\source\repos\Eksamensopgave1_MVC\Eksamensopgave1_MVC\Views\Varroes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(86, 128, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Varro</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(215, 43, false);
#line 14 "C:\Users\Mathias\source\repos\Eksamensopgave1_MVC\Eksamensopgave1_MVC\Views\Varroes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bistade));

#line default
#line hidden
            EndContext();
            BeginContext(258, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(322, 39, false);
#line 17 "C:\Users\Mathias\source\repos\Eksamensopgave1_MVC\Eksamensopgave1_MVC\Views\Varroes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bistade));

#line default
#line hidden
            EndContext();
            BeginContext(361, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(424, 51, false);
#line 20 "C:\Users\Mathias\source\repos\Eksamensopgave1_MVC\Eksamensopgave1_MVC\Views\Varroes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DatoRegistreret));

#line default
#line hidden
            EndContext();
            BeginContext(475, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(539, 47, false);
#line 23 "C:\Users\Mathias\source\repos\Eksamensopgave1_MVC\Eksamensopgave1_MVC\Views\Varroes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DatoRegistreret));

#line default
#line hidden
            EndContext();
            BeginContext(586, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(649, 46, false);
#line 26 "C:\Users\Mathias\source\repos\Eksamensopgave1_MVC\Eksamensopgave1_MVC\Views\Varroes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AntalMider));

#line default
#line hidden
            EndContext();
            BeginContext(695, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(759, 42, false);
#line 29 "C:\Users\Mathias\source\repos\Eksamensopgave1_MVC\Eksamensopgave1_MVC\Views\Varroes\Details.cshtml"
       Write(Html.DisplayFor(model => model.AntalMider));

#line default
#line hidden
            EndContext();
            BeginContext(801, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(864, 56, false);
#line 32 "C:\Users\Mathias\source\repos\Eksamensopgave1_MVC\Eksamensopgave1_MVC\Views\Varroes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ObservationsVarighed));

#line default
#line hidden
            EndContext();
            BeginContext(920, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(984, 52, false);
#line 35 "C:\Users\Mathias\source\repos\Eksamensopgave1_MVC\Eksamensopgave1_MVC\Views\Varroes\Details.cshtml"
       Write(Html.DisplayFor(model => model.ObservationsVarighed));

#line default
#line hidden
            EndContext();
            BeginContext(1036, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1099, 43, false);
#line 38 "C:\Users\Mathias\source\repos\Eksamensopgave1_MVC\Eksamensopgave1_MVC\Views\Varroes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Notater));

#line default
#line hidden
            EndContext();
            BeginContext(1142, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1206, 39, false);
#line 41 "C:\Users\Mathias\source\repos\Eksamensopgave1_MVC\Eksamensopgave1_MVC\Views\Varroes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Notater));

#line default
#line hidden
            EndContext();
            BeginContext(1245, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1308, 51, false);
#line 44 "C:\Users\Mathias\source\repos\Eksamensopgave1_MVC\Eksamensopgave1_MVC\Views\Varroes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationUser));

#line default
#line hidden
            EndContext();
            BeginContext(1359, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1423, 50, false);
#line 47 "C:\Users\Mathias\source\repos\Eksamensopgave1_MVC\Eksamensopgave1_MVC\Views\Varroes\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationUser.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1473, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1520, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e901f7b41c11f39daa13ea77e142670cab17396d9671", async() => {
                BeginContext(1571, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\Mathias\source\repos\Eksamensopgave1_MVC\Eksamensopgave1_MVC\Views\Varroes\Details.cshtml"
                           WriteLiteral(Model.VarroId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1579, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1587, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e901f7b41c11f39daa13ea77e142670cab17396d12016", async() => {
                BeginContext(1609, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1625, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Eksamensopgave1_MVC.Models.Varro> Html { get; private set; }
    }
}
#pragma warning restore 1591
