#pragma checksum "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Produto\EditarProduto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1f2f5ee6270b963183494d143ae9fda0b4840aa"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWasm.FrontEnd.Pages.Produto
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/produto/editar/{ProdutoId:int}")]
    public partial class EditarProduto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Cadastrar Produto</h3>");
#nullable restore
#line 8 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Produto\EditarProduto.razor"
 if(_categorias is not null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorWasm.FrontEnd.Pages.Produto.FormProduto>(1);
            __builder.AddAttribute(2, "Produto", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorWasm.Compartilhado.Entidades.Produto>(
#nullable restore
#line 10 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Produto\EditarProduto.razor"
                          produto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 10 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Produto\EditarProduto.razor"
                                                  Edit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "Categorias", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorWasm.Compartilhado.Entidades.Categoria>>(
#nullable restore
#line 10 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Produto\EditarProduto.razor"
                                                                    _categorias

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 11 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Produto\EditarProduto.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\danil\OneDrive\Área de Trabalho\Nova pasta\Grupo-04\BlazorWasm.FrontEnd\Pages\Produto\EditarProduto.razor"
       
	[Parameter] public int ProdutoId { get; set; }
	private Produto produto = new Produto();
	private List<Categoria> _categorias;

	protected override async Task OnInitializedAsync()
	{
		try
		{
			var resp = await repository.Get(ProdutoId);
			produto = resp;
			_categorias = await repositoryCategoria.Get();
		}
		catch (Exception ex)
		{
			Console.WriteLine("Erro Ao Editar Produto: " + ex.Message);

		}
	}

	private async Task Edit()
	{
		await repository.Update(produto);
		navigationManager.NavigateTo("produto");
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository<Categoria> repositoryCategoria { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository<Produto> repository { get; set; }
    }
}
#pragma warning restore 1591
