#pragma checksum "C:\Users\rrody\Desktop\Proyecto_final\Pages\RegistroUsers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70d6dcf8dace543447e038b6e50d0dfd01e01732"
// <auto-generated/>
#pragma warning disable 1591
namespace Proyecto_final.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rrody\Desktop\Proyecto_final\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rrody\Desktop\Proyecto_final\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rrody\Desktop\Proyecto_final\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rrody\Desktop\Proyecto_final\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rrody\Desktop\Proyecto_final\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rrody\Desktop\Proyecto_final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rrody\Desktop\Proyecto_final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rrody\Desktop\Proyecto_final\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rrody\Desktop\Proyecto_final\_Imports.razor"
using Proyecto_final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rrody\Desktop\Proyecto_final\_Imports.razor"
using Proyecto_final.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/registro")]
    public partial class RegistroUsers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"cuerpo\"><div class=\"container contenido-registro\"><form action class=\"FormularioRegistro\"><h2>Registro de usuarios</h2>\r\n            <div class=\"inputsss\"><input type=\"text\" placeholder=\"Nombre\">\r\n                <input type=\"text\" placeholder=\"Apellido\">\r\n                <input type=\"text\" placeholder=\"Cedula\">\r\n                <input type=\"text\" placeholder=\"Usuario\">\r\n                <input type=\"text\" placeholder=\"Contraseña\"></div>\r\n            <div class=\"Botones-Registro\"><button type=\"submit\">Agregar</button>\r\n                <button id=\"BtnVerUsuarios\">Ver usuarios</button></div></form>\r\n\r\n        <img src=\"imgs/registro.png\" alt></div>\r\n\r\n\r\n    <div class=\"tabla-registro\" id=\"tablamodal\"><i class=\"fas fa-times\"></i>\r\n        <div class=\"contenido-tabla-registro\"><table><thead><tr><td>Nombre</td>\r\n                        <td>Apellido</td>\r\n                        <td>Cedula</td>\r\n                        <td>Usuario</td>\r\n                        <td>Contraseña</td>\r\n                        <td>Acciones</td></tr></thead>\r\n                <tbody><tr><td>data</td>\r\n                        <td>data</td>\r\n                        <td>data</td>\r\n                        <td>data</td>\r\n                        <td>data</td>\r\n                        <td><i class=\"fas fa-user-minus btn btn-info\"></i>\r\n                        <i class=\"fas fa-pen-alt btn btn-danger\"></i></td></tr>\r\n                    <tr><td>data</td>\r\n                        <td>data</td>\r\n                        <td>data</td>\r\n                        <td>data</td>\r\n                        <td>data</td>\r\n                        <td><a href class=\"btn btn-info\"><i class=\"fas fa-user-minus\"></i></a>\r\n                            <a href class=\"btn btn-danger\"><i class=\"fas fa-pen-alt\"></i></a></td></tr></tbody></table></div></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
