#pragma checksum "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcd6b32b6a6c8f406bee0cdf53b54eac1f1cba02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cerveza_Delete), @"mvc.1.0.view", @"/Views/Cerveza/Delete.cshtml")]
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
#nullable restore
#line 1 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\_ViewImports.cshtml"
using MaestroDetalleCerveza.webapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\_ViewImports.cshtml"
using MaestroDetalleCerveza.webapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcd6b32b6a6c8f406bee0cdf53b54eac1f1cba02", @"/Views/Cerveza/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86363db714e733618fc796fb962f431305f5d331", @"/Views/_ViewImports.cshtml")]
    public class Views_Cerveza_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MaestroDetalleCerveza.webapp.Models.ViewModels.CervezaEditViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
  
    ViewData["Title"] = "BORRAR CERVEZA";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<h1>");
#nullable restore
#line 10 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n<div style=\"color:chartreuse\">\r\n    ");
#nullable restore
#line 14 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n<input type=\"button\" value=\"Volver al listado de cervezas\"");
            BeginWriteAttribute("onclick", " onclick=\"", 436, "\"", 493, 3);
            WriteAttributeValue("", 446, "location.href=\'", 446, 15, true);
#nullable restore
#line 21 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
WriteAttributeValue("", 461, Url.Action("Index", "Cerveza"), 461, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 492, "\'", 492, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n");
#nullable restore
#line 23 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
 using (Html.BeginForm("Delete", "Cerveza", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 27 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
       Write(Html.LabelFor(d => d.IdCerveza));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 28 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
       Write(Html.TextBoxFor(x => x.IdCerveza, new { @readonly = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 31 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
       Write(Html.LabelFor(d => d.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 32 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
       Write(Html.TextBoxFor(x => x.Nombre, new { @readonly = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 35 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
       Write(Html.LabelFor(x => x.Estilo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 36 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
       Write(Html.TextBoxFor(x => x.Estilo, new { @readonly = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n\r\n        <hr />\r\n\r\n");
            WriteLiteral("\r\n        <br />\r\n\r\n\r\n        <a id=\"numIngredientes\">");
#nullable restore
#line 54 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
                           Write(Model.ingredientes.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>

        <br />
        <div id=""divIngredientes"">
            <table id=""tablaIngredientes"" style=""width:100%;"">
                <tr>
                    <th>
                        Id
                    </th>
                    <th>
                        Nombre Ingrediente
                    </th>
                    <th>
                        Gramos
                    </th>
                </tr>

            </table>

");
#nullable restore
#line 73 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
              
                int contador = 0;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
             foreach (var l_Ítem in Model.ingredientes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"hidden\" name=\"ingredientes.Index\" id=\"ingredientes.Index\"");
            BeginWriteAttribute("value", " value=\"", 2152, "\"", 2169, 1);
#nullable restore
#line 78 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
WriteAttributeValue("", 2160, contador, 2160, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <input");
            BeginWriteAttribute("name", " name=\"", 2197, "\"", 2241, 3);
            WriteAttributeValue("", 2204, "ingredientes[", 2204, 13, true);
#nullable restore
#line 79 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
WriteAttributeValue("", 2217, contador, 2217, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2226, "].IdIngrediente", 2226, 15, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2242, "\"", 2284, 3);
            WriteAttributeValue("", 2247, "ingredientes[", 2247, 13, true);
#nullable restore
#line 79 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
WriteAttributeValue("", 2260, contador, 2260, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2269, "].IdIngrediente", 2269, 15, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n                       value=\"", 2285, "\"", 2338, 1);
#nullable restore
#line 80 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
WriteAttributeValue("", 2317, l_Ítem.IdIngrediente, 2317, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\r\n                <input");
            BeginWriteAttribute("name", " name=\"", 2375, "\"", 2423, 3);
            WriteAttributeValue("", 2382, "ingredientes[", 2382, 13, true);
#nullable restore
#line 81 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
WriteAttributeValue("", 2395, contador, 2395, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2404, "].NombreIngrediente", 2404, 19, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2424, "\"", 2470, 3);
            WriteAttributeValue("", 2429, "ingredientes[", 2429, 13, true);
#nullable restore
#line 81 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
WriteAttributeValue("", 2442, contador, 2442, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2451, "].NombreIngrediente", 2451, 19, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n                       value=\"", 2471, "\"", 2528, 1);
#nullable restore
#line 82 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
WriteAttributeValue("", 2503, l_Ítem.NombreIngrediente, 2503, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\r\n                <input");
            BeginWriteAttribute("name", " name=\"", 2565, "\"", 2602, 3);
            WriteAttributeValue("", 2572, "ingredientes[", 2572, 13, true);
#nullable restore
#line 83 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
WriteAttributeValue("", 2585, contador, 2585, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2594, "].Gramos", 2594, 8, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2603, "\"", 2638, 3);
            WriteAttributeValue("", 2608, "ingredientes[", 2608, 13, true);
#nullable restore
#line 83 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
WriteAttributeValue("", 2621, contador, 2621, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2630, "].Gramos", 2630, 8, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n                       value=\"", 2639, "\"", 2685, 1);
#nullable restore
#line 84 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
WriteAttributeValue("", 2671, l_Ítem.Gramos, 2671, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\r\n                <br />\r\n");
#nullable restore
#line 86 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"

                ++@contador;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcd6b32b6a6c8f406bee0cdf53b54eac1f1cba0214864", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dcd6b32b6a6c8f406bee0cdf53b54eac1f1cba0215135", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 94 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.IdCerveza);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 98 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Delete.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MaestroDetalleCerveza.webapp.Models.ViewModels.CervezaEditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
