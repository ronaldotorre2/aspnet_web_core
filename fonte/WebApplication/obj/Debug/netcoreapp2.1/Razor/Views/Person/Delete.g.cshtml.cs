#pragma checksum "C:\Users\Ronaldo.NSAB\Deve\C#\WebApplicationCore\WebApplication\Views\Person\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6206c9f47ae5f3767fbd176b06fa81f9ba818ea3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Delete), @"mvc.1.0.view", @"/Views/Person/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/Delete.cshtml", typeof(AspNetCore.Views_Person_Delete))]
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
#line 1 "C:\Users\Ronaldo.NSAB\Deve\C#\WebApplicationCore\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#line 2 "C:\Users\Ronaldo.NSAB\Deve\C#\WebApplicationCore\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6206c9f47ae5f3767fbd176b06fa81f9ba818ea3", @"/Views/Person/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication.model.People.Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ronaldo.NSAB\Deve\C#\WebApplicationCore\WebApplication\Views\Person\Delete.cshtml"
  
    ViewBag.Title = "Pessoa";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 138, true);
            WriteLiteral("\r\n<h2>Excluir Pessoa</h2>\r\n\r\n<h3>Deseja mesmo excluir essa pessoa?</h3>\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(269, 40, false);
#line 14 "C:\Users\Ronaldo.NSAB\Deve\C#\WebApplicationCore\WebApplication\Views\Person\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(309, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(355, 36, false);
#line 18 "C:\Users\Ronaldo.NSAB\Deve\C#\WebApplicationCore\WebApplication\Views\Person\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(391, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(437, 45, false);
#line 22 "C:\Users\Ronaldo.NSAB\Deve\C#\WebApplicationCore\WebApplication\Views\Person\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Document1));

#line default
#line hidden
            EndContext();
            BeginContext(482, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(528, 41, false);
#line 26 "C:\Users\Ronaldo.NSAB\Deve\C#\WebApplicationCore\WebApplication\Views\Person\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Document1));

#line default
#line hidden
            EndContext();
            BeginContext(569, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(615, 45, false);
#line 30 "C:\Users\Ronaldo.NSAB\Deve\C#\WebApplicationCore\WebApplication\Views\Person\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Document2));

#line default
#line hidden
            EndContext();
            BeginContext(660, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(706, 41, false);
#line 34 "C:\Users\Ronaldo.NSAB\Deve\C#\WebApplicationCore\WebApplication\Views\Person\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Document2));

#line default
#line hidden
            EndContext();
            BeginContext(747, 34, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n    </dl>\r\n\r\n");
            EndContext();
#line 40 "C:\Users\Ronaldo.NSAB\Deve\C#\WebApplicationCore\WebApplication\Views\Person\Delete.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
            BeginContext(828, 23, false);
#line 42 "C:\Users\Ronaldo.NSAB\Deve\C#\WebApplicationCore\WebApplication\Views\Person\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(855, 165, true);
            WriteLiteral("        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Excluir\" class=\"btn btn-default\" /> \r\n            <span class=\"btn btn-default\">");
            EndContext();
            BeginContext(1021, 34, false);
#line 46 "C:\Users\Ronaldo.NSAB\Deve\C#\WebApplicationCore\WebApplication\Views\Person\Delete.cshtml"
                                     Write(Html.ActionLink("Voltar", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 25, true);
            WriteLiteral("</span>\r\n        </div>\r\n");
            EndContext();
#line 48 "C:\Users\Ronaldo.NSAB\Deve\C#\WebApplicationCore\WebApplication\Views\Person\Delete.cshtml"
    }

#line default
#line hidden
            BeginContext(1087, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.model.People.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591