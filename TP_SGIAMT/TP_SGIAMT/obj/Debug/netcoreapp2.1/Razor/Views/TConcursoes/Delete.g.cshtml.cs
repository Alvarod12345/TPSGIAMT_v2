#pragma checksum "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1cbcf1ad424dcdc1f93ecd3b7985a81917e820d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TConcursoes_Delete), @"mvc.1.0.view", @"/Views/TConcursoes/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TConcursoes/Delete.cshtml", typeof(AspNetCore.Views_TConcursoes_Delete))]
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
#line 1 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\_ViewImports.cshtml"
using TP_SGIAMT;

#line default
#line hidden
#line 2 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\_ViewImports.cshtml"
using TP_SGIAMT.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1cbcf1ad424dcdc1f93ecd3b7985a81917e820d", @"/Views/TConcursoes/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca981b27afbd8e7d4aba29c8ce9b9955aebba5b", @"/Views/_ViewImports.cshtml")]
    public class Views_TConcursoes_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TP_SGIAMT.Models.TConcurso>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(79, 223, true);
            WriteLiteral("\r\n<h2>Eliminar Concurso</h2>\r\n\r\n<h3>Desea eliminar el Concurso?</h3>\r\n<div>\r\n    \r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt scope=\"col\">\r\n            Nombre Concurso\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(303, 43, false);
#line 18 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VcNombreCon));

#line default
#line hidden
            EndContext();
            BeginContext(346, 112, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt scope=\"col\">\r\n            Lugar Concurso\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(459, 42, false);
#line 24 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VcLugarCon));

#line default
#line hidden
            EndContext();
            BeginContext(501, 112, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt scope=\"col\">\r\n            Fecha Concurso\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(614, 63, false);
#line 30 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Delete.cshtml"
       Write(Html.ValueFor(model => model.DcFechaConcurso, "{0:dd/MM/yyyy}"));

#line default
#line hidden
            EndContext();
            BeginContext(677, 117, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt scope=\"col\">\r\n            Cantidad de Seriado\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(795, 46, false);
#line 36 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IcCantidadSeri));

#line default
#line hidden
            EndContext();
            BeginContext(841, 115, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt scope=\"col\">\r\n            Cantidad de Nobel\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(957, 46, false);
#line 42 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IcCantidadNove));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 117, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt scope=\"col\">\r\n            Estado del Concurso\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1121, 68, false);
#line 48 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FkIecIdEstadoNavigation.VeNombreEsta));

#line default
#line hidden
            EndContext();
            BeginContext(1189, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1227, 389, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "482320a9f0114935a7a124c37ba84d2a", async() => {
                BeginContext(1253, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1263, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ced61be7a1ad483fa99fa45998f5fc4c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 53 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PkIcIdConcurso);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1311, 161, true);
                WriteLiteral("\r\n        <button type=\"submit\" value=\"Eliminar\" class=\"btn btn-danger\">\r\n            <span class=\"glyphicon glyphicon-trash\"></span> Eliminar</button>\r\n        ");
                EndContext();
                BeginContext(1472, 135, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60b2ad2924994db7bce25b0a1dfaca67", async() => {
                    BeginContext(1518, 85, true);
                    WriteLiteral("\r\n            <span class=\"glyphicon glyphicon-arrow-left\"></span> Regresar\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
                BeginContext(1607, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1616, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TP_SGIAMT.Models.TConcurso> Html { get; private set; }
    }
}
#pragma warning restore 1591
