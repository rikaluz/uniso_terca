#pragma checksum "C:\Users\danil\OneDrive\Documentos\uniso_terca\Grupo-04\BlazorWasm.FrontEnd\Pages\Cadastros\CadastrarPessoas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a49c53cb7c0b3e0bcfa9f47fc5bfc678ad8727be"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWasm.FrontEnd.Pages.Cadastros
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\danil\OneDrive\Documentos\uniso_terca\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danil\OneDrive\Documentos\uniso_terca\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\danil\OneDrive\Documentos\uniso_terca\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\danil\OneDrive\Documentos\uniso_terca\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\danil\OneDrive\Documentos\uniso_terca\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\danil\OneDrive\Documentos\uniso_terca\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\danil\OneDrive\Documentos\uniso_terca\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\danil\OneDrive\Documentos\uniso_terca\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\danil\OneDrive\Documentos\uniso_terca\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\danil\OneDrive\Documentos\uniso_terca\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.FrontEnd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\danil\OneDrive\Documentos\uniso_terca\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.FrontEnd.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\danil\OneDrive\Documentos\uniso_terca\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.FrontEnd.Repositorio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\danil\OneDrive\Documentos\uniso_terca\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasmServer.Client.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\danil\OneDrive\Documentos\uniso_terca\Grupo-04\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.Compartilhado.Entidades;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CPessoas/cadastro")]
    public partial class CadastrarPessoas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Cadastrar Pessoas</h3>\r\n\r\n\r\n");
            __builder.OpenComponent<BlazorWasm.FrontEnd.Pages.Cadastros.FormPessoas>(1);
            __builder.AddAttribute(2, "Pessoa", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorWasm.Compartilhado.Entidades.Pessoa>(
#nullable restore
#line 9 "C:\Users\danil\OneDrive\Documentos\uniso_terca\Grupo-04\BlazorWasm.FrontEnd\Pages\Cadastros\CadastrarPessoas.razor"
                     pessoa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "C:\Users\danil\OneDrive\Documentos\uniso_terca\Grupo-04\BlazorWasm.FrontEnd\Pages\Cadastros\CadastrarPessoas.razor"
                                            Create

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\danil\OneDrive\Documentos\uniso_terca\Grupo-04\BlazorWasm.FrontEnd\Pages\Cadastros\CadastrarPessoas.razor"
       
    private Pessoa pessoa = new Pessoa();

    private async Task Create()
    {
        try
        {
            await repository.Add(pessoa);
            navigationManager.NavigateTo("Cpessoas");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository<Pessoa> repository { get; set; }
    }
}
#pragma warning restore 1591
