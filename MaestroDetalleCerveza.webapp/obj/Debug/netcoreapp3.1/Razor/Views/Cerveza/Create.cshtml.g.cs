#pragma checksum "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6a88d5236e6de000eeb1c81fc68135789f8b221"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cerveza_Create), @"mvc.1.0.view", @"/Views/Cerveza/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6a88d5236e6de000eeb1c81fc68135789f8b221", @"/Views/Cerveza/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86363db714e733618fc796fb962f431305f5d331", @"/Views/_ViewImports.cshtml")]
    public class Views_Cerveza_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MaestroDetalleCerveza.webapp.Models.ViewModels.CervezaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Create.cshtml"
  
    ViewData["Title"] = "CERVEZA";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Create.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div style=\"color:chartreuse\">\r\n    ");
#nullable restore
#line 10 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Create.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</div>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Create.cshtml"
 using (Html.BeginForm("Add", "Cerveza", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 17 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Create.cshtml"
   Write(Html.LabelFor(d => d.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 18 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Create.cshtml"
   Write(Html.TextBoxFor(x => x.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 21 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Create.cshtml"
   Write(Html.LabelFor(x => x.Estilo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 22 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Create.cshtml"
   Write(Html.TextBoxFor(x => x.Estilo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>


    <hr />

    <div class=""form-group"">
        Nombre
        <input type=""text"" id=""NombreIngrediente"" />
        Gramos
        <input type=""number"" id=""Gramos"" />
        <input value=""Agregar"" type=""button"" onclick=""AgregarIngrediente(); return false;"" />
    </div>

    <br />

    <div id=""divIngredientes"">
        <table id=""tablaIngredientes"" style=""width:100%;"">
            <tr>
                <th>
                    Nombre Ingrediente
                </th>
                <th>
                    Gramos
                </th>
            </tr>
        </table>
    </div>

    <div>
        <input type=""submit"" />
    </div>

</div>
");
#nullable restore
#line 56 "C:\Users\German Suarez\source\repos\WebMaestroDetalleCerveza\MaestroDetalleCerveza.webapp\Views\Cerveza\Create.cshtml"
    
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    var num = 0;
    function AgregarIngrediente() {
        console.log(""hola"");
        
        let NombreIngrediente = document.getElementById(""NombreIngrediente"").value;
        let Gramos = document.getElementById(""Gramos"").value;

        // Se obtiene referencia a la tabla ""tablaIngredientes""
        let Tabla = document.getElementById(""tablaIngredientes"");
       

        // Se crea una nueva fila (""tr""). Luego, se agregará a la tabla refeenciada por ""Tabla""
        let TR = document.createElement(""tr"");

        // Se crean las nuevas columnas de datos con valores (""td"")
        let TDNombreIngrediente = document.createElement(""td"");
        let TDGramos = document.createElement(""td"");

        // Se agregan las nuevas columnas de datos con valores, a la fila recién creada
        TR.appendChild(TDNombreIngrediente);
        TR.appendChild(TDGramos);

        TDNombreIngrediente.innerHTML = NombreIngrediente;
        TDGramos.innerHTML = Gramos;
        
       ");
            WriteLiteral(@" //TDTotal.innerHTML = parseFloat(Cantidad) * parseFloat(PrecioUnitario);

        // Se agrega la nueva fila, a la referencia a la tabla
        Tabla.appendChild(TR);

        // Se agregan ""hiddens""
        // Nota es importante que si, en la clase ""CervezaViewModel"", el ""List"" se llama ""ingredientes"" con minúsculas; aquí, debe ser 
        // con minúsculas. Lo mismo para ""Nombre"" y ""Gramos"". Es ""Case Sensitive"", se deben respetar mayúsculas y minúsculas.
        let DivIngredientes = document.getElementById(""divIngredientes"");

        let HiddenIndex = document.createElement(""input"");
        let HiddenNombreIngrediente = document.createElement(""input"");
        let HiddenGramos = document.createElement(""input"");

        HiddenIndex.name = ""ingredientes.Index"";
        HiddenIndex.value = num;
        HiddenIndex.type = ""hidden"";

        HiddenNombreIngrediente.name = ""ingredientes["" + num + ""].NombreIngrediente"";
        HiddenNombreIngrediente.value = NombreIngrediente;
        H");
            WriteLiteral(@"iddenNombreIngrediente.type = ""hidden"";

        HiddenGramos.name = ""ingredientes["" + num + ""].Gramos"";
        HiddenGramos.value = Gramos;
        HiddenGramos.type = ""hidden"";


        // Se agregan los 'hidden"" al ""div""
        DivIngredientes.appendChild(HiddenIndex);
        DivIngredientes.appendChild(HiddenNombreIngrediente);
        DivIngredientes.appendChild(HiddenGramos);

        // Se incrementa el puntero (contador), para la siguiente vez que se invoque a esta función ""JavaScript""
        ++num;
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MaestroDetalleCerveza.webapp.Models.ViewModels.CervezaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
