#pragma checksum "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\MostrarInmueblesPorPropietario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee74c14057bc2fa3aeed94bec38aca643e3b0d42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inmuebles_MostrarInmueblesPorPropietario), @"mvc.1.0.view", @"/Views/Inmuebles/MostrarInmueblesPorPropietario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inmuebles/MostrarInmueblesPorPropietario.cshtml", typeof(AspNetCore.Views_Inmuebles_MostrarInmueblesPorPropietario))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee74c14057bc2fa3aeed94bec38aca643e3b0d42", @"/Views/Inmuebles/MostrarInmueblesPorPropietario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Inmuebles_MostrarInmueblesPorPropietario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.Inmueble>>
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
#line 3 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\MostrarInmueblesPorPropietario.cshtml"
  
    ViewData["Title"] = "MostrarInmueblesPorPropietario";

#line default
#line hidden
            BeginContext(121, 49, true);
            WriteLiteral("\r\n<h1>Inmuebles por Propietario</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(170, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee74c14057bc2fa3aeed94bec38aca643e3b0d424816", async() => {
                BeginContext(269, 11, true);
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
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 10 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\MostrarInmueblesPorPropietario.cshtml"
                                                                   WriteLiteral(ViewBag.IdPropietario);

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
            BeginContext(284, 94, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(379, 45, false);
#line 17 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\MostrarInmueblesPorPropietario.cshtml"
           Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(424, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(480, 45, false);
#line 20 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\MostrarInmueblesPorPropietario.cshtml"
           Write(Html.DisplayNameFor(model => model.Ambientes));

#line default
#line hidden
            EndContext();
            BeginContext(525, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(581, 46, false);
#line 23 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\MostrarInmueblesPorPropietario.cshtml"
           Write(Html.DisplayNameFor(model => model.Superficie));

#line default
#line hidden
            EndContext();
            BeginContext(627, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(683, 43, false);
#line 26 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\MostrarInmueblesPorPropietario.cshtml"
           Write(Html.DisplayNameFor(model => model.Latitud));

#line default
#line hidden
            EndContext();
            BeginContext(726, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(782, 44, false);
#line 29 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\MostrarInmueblesPorPropietario.cshtml"
           Write(Html.DisplayNameFor(model => model.Longitud));

#line default
#line hidden
            EndContext();
            BeginContext(826, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(882, 49, false);
#line 32 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\MostrarInmueblesPorPropietario.cshtml"
           Write(Html.DisplayNameFor(model => model.IdPropietario));

#line default
#line hidden
            EndContext();
            BeginContext(931, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(987, 46, false);
#line 35 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\MostrarInmueblesPorPropietario.cshtml"
           Write(Html.DisplayNameFor(model => model.Disponible));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 41 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\MostrarInmueblesPorPropietario.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1151, 50, true);
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1202, 44, false);
#line 45 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\MostrarInmueblesPorPropietario.cshtml"
           Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(1246, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1302, 44, false);
#line 48 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\MostrarInmueblesPorPropietario.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ambientes));

#line default
#line hidden
            EndContext();
            BeginContext(1346, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1402, 45, false);
#line 51 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\MostrarInmueblesPorPropietario.cshtml"
           Write(Html.DisplayFor(modelItem => item.Superficie));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1503, 42, false);
#line 54 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\MostrarInmueblesPorPropietario.cshtml"
           Write(Html.DisplayFor(modelItem => item.Latitud));

#line default
#line hidden
            EndContext();
            BeginContext(1545, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1601, 43, false);
#line 57 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\MostrarInmueblesPorPropietario.cshtml"
           Write(Html.DisplayFor(modelItem => item.Longitud));

#line default
#line hidden
            EndContext();
            BeginContext(1644, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1701, 47, false);
#line 60 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\MostrarInmueblesPorPropietario.cshtml"
            Write(item.Duenio.Nombre + " " + item.Duenio.Apellido);

#line default
#line hidden
            EndContext();
            BeginContext(1749, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1805, 45, false);
#line 63 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\MostrarInmueblesPorPropietario.cshtml"
           Write(Html.DisplayFor(modelItem => item.Disponible));

#line default
#line hidden
            EndContext();
            BeginContext(1850, 49, true);
            WriteLiteral("\r\n            </td>\r\n           \r\n        </tr>\r\n");
            EndContext();
#line 67 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Inmuebles\MostrarInmueblesPorPropietario.cshtml"
}

#line default
#line hidden
            BeginContext(1902, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.Inmueble>> Html { get; private set; }
    }
}
#pragma warning restore 1591
