#pragma checksum "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Home\Seguro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ed439db3a227c98c621e4f197e1d6e63abd4658"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Seguro), @"mvc.1.0.view", @"/Views/Home/Seguro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Seguro.cshtml", typeof(AspNetCore.Views_Home_Seguro))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ed439db3a227c98c621e4f197e1d6e63abd4658", @"/Views/Home/Seguro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Seguro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Home\Seguro.cshtml"
  
	ViewData["Title"] = "Admin";

#line default
#line hidden
            BeginContext(40, 69, true);
            WriteLiteral("\r\n<h1>Seguro</h1>\r\n\r\n<p>Usted está autenticado. Su identificación es ");
            EndContext();
            BeginContext(110, 18, false);
#line 8 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Home\Seguro.cshtml"
                                           Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(128, 21, true);
            WriteLiteral("</p>\r\n<p>FullName es ");
            EndContext();
            BeginContext(150, 50, false);
#line 9 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Home\Seguro.cshtml"
          Write(User.Claims.First(x => x.Type == "FullName").Value);

#line default
#line hidden
            EndContext();
            BeginContext(200, 37, true);
            WriteLiteral("</p>\r\n<p>Lista de claims:</p>\r\n<ul>\r\n");
            EndContext();
#line 12 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Home\Seguro.cshtml"
     foreach (var c in User.Claims)
	{

#line default
#line hidden
            BeginContext(275, 9, true);
            WriteLiteral("\t\t<li><b>");
            EndContext();
            BeginContext(286, 11, false);
#line 14 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Home\Seguro.cshtml"
           Write(c.Type+": ");

#line default
#line hidden
            EndContext();
            BeginContext(298, 4, true);
            WriteLiteral("</b>");
            EndContext();
            BeginContext(303, 7, false);
#line 14 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Home\Seguro.cshtml"
                            Write(c.Value);

#line default
#line hidden
            EndContext();
            BeginContext(310, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 15 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Home\Seguro.cshtml"
	}

#line default
#line hidden
            BeginContext(321, 7, true);
            WriteLiteral("</ul>\r\n");
            EndContext();
            BeginContext(329, 88, false);
#line 17 "C:\Users\Gaby\source\repos\WebApplication1\WebApplication1\Views\Home\Seguro.cshtml"
Write(Html.ActionLink("Salir", "Logout", "Usuarios", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
