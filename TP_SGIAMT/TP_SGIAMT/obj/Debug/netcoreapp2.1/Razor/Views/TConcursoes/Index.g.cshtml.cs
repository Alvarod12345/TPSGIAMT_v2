#pragma checksum "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0432eed86451dad449688e07dc7b9db8ce50206"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TConcursoes_Index), @"mvc.1.0.view", @"/Views/TConcursoes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TConcursoes/Index.cshtml", typeof(AspNetCore.Views_TConcursoes_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0432eed86451dad449688e07dc7b9db8ce50206", @"/Views/TConcursoes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca981b27afbd8e7d4aba29c8ce9b9955aebba5b", @"/Views/_ViewImports.cshtml")]
    public class Views_TConcursoes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TP_SGIAMT.Models.TConcurso>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Index.cshtml"
  
    ViewData["Title"] = "Gestionar Concurso";

#line default
#line hidden
            BeginContext(104, 678, true);
            WriteLiteral(@"
<h2>Lista de Concursos</h2>

<hr />
<div class=""row"">
    <table class=""table table-bordered table-hover table-striped"">
        <thead>
            <tr>
                <th scope=""col"">
                    Nombre Concurso
                </th>
                <th scope=""col"">
                    Lugar Concurso
                </th>
                <th scope=""col"">
                    Fecha Concurso
                </th>
                <th scope=""col"">
                    Estado Concurso
                </th>
                <th scope=""col"">
                    Opciones
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 32 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(839, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(912, 46, false);
#line 36 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.VcNombreCon));

#line default
#line hidden
            EndContext();
            BeginContext(958, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1038, 45, false);
#line 39 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.VcLugarCon));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1163, 66, false);
#line 42 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Index.cshtml"
                   Write(Html.ValueFor(modelItem => item.DcFechaConcurso, "{0:dd/MM/yyyy}"));

#line default
#line hidden
            EndContext();
            BeginContext(1229, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1309, 71, false);
#line 45 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FkIecIdEstadoNavigation.VeNombreEsta));

#line default
#line hidden
            EndContext();
            BeginContext(1380, 57, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n\r\n");
            EndContext();
#line 49 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Index.cshtml"
                         if (item.FkIecIdEstadoNavigation.VeNombreEsta == "Finalizado")
                        {

#line default
#line hidden
            BeginContext(1553, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1577, 194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12021fed7d8a4f2c9b8fe2a21f82d30e", async() => {
                BeginContext(1661, 106, true);
                WriteLiteral("\r\n                            <span class=\"glyphicon glyphicon-eye-open\"></span>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Index.cshtml"
                                                                          WriteLiteral(item.PkIcIdConcurso);

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
            BeginContext(1771, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 54 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1857, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1885, 197, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45bd963c3e724d689ecbc634f5e39f5c", async() => {
                BeginContext(1966, 112, true);
                WriteLiteral("\r\n                                <span class=\"glyphicon glyphicon-pencil\"></span>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Index.cshtml"
                                                                           WriteLiteral(item.PkIcIdConcurso);

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
            BeginContext(2082, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2112, 197, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0273b6d6727403ab633aea904a5225c", async() => {
                BeginContext(2194, 111, true);
                WriteLiteral("\r\n                                <span class=\"glyphicon glyphicon-trash\"></span>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Index.cshtml"
                                                                            WriteLiteral(item.PkIcIdConcurso);

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
            BeginContext(2309, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 63 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Index.cshtml"

                        }

#line default
#line hidden
            BeginContext(2340, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 67 "C:\Users\alumno.LABORATORIOS\Source\Repos\TP_SGIAMT\TP_SGIAMT\TP_SGIAMT\Views\TConcursoes\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2405, 83, true);
            WriteLiteral("\r\n        </tbody>\r\n\r\n    </table>\r\n    <div class=\"form-group col-md-4\">\r\n        ");
            EndContext();
            BeginContext(2488, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "513368453ca14f18af26c9236cd04137", async() => {
                BeginContext(2535, 111, true);
                WriteLiteral("\r\n            Crear Concurso\r\n            <span class=\"glyphicon glyphicon-registration-mark\"></span>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2650, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TP_SGIAMT.Models.TConcurso>> Html { get; private set; }
    }
}
#pragma warning restore 1591