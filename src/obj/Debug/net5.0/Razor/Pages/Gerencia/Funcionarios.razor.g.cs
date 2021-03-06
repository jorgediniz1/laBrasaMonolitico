#pragma checksum "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5cc2b55f21bc57185ea781ac1dd331d540205ec"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Funcionarios</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, @"<style>
    .btn {
        border-radius: 0;
    }

    .btn-danger {
    }

    .btn-primary, .btn-success {
    }

    .float {
        position: absolute;
        right: 0;
        margin-right: 10px;
        top: 0;
        margin-top: 5px;
    }

    .float-2 {
        position: absolute;
        right: 0;
        margin-right: 80px;
        top: 0;
        margin-top: 5px;
    }
</style>");
#nullable restore
#line 38 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
 if (visibilidadePainel)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "input-group");
            __builder.AddMarkupContent(4, "<input class=\"form-control\" placeholder=\"Pesquisar...\">\r\n        ");
            __builder.AddMarkupContent(5, "<button class=\"btn btn-danger\" style=\"border-radius: 0!important\"><i class=\"oi oi-magnifying-glass\"></i></button>\r\n        ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-success");
            __builder.AddAttribute(8, "style", "margin-left: 25px;");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
                                                                             alterarVisibilidade

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "<i class=\"oi oi-plus\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(11, "ul");
            __builder.AddAttribute(12, "class", "list-group mt-3");
#nullable restore
#line 49 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
         foreach (var funcionario in ListFuncionarios)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "li");
            __builder.AddAttribute(14, "class", "list-group-item mt-4");
            __builder.AddContent(15, 
#nullable restore
#line 52 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
                 funcionario.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "float-2");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "class", "btn btn-danger");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
                                                             () => ApagarFuncionario(funcionario.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "<i>X</i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "float");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn btn-primary");
            __builder.OpenElement(28, "i");
            __builder.AddAttribute(29, "class", "oi oi-pencil");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
                                                                                      () => EditarFuncionario(funcionario.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 63 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
 if (visibilidadeForm)
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "div");
            __builder.AddContent(32, 
#nullable restore
#line 69 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
         tituloForm

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.OpenElement(34, "form");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "row");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form-group col-8");
            __builder.AddMarkupContent(39, "<label for=\"exampleInputEmail1\">Nome</label>\r\n                ");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "type", "text");
            __builder.AddAttribute(42, "class", "form-control");
            __builder.AddAttribute(43, "id", "exampleInputEmail1");
            __builder.AddAttribute(44, "aria-describedby", "emailHelp");
            __builder.AddAttribute(45, "placeholder", "Nome");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
                                                                                                                                       funcionario.Nome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => funcionario.Nome = __value, funcionario.Nome));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "row");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "form-group col-8");
            __builder.AddMarkupContent(53, "<label for=\"exampleInputEmail1\">Departamento</label>\r\n                ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "type", "text");
            __builder.AddAttribute(56, "class", "form-control");
            __builder.AddAttribute(57, "id", "exampleInputEmail1");
            __builder.AddAttribute(58, "aria-describedby", "emailHelp");
            __builder.AddAttribute(59, "placeholder", "Departamento");
            __builder.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 82 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
                                                                                                                                               funcionario.Departamento

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => funcionario.Departamento = __value, funcionario.Departamento));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n\r\n        ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "row");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "form-group col-8");
            __builder.AddMarkupContent(67, "<label for=\"exampleInputEmail1\">Sexo</label>\r\n                ");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "type", "text");
            __builder.AddAttribute(70, "class", "form-control");
            __builder.AddAttribute(71, "id", "exampleInputEmail1");
            __builder.AddAttribute(72, "aria-describedby", "emailHelp");
            __builder.AddAttribute(73, "placeholder", "Sexo");
            __builder.AddAttribute(74, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 89 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
                                                                                                                                       funcionario.Sexo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => funcionario.Sexo = __value, funcionario.Sexo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n        ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "row");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "form-group col-8");
            __builder.AddMarkupContent(81, "<label for=\"exampleInputEmail1\">Cpf</label>\r\n                ");
            __builder.OpenElement(82, "input");
            __builder.AddAttribute(83, "type", "text");
            __builder.AddAttribute(84, "class", "form-control");
            __builder.AddAttribute(85, "id", "exampleInputEmail1");
            __builder.AddAttribute(86, "aria-describedby", "emailHelp");
            __builder.AddAttribute(87, "placeholder", "CPF");
            __builder.AddAttribute(88, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 96 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
                                                                                                                                      funcionario.Cpf

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => funcionario.Cpf = __value, funcionario.Cpf));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n\r\n        ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "row");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "form-group col-4");
            __builder.AddMarkupContent(95, "<label for=\"exampleInputEmail1\">Telefone</label>\r\n                ");
            __builder.OpenElement(96, "input");
            __builder.AddAttribute(97, "type", "text");
            __builder.AddAttribute(98, "class", "form-control");
            __builder.AddAttribute(99, "id", "exampleInputEmail1");
            __builder.AddAttribute(100, "aria-describedby", "emailHelp");
            __builder.AddAttribute(101, "placeholder", "Telefone");
            __builder.AddAttribute(102, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 103 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
                                                                                                                                           funcionario.Telefone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(103, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => funcionario.Telefone = __value, funcionario.Telefone));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n\r\n            ");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "form-group col-4");
            __builder.AddMarkupContent(107, "<label for=\"exampleInputEmail1\">Endereco</label>\r\n                ");
            __builder.OpenElement(108, "input");
            __builder.AddAttribute(109, "type", "text");
            __builder.AddAttribute(110, "class", "form-control");
            __builder.AddAttribute(111, "id", "exampleInputEmail1");
            __builder.AddAttribute(112, "aria-describedby", "emailHelp");
            __builder.AddAttribute(113, "placeholder", "Endereco");
            __builder.AddAttribute(114, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 108 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
                                                                                                                                           funcionario.Endereco

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(115, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => funcionario.Endereco = __value, funcionario.Endereco));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n\r\n        ");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "row");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "form-group col-12");
            __builder.AddMarkupContent(121, "<label for=\"exampleInputEmail1\">Email</label>\r\n                ");
            __builder.OpenElement(122, "input");
            __builder.AddAttribute(123, "type", "text");
            __builder.AddAttribute(124, "class", "form-control");
            __builder.AddAttribute(125, "id", "exampleInputEmail1");
            __builder.AddAttribute(126, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 115 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
                                                                                       funcionario.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(127, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => funcionario.Email = __value, funcionario.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n\r\n        ");
            __builder.OpenElement(129, "div");
            __builder.AddAttribute(130, "class", "row");
            __builder.OpenElement(131, "button");
            __builder.AddAttribute(132, "type", "submit");
            __builder.AddAttribute(133, "class", "btn btn-danger col-6");
            __builder.AddAttribute(134, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 120 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
                                                                         () => AdicionarFuncionario(funcionario)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(135, "Incluir");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n            ");
            __builder.OpenElement(137, "button");
            __builder.AddAttribute(138, "class", "btn btn-light col-6");
            __builder.AddAttribute(139, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 121 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"
                                                          alterarVisibilidade

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(140, "Voltar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 124 "C:\Treinee\lBrasa\Pages\Gerencia\Funcionarios.razor"

}

#line default
#line hidden
#nullable disable
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
