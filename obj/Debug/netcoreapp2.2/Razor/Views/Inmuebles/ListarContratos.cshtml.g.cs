#pragma checksum "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\ListarContratos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30b85033641a2e2db5336d9fa53170f5c012abc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inmuebles_ListarContratos), @"mvc.1.0.view", @"/Views/Inmuebles/ListarContratos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inmuebles/ListarContratos.cshtml", typeof(AspNetCore.Views_Inmuebles_ListarContratos))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30b85033641a2e2db5336d9fa53170f5c012abc8", @"/Views/Inmuebles/ListarContratos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Inmuebles_ListarContratos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.Contrato>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\ListarContratos.cshtml"
  
    ViewData["Title"] = "ListarContratos";

#line default
#line hidden
            BeginContext(106, 49, true);
            WriteLiteral("\r\n<h1> Contratos del Inmueble  </h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(155, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30b85033641a2e2db5336d9fa53170f5c012abc84680", async() => {
                BeginContext(217, 11, true);
                WriteLiteral("Crear Nuevo");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(232, 105, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n           \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(338, 47, false);
#line 17 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\ListarContratos.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaInicio));

#line default
#line hidden
            EndContext();
            BeginContext(385, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(441, 44, false);
#line 20 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\ListarContratos.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaFin));

#line default
#line hidden
            EndContext();
            BeginContext(485, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(541, 48, false);
#line 23 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\ListarContratos.cshtml"
           Write(Html.DisplayNameFor(model => model.MontoMensual));

#line default
#line hidden
            EndContext();
            BeginContext(589, 212, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n               Propiedad\r\n            </th>\r\n            <th>\r\n               Inquilino\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\ListarContratos.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(833, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(882, 46, false);
#line 38 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\ListarContratos.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaInicio));

#line default
#line hidden
            EndContext();
            BeginContext(928, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(984, 43, false);
#line 41 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\ListarContratos.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaFin));

#line default
#line hidden
            EndContext();
            BeginContext(1027, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1083, 47, false);
#line 44 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\ListarContratos.cshtml"
           Write(Html.DisplayFor(modelItem => item.MontoMensual));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1186, 63, false);
#line 47 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\ListarContratos.cshtml"
           Write(Html.DisplayFor(modelItem => item.PropiedadAlquilada.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(1249, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1305, 53, false);
#line 50 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\ListarContratos.cshtml"
           Write(Html.DisplayFor(modelItem => item.Locatario.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(1358, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1377, 51, false);
#line 51 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\ListarContratos.cshtml"
           Write(Html.DisplayFor(modelItem => item.Locatario.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1428, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1484, 76, false);
#line 54 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\ListarContratos.cshtml"
           Write(Html.ActionLink("Editar", "Edit", "Contratos", new { id = item.IdContrato }));

#line default
#line hidden
            EndContext();
            BeginContext(1560, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1581, 79, false);
#line 55 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\ListarContratos.cshtml"
           Write(Html.ActionLink("Eliminar", "Delete", "Contratos", new {  id=item.IdContrato }));

#line default
#line hidden
            EndContext();
            BeginContext(1660, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 58 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\ListarContratos.cshtml"
}

#line default
#line hidden
            BeginContext(1699, 24, true);
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