#pragma checksum "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Times.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd9d9948903791a3f34a5bd75311910b9d06a911"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWasm.FrontEnd.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.FrontEnd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.FrontEnd.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.FrontEnd.Repositorio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasmServer.Client.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.Compartilhado.Entidades;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Times")]
    public partial class Times : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Times.razor"
 if (DicionarioEstados is not null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h1>Classificação por Estados</h1>");
            __builder.OpenElement(1, "ul");
#nullable restore
#line 8 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Times.razor"
                     foreach (var Estados in DicionarioEstados)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "li");
            __builder.AddAttribute(3, "class", "cidades");
            __builder.OpenElement(4, "h3");
            __builder.AddContent(5, 
#nullable restore
#line 12 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Times.razor"
             Estados.Key

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, " | Pontuação ");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n\n\n        ");
            __builder.OpenElement(8, "ol");
            __builder.AddAttribute(9, "class", "times");
#nullable restore
#line 17 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Times.razor"
             foreach (var time in Estados.Value)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "li");
            __builder.AddContent(11, "Times: ");
            __builder.AddContent(12, 
#nullable restore
#line 19 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Times.razor"
            time.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, " | ");
            __builder.AddContent(14, 
#nullable restore
#line 19 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Times.razor"
                         time.Pontos

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Times.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Times.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Times.razor"
                     }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "<h1>Tabela de classifição</h1>\n\n\n");
            __builder.OpenElement(16, "table");
            __builder.AddAttribute(17, "class", "styled-table");
            __builder.AddMarkupContent(18, "<thead><tr class=\"cabecario\"><th>ESTADO</th>\n            <th>TIME</th>\n            <th>PONTUACAO</th>\n            <th>GOLS</th></tr></thead>\n    ");
            __builder.OpenElement(19, "tbody");
#nullable restore
#line 47 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Times.razor"
         foreach (var Time in ListaTimes.OrderByDescending(o => o.Pontos).ThenByDescending(o => o.SaldoDeGols))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "tr");
            __builder.AddAttribute(21, "class", "active-row");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 50 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Times.razor"
         Time.Estado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n\n    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 52 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Times.razor"
         Time.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n\n    ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 54 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Times.razor"
         Time.Pontos

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n\n    ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 56 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Times.razor"
         Time.SaldoDeGols

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Times.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n\n\n\n\n\n\n\n\n");
            __builder.AddMarkupContent(34, @"<style>
    .styled-table {
        border-collapse: collapse;
        margin: auto;
        font-size: 0.9em;
        font-family: sans-serif;
        min-width: 400px;
        box-shadow: 0 0 20px rgba(0, 0, 0, 0.15);
        position: center;
    }

        .styled-table thead tr {
            background-color: #dcdcdc;
            color: #000;
            text-align: center;
        }

        .styled-table th,
        .styled-table td {
            padding: 12px 15px;
        }

        .styled-table tbody tr {
            border-bottom: 1px solid #dddddd;
        }

            .styled-table tbody tr:nth-of-type(even) {
                background-color: #f3f3f3;
            }

            .styled-table tbody tr:last-of-type {
                border-bottom: 2px solid #000;
            }

            .styled-table tbody tr.active-row {
                font-weight: bold;
                color: #000;
            }

    h1 {
        text-align: center;
        font-weight: bold;
    }

    ul {
        display: flex;
        justify-items: center;
        width: 100%;
    }

    .cidades {
        font-weight: bold;
        width: 100%;
    }

    .time {
        justify-content: center;
        margin-block-start: 0px;
        padding: 10px;
    }

    li {
        display: grid;
        place-content: center;
        white-space: nowrap;
        margin: 0px;
    }

    h3 {
    }

    ol {
        justify-content: center
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Times.razor"
        List<Time> ListaTimes = new List<Time>();
    Dictionary<string, List<Time>> DicionarioEstados = new Dictionary<string, List<Time>>();



    protected override void OnInitialized()
    {
        Time ta = new Time();
        ta.Nome = "Inter";
        ta.Estado = "RS";
        ta.Pontos = 10;
        ta.SaldoDeGols = 2;
        ListaTimes.Add(ta);

        Time cor = new Time();
        cor.Nome = "Corinthias";
        cor.Estado = "SP";
        cor.Pontos = 25;
        cor.SaldoDeGols = 10;
        ListaTimes.Add(cor);

        Time sp = new Time();
        sp.Nome = "São Paulo";
        sp.Estado = "SP";
        sp.Pontos = 6;
        sp.SaldoDeGols = 2;
        ListaTimes.Add(sp);

        Time fla = new Time();
        fla.Nome = "Flamengo";
        fla.Estado = "RJ";
        fla.Pontos = 10;
        fla.SaldoDeGols = 4;
        ListaTimes.Add(fla);

        Time pal = new Time();
        pal.Nome = "Palmeiras";
        pal.Estado = "SP";
        pal.Pontos = 9;
        pal.SaldoDeGols = 5;
        ListaTimes.Add(pal);

        foreach (var Time in ListaTimes)
        {
            var estados = Time.Estado;
            if (!DicionarioEstados.ContainsKey(estados))
            {
                List<Time> listaDoEstado = new List<Time>();
                listaDoEstado = ListaTimes.Where(o => o.Estado == estados).ToList();
                DicionarioEstados.Add(estados, listaDoEstado);
            }
        }



    } 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
