#pragma checksum "C:\Users\PC\Desktop\mercadoguy\Views\Gestao\Estoque.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5250d68b0a79832ce988646062952f28996e076e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gestao_Estoque), @"mvc.1.0.view", @"/Views/Gestao/Estoque.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gestao/Estoque.cshtml", typeof(AspNetCore.Views_Gestao_Estoque))]
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
#line 1 "C:\Users\PC\Desktop\mercadoguy\Views\_ViewImports.cshtml"
using sonmarket;

#line default
#line hidden
#line 2 "C:\Users\PC\Desktop\mercadoguy\Views\_ViewImports.cshtml"
using sonmarket.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5250d68b0a79832ce988646062952f28996e076e", @"/Views/Gestao/Estoque.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9668c8b60a8f669335ff45d2f33d4d9e11d2157", @"/Views/_ViewImports.cshtml")]
    public class Views_Gestao_Estoque : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<sonmarket.Models.Estoque>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovoEstoque", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gestao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\PC\Desktop\mercadoguy\Views\Gestao\Estoque.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
            BeginContext(83, 33, true);
            WriteLiteral("<h2>E S T O Q U E</h2>\r\n<hr/>\r\n\r\n");
            EndContext();
            BeginContext(116, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5250d68b0a79832ce988646062952f28996e076e4291", async() => {
                BeginContext(193, 13, true);
                WriteLiteral("BOTAO ESTOQUE");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(210, 959, true);
            WriteLiteral(@"
<hr/>
<script>
    $(document).ready( function () {
    $('#estoques').DataTable({
                ""language"": {
                ""lengthMenu"": ""Mostrando _MENU_ registros por página"",
                ""zeroRecords"": ""Desculpa, Nada encontrado."",
                ""info"": ""Mostando página _PAGE_ de _PAGES_"",
                ""infoEmpty"": ""Nenhum registro disponível"",
                ""search"":         ""Buscar:"",
                ""paginate"": {
                    ""first"":      ""Primeiro"",
                    ""last"":       ""Último"",
                    ""next"":       ""Próximo"",
                    ""previous"":   ""Anterior""
                }
            }
        });
    });
</script>

<table id=""estoques"" class=""table table-striped table-bordered"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Produto</th>
            <th>Quantidade</th>
            <th>Ações</th>

        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 41 "C:\Users\PC\Desktop\mercadoguy\Views\Gestao\Estoque.cshtml"
         foreach(var estoque in Model){

#line default
#line hidden
            BeginContext(1210, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1249, 10, false);
#line 43 "C:\Users\PC\Desktop\mercadoguy\Views\Gestao\Estoque.cshtml"
               Write(estoque.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1259, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1287, 20, false);
#line 44 "C:\Users\PC\Desktop\mercadoguy\Views\Gestao\Estoque.cshtml"
               Write(estoque.Produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1307, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1335, 18, false);
#line 45 "C:\Users\PC\Desktop\mercadoguy\Views\Gestao\Estoque.cshtml"
               Write(estoque.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(1353, 308, true);
            WriteLiteral(@"</td>
               
                               
                    <td>
                                                
                            <button class=""btn btn-danger""><i class=""fas fa-trash fill""></i></button>
                        
                    </td>
            </tr>
");
            EndContext();
#line 54 "C:\Users\PC\Desktop\mercadoguy\Views\Gestao\Estoque.cshtml"
            
        }

#line default
#line hidden
            BeginContext(1686, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<sonmarket.Models.Estoque>> Html { get; private set; }
    }
}
#pragma warning restore 1591
