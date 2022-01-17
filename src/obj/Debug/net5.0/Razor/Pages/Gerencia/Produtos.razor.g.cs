#pragma checksum "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a954a73484cbbab9954735ecec7b9ed46b663316"
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
#line 1 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
using LaBrasa.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
using LaBrasa.Shared.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
using LaBrasa.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/produtos")]
    public partial class Produtos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Produtos</h3>\r\n");
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
</style>

");
            __builder.OpenElement(2, "div");
#nullable restore
#line 40 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
     if (visibilidadePainel)
    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "input-group");
            __builder.AddMarkupContent(5, "<input class=\"form-control\" placeholder=\"Pesquisar...\">\r\n            ");
            __builder.AddMarkupContent(6, "<button class=\"btn btn-danger\" style=\"border-radius: 0!important\"><i class=\"oi oi-magnifying-glass\"></i></button>\r\n            ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-success");
            __builder.AddAttribute(9, "style", "margin-left: 25px;");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
                                                                                 alterarVisibilidade

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(11, "<i class=\"oi oi-plus\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(12, "ul");
            __builder.AddAttribute(13, "class", "list-group mt-3");
#nullable restore
#line 52 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
             foreach (var produto in ListProdutos)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "li");
            __builder.AddAttribute(15, "class", "list-group-item mt-4");
            __builder.AddContent(16, 
#nullable restore
#line 55 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
                     produto.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "float-2");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-danger");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
                                                                 () => ApagarProduto(produto.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "<i>X</i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n                    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "float");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-primary");
            __builder.OpenElement(29, "i");
            __builder.AddAttribute(30, "class", "oi oi-pencil");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
                                                                                          () => EditarProdutoBtn(produto.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
     if (visibilidadeForm)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "div");
            __builder.AddContent(33, 
#nullable restore
#line 71 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
             tituloForm

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "form");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "row");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form-group col-8");
            __builder.AddMarkupContent(40, "<label for=\"exampleInputEmail1\">Nome</label>\r\n                    ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "email");
            __builder.AddAttribute(43, "class", "form-control");
            __builder.AddAttribute(44, "id", "exampleInputEmail1");
            __builder.AddAttribute(45, "aria-describedby", "emailHelp");
            __builder.AddAttribute(46, "placeholder", "Nome");
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 78 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
                                                                                                                                            produto.Nome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => produto.Nome = __value, produto.Nome));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n                ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form-group col-4");
            __builder.AddMarkupContent(52, "<label for=\"exampleInputEmail1\">Id</label>\r\n                    ");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "type", "email");
            __builder.AddAttribute(55, "class", "form-control");
            __builder.AddAttribute(56, "id", "exampleInputEmail1");
            __builder.AddAttribute(57, "aria-describedby", "emailHelp");
            __builder.AddAttribute(58, "placeholder", "Id");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
                                                                                                                                          produto.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => produto.Id = __value, produto.Id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\r\n            ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "row");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "form-group col-12");
            __builder.AddMarkupContent(66, "<label for=\"exampleFormControlSelect1\">Categoria</label>\r\n                    ");
            __builder.OpenElement(67, "select");
            __builder.AddAttribute(68, "class", "form-control");
            __builder.AddAttribute(69, "id", "exampleFormControlSelect1");
            __builder.AddAttribute(70, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 91 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
                                                                                       produto.Catergoria

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => produto.Catergoria = __value, produto.Catergoria));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(72, "option");
            __builder.AddContent(73, "Alimento");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                        ");
            __builder.OpenElement(75, "option");
            __builder.AddContent(76, "Bebida");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n\r\n            ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "row");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "form-group col-6");
            __builder.AddMarkupContent(82, "<label for=\"exampleInputEmail1\">Preço Custo</label>\r\n                    ");
            __builder.OpenElement(83, "input");
            __builder.AddAttribute(84, "type", "email");
            __builder.AddAttribute(85, "class", "form-control");
            __builder.AddAttribute(86, "id", "exampleInputEmail1");
            __builder.AddAttribute(87, "aria-describedby", "emailHelp");
            __builder.AddAttribute(88, "placeholder", "Nome");
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 102 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
                                                                                                                                            produto.PrecoCusto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => produto.PrecoCusto = __value, produto.PrecoCusto));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "form-group col-6");
            __builder.AddMarkupContent(94, "<label for=\"exampleInputEmail1\">Preço Venda</label>\r\n                    ");
            __builder.OpenElement(95, "input");
            __builder.AddAttribute(96, "type", "email");
            __builder.AddAttribute(97, "class", "form-control");
            __builder.AddAttribute(98, "id", "exampleInputEmail1");
            __builder.AddAttribute(99, "aria-describedby", "emailHelp");
            __builder.AddAttribute(100, "placeholder", "Id");
            __builder.AddAttribute(101, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 106 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
                                                                                                                                          produto.PrecoVenda

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => produto.PrecoVenda = __value, produto.PrecoVenda));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n\r\n            ");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "row");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "form-group col-4");
            __builder.AddMarkupContent(108, "<label for=\"exampleInputEmail1\">Qtd Minima</label>\r\n                    ");
            __builder.OpenElement(109, "input");
            __builder.AddAttribute(110, "type", "email");
            __builder.AddAttribute(111, "class", "form-control");
            __builder.AddAttribute(112, "id", "exampleInputEmail1");
            __builder.AddAttribute(113, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 113 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
                                                                                            produto.QuantidadeMinima

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(114, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => produto.QuantidadeMinima = __value, produto.QuantidadeMinima));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                ");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "form-group col-4");
            __builder.AddMarkupContent(118, "<label for=\"exampleInputEmail1\">Estoque</label>\r\n                    ");
            __builder.OpenElement(119, "input");
            __builder.AddAttribute(120, "type", "email");
            __builder.AddAttribute(121, "class", "form-control");
            __builder.AddAttribute(122, "id", "exampleInputEmail1");
            __builder.AddAttribute(123, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 117 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
                                                                                            produto.QuantidadeEstoque

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(124, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => produto.QuantidadeEstoque = __value, produto.QuantidadeEstoque));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "form-group col-4");
            __builder.AddMarkupContent(128, "<label for=\"exampleInputEmail1\">A adicionar</label>\r\n                    ");
            __builder.OpenElement(129, "input");
            __builder.AddAttribute(130, "type", "email");
            __builder.AddAttribute(131, "class", "form-control");
            __builder.AddAttribute(132, "id", "exampleInputEmail1");
            __builder.AddAttribute(133, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 121 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
                                                                                            produto.QuantidadeAdicionar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(134, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => produto.QuantidadeAdicionar = __value, produto.QuantidadeAdicionar));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n\r\n            ");
            __builder.OpenElement(136, "div");
            __builder.AddAttribute(137, "class", "row");
            __builder.OpenElement(138, "button");
            __builder.AddAttribute(139, "type", "submit");
            __builder.AddAttribute(140, "class", "btn btn-danger col-6");
            __builder.AddAttribute(141, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 126 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
                                                                             () => AdicionarProduto(produto)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(142, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n                ");
            __builder.OpenElement(144, "button");
            __builder.AddAttribute(145, "class", "btn btn-light col-6");
            __builder.AddAttribute(146, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 127 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
                                                              alterarVisibilidade

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(147, "Voltar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 130 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 135 "C:\Treinee\lBrasa\Pages\Gerencia\Produtos.razor"
       

    string tituloForm;
    bool visibilidadePainel = true;
    bool visibilidadeForm = false;

    Produto produto = new Produto();
    List<Produto> ListProdutos = new List<Produto>();

    protected override async Task OnInitializedAsync()
    {
        await PegarTodos();
    }

    public async Task AdicionarProduto(Produto _produto)
    {
        produto = _produto;

        if (produto.Id > 0)
        {
            await _repo.AtualizarProduto(produto);
            await PegarTodos();

            return;
        }

        await _repo.IncluirProduto(_produto);

        await PegarTodos();
    }


    private void alterarVisibilidade()
    {
        visibilidadePainel = !visibilidadePainel;
        visibilidadeForm = !visibilidadeForm;
        tituloForm = "Novo Produto";
    }

    private async Task EditarProdutoBtn(int id)
    {
        Produto _produto = await _repo.PegarPeloId(id);

        produto = _produto;

        await _repo.AtualizarProduto(produto);


        visibilidadePainel = !visibilidadePainel;
        visibilidadeForm = !visibilidadeForm;
        tituloForm = "Editar Produto";
    }

    public async Task ApagarProduto(int id)
    {
        await _repo.ApagarProduto(id);
        await PegarTodos();
    }

    private async Task PegarTodos()
    {
        ListProdutos = await _repo.PegarTodos();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProdutoRepo _repo { get; set; }
    }
}
#pragma warning restore 1591