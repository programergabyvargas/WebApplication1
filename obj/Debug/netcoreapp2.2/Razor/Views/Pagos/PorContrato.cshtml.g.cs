#pragma checksum "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Pagos\PorContrato.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2daa8b2aa43c63a352c9c1ab518fc7f44dee7a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pagos_PorContrato), @"mvc.1.0.view", @"/Views/Pagos/PorContrato.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pagos/PorContrato.cshtml", typeof(AspNetCore.Views_Pagos_PorContrato))]
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
#line 1 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2daa8b2aa43c63a352c9c1ab518fc7f44dee7a4", @"/Views/Pagos/PorContrato.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Pagos_PorContrato : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.Pago>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Pagos\PorContrato.cshtml"
  
    ViewData["Title"] = "Pagos por Contrato";

#line default
#line hidden
            BeginContext(105, 42, true);
            WriteLiteral("\r\n<h1>Pagos Por Contrato</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(147, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2daa8b2aa43c63a352c9c1ab518fc7f44dee7a43908", async() => {
                BeginContext(205, 11, true);
                WriteLiteral("Crear Nuevo");
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
#line 10 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Pagos\PorContrato.cshtml"
                             WriteLiteral(ViewBag.IdContrato);

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
            BeginContext(220, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(313, 42, false);
#line 16 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Pagos\PorContrato.cshtml"
           Write(Html.DisplayNameFor(model => model.IdPago));

#line default
#line hidden
            EndContext();
            BeginContext(355, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(411, 43, false);
#line 19 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Pagos\PorContrato.cshtml"
           Write(Html.DisplayNameFor(model => model.NroPago));

#line default
#line hidden
            EndContext();
            BeginContext(454, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(510, 45, false);
#line 22 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Pagos\PorContrato.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaPago));

#line default
#line hidden
            EndContext();
            BeginContext(555, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(611, 43, false);
#line 25 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Pagos\PorContrato.cshtml"
           Write(Html.DisplayNameFor(model => model.Importe));

#line default
#line hidden
            EndContext();
            BeginContext(654, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(710, 46, false);
#line 28 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Pagos\PorContrato.cshtml"
           Write(Html.DisplayNameFor(model => model.IdContrato));

#line default
#line hidden
            EndContext();
            BeginContext(756, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Pagos\PorContrato.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(874, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(923, 41, false);
#line 37 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Pagos\PorContrato.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdPago));

#line default
#line hidden
            EndContext();
            BeginContext(964, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1020, 42, false);
#line 40 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Pagos\PorContrato.cshtml"
           Write(Html.DisplayFor(modelItem => item.NroPago));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1118, 44, false);
#line 43 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Pagos\PorContrato.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaPago));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1218, 42, false);
#line 46 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Pagos\PorContrato.cshtml"
           Write(Html.DisplayFor(modelItem => item.Importe));

#line default
#line hidden
            EndContext();
            BeginContext(1260, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1316, 45, false);
#line 49 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Pagos\PorContrato.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdContrato));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1417, 65, false);
#line 52 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Pagos\PorContrato.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1482, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1503, 71, false);
#line 53 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Pagos\PorContrato.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1574, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1595, 69, false);
#line 54 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Pagos\PorContrato.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1664, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Pagos\PorContrato.cshtml"
}

#line default
#line hidden
            BeginContext(1703, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.Pago>> Html { get; private set; }
    }
}
#pragma warning restore 1591
