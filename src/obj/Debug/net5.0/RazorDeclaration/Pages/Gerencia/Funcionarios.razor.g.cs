// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace lBrasa.Pages.Gerencia
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Treinee\lBrasa\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Treinee\lBrasa\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Treinee\lBrasa\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Treinee\lBrasa\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Treinee\lBrasa\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Treinee\lBrasa\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Treinee\lBrasa\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Treinee\lBrasa\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Treinee\lBrasa\_Imports.razor"
using lBrasa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Treinee\lBrasa\_Imports.razor"
using lBrasa.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Treinee\lBrasa\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
using LaBrasa.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
using LaBrasa.Shared.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/funcionarios")]
    public partial class Funcionarios : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 129 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
       
    string tituloForm;
    bool visibilidadePainel = true;
    bool visibilidadeForm = false;

    Funcionario funcionario = new Funcionario();

    List<Funcionario> ListFuncionarios = new List<Funcionario>();

    protected override async Task OnInitializedAsync()
    {
        await PegarTodos();
    }


    public async Task AdicionarFuncionario(Funcionario _funcionario)
    {
        funcionario = _funcionario;

        if (funcionario.Id > 0)
        {
            await _repo.AtualizarFuncionario(funcionario);
            await PegarTodos();

            return;
        }

        await _repo.IncluirFuncionario(_funcionario);

        await PegarTodos();
    }

    private void alterarVisibilidade()
    {
        visibilidadePainel = !visibilidadePainel;
        visibilidadeForm = !visibilidadeForm;
        tituloForm = "Novo Funcionario";
    }

    private async Task EditarFuncionario(int id)
    {
        Funcionario _funcionario = await _repo.PegarPeloId(id);

        funcionario = _funcionario;

        await _repo.AtualizarFuncionario(funcionario);

        visibilidadePainel = !visibilidadePainel;
        visibilidadeForm = !visibilidadeForm;
        tituloForm = "Editar Funcionario";
    }


    private async Task PegarTodos()
    {
        ListFuncionarios = await _repo.PegarTodos();
    }

    private async Task ApagarFuncionario(int id)
    {
        await _repo.ApagarFuncionario(id);
        await PegarTodos();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFuncionarioRepo _repo { get; set; }
    }
}
#pragma warning restore 1591
