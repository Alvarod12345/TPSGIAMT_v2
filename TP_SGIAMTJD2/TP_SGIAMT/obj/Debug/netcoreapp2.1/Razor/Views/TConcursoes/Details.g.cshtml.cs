#pragma checksum "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMTJD2\TP_SGIAMT\Views\TConcursoes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d87d5f78b873f2169d3b93fd91f6dbb03af4ca3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TConcursoes_Details), @"mvc.1.0.view", @"/Views/TConcursoes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TConcursoes/Details.cshtml", typeof(AspNetCore.Views_TConcursoes_Details))]
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
#line 1 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMTJD2\TP_SGIAMT\Views\_ViewImports.cshtml"
using TP_SGIAMT;

#line default
#line hidden
#line 2 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMTJD2\TP_SGIAMT\Views\_ViewImports.cshtml"
using TP_SGIAMT.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d87d5f78b873f2169d3b93fd91f6dbb03af4ca3", @"/Views/TConcursoes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca981b27afbd8e7d4aba29c8ce9b9955aebba5b", @"/Views/_ViewImports.cshtml")]
    public class Views_TConcursoes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TP_SGIAMT.Models.TConcurso>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMTJD2\TP_SGIAMT\Views\TConcursoes\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 229, true);
            WriteLiteral("\r\n\r\n<section class=\"content-header\">\r\n    <h2>Detalle del Curso</h2>\r\n</section>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt scope=\"col\">\r\n            Nombre Concurso\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(357, 43, false);
#line 19 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMTJD2\TP_SGIAMT\Views\TConcursoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.VcNombreCon));

#line default
#line hidden
            EndContext();
            BeginContext(400, 112, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt scope=\"col\">\r\n            Lugar Concurso\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(513, 42, false);
#line 25 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMTJD2\TP_SGIAMT\Views\TConcursoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.VcLugarCon));

#line default
#line hidden
            EndContext();
            BeginContext(555, 112, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt scope=\"col\">\r\n            Fecha Concurso\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(668, 63, false);
#line 31 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMTJD2\TP_SGIAMT\Views\TConcursoes\Details.cshtml"
       Write(Html.ValueFor(model => model.DcFechaConcurso, "{0:dd/MM/yyyy}"));

#line default
#line hidden
            EndContext();
            BeginContext(731, 117, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt scope=\"col\">\r\n            Cantidad de Seriado\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(849, 46, false);
#line 37 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMTJD2\TP_SGIAMT\Views\TConcursoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.IcCantidadSeri));

#line default
#line hidden
            EndContext();
            BeginContext(895, 115, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt scope=\"col\">\r\n            Cantidad de Nobel\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1011, 46, false);
#line 43 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMTJD2\TP_SGIAMT\Views\TConcursoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.IcCantidadNove));

#line default
#line hidden
            EndContext();
            BeginContext(1057, 117, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt scope=\"col\">\r\n            Estado del Concurso\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1175, 68, false);
#line 49 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMTJD2\TP_SGIAMT\Views\TConcursoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.FkIecIdEstadoNavigation.VeNombreEsta));

#line default
#line hidden
            EndContext();
            BeginContext(1243, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1290, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cf5593950d14b468c524324e459b3e8", async() => {
                BeginContext(1337, 8, true);
                WriteLiteral("Regresar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            BeginContext(1349, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TP_SGIAMT.Models.TConcurso> Html { get; private set; }
    }
}
#pragma warning restore 1591