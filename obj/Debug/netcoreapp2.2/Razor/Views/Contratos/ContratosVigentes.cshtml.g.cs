#pragma checksum "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Contratos\ContratosVigentes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c2be12862e9b2774547eb212e4af44d49280187"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contratos_ContratosVigentes), @"mvc.1.0.view", @"/Views/Contratos/ContratosVigentes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contratos/ContratosVigentes.cshtml", typeof(AspNetCore.Views_Contratos_ContratosVigentes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c2be12862e9b2774547eb212e4af44d49280187", @"/Views/Contratos/ContratosVigentes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Contratos_ContratosVigentes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.Contrato>>
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Contratos\ContratosVigentes.cshtml"
  
    ViewData["Title"] = "ContratosVigentes";

#line default
#line hidden
            BeginContext(108, 41, true);
            WriteLiteral("\r\n<h1>ContratosVigentes</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(149, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c2be12862e9b2774547eb212e4af44d492801873990", async() => {
                BeginContext(172, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(186, 105, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n           \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(292, 47, false);
#line 17 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Contratos\ContratosVigentes.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaInicio));

#line default
#line hidden
            EndContext();
            BeginContext(339, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(395, 44, false);
#line 20 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Contratos\ContratosVigentes.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaFin));

#line default
#line hidden
            EndContext();
            BeginContext(439, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(495, 48, false);
#line 23 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Contratos\ContratosVigentes.cshtml"
           Write(Html.DisplayNameFor(model => model.MontoMensual));

#line default
#line hidden
            EndContext();
            BeginContext(543, 213, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Propiedad\r\n            </th>\r\n            <th>\r\n               Inquilino\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Contratos\ContratosVigentes.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(788, 62, true);
            WriteLiteral("        <tr>\r\n            \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(851, 46, false);
#line 39 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Contratos\ContratosVigentes.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaInicio));

#line default
#line hidden
            EndContext();
            BeginContext(897, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(953, 43, false);
#line 42 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Contratos\ContratosVigentes.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaFin));

#line default
#line hidden
            EndContext();
            BeginContext(996, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                $ ");
            EndContext();
            BeginContext(1054, 47, false);
#line 45 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Contratos\ContratosVigentes.cshtml"
             Write(Html.DisplayFor(modelItem => item.MontoMensual));

#line default
#line hidden
            EndContext();
            BeginContext(1101, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1157, 63, false);
#line 48 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Contratos\ContratosVigentes.cshtml"
           Write(Html.DisplayFor(modelItem => item.PropiedadAlquilada.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(1220, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1276, 53, false);
#line 51 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Contratos\ContratosVigentes.cshtml"
           Write(Html.DisplayFor(modelItem => item.Locatario.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(1329, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1348, 51, false);
#line 52 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Contratos\ContratosVigentes.cshtml"
           Write(Html.DisplayFor(modelItem => item.Locatario.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1399, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1455, 62, false);
#line 55 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Contratos\ContratosVigentes.cshtml"
           Write(Html.ActionLink("Editar", "Edit", new {  id=item.IdContrato }));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1538, 66, false);
#line 56 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Contratos\ContratosVigentes.cshtml"
           Write(Html.ActionLink("Eliminar", "Delete", new {  id=item.IdContrato }));

#line default
#line hidden
            EndContext();
            BeginContext(1604, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 59 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Contratos\ContratosVigentes.cshtml"
}

#line default
#line hidden
            BeginContext(1643, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.Contrato>> Html { get; private set; }
    }
}
#pragma warning restore 1591
