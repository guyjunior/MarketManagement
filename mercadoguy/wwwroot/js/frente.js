var enderecoProduto = "https://mercadoguy.azurewebsites.net/Produtos/Produto/";
var produto;
var enderecoGerarVenda = "https://mercadoguy.azurewebsites.net/Produtos/gerarvenda"
var compra = [];
var __totalVenda__ = 0.0;


$("#posvenda").hide();

atualizarTotal();

function atualizarTotal() {

    $("#totalVenda").html(__totalVenda__);

}

function preencherFormulario(dadosProduto) {
    $("#campoNome").val(dadosProduto.nome);
    $("#campoCategoria").val(dadosProduto.categoria.nome);
    $("#campoFornecedor").val(dadosProduto.fornecedor.nome);
    $("#campoPreco").val(dadosProduto.precoDeVenda);

}

function zerarFormulario() {
    $("#campoNome").val("");
    $("#campoCategoria").val("");
    $("#campoFornecedor").val("");
    $("#campoPreco").val("");
    $("#campoQuantidade").val("");

}


function adicionarNaTabela(p, q) {
    /*JSON = {} "CHAVES" "DENTRO DAS CHAVES, SE PASSA O JSON"*/
    /* Pra fazer um clone, é necessário passar o JSON e assim consutltar um Objeto*/
    var produtoTemp = {};

    Object.assign(produtoTemp, produto);

    var venda = { produto: produtoTemp, quantidade: q, subtotal: produtoTemp.precoDeVenda * q };


    __totalVenda__ += venda.subtotal;
    atualizarTotal();
    compra.push(venda);

    /*append = Adicionar algo a uma tabela */
    $("#compras").append(`<tr>
        <td>${p.id}</td>
        <td>${p.nome}</td>
        <td>${q}</td>
        <td>R$ ${p.precoDeVenda}</td>
        <td>${p.medicao}</td>
        <td>R$ ${p.precoDeVenda * q}</td>
        <td><button class='btn btn-danger'>Remover</button></td>

    
    </tr>`);

}


/*.on = quando*/
/*quando o formulario for confirmado, disparar evento da função*/
$("#produtoForm").on("submit", function(event) {
    /*Impedir que o formulario atualize a página, carregue apenas o LIST*/
    event.preventDefault();
    var produtoParaTabela = produto;

    var qtd = $("#campoQuantidade").val();

    console.log(produtoParaTabela);
    console.log(qtd);
    adicionarNaTabela(produtoParaTabela, qtd);
    zerarFormulario();
})

$("#pesquisar").click(function() {
    var codProduto = $("#codProduto").val();
    var enderecoTemporario = enderecoProduto + codProduto;
    $.post(enderecoTemporario, function(dados, status) {
        produto = dados;

        var med = "";

        switch (produto.medicao) {
            case 0:
                med = "L";
                break;
            case 1:
                med = "Kg";
                break;
            case 2:
                med = "Un";
                break;
            default:
                med = "Un";
                break;
        }

        produto.medicao = med;

        preencherFormulario(produto);


    }).fail(function() {
        alert("Produto Inválido!");
    });
});

$("#finalizarVendaBTN").click(function() {

    if (__totalVenda__ <= 0) {
        alert("Compra Inválida, nenhum produto ADD!")
        return;
    }

    var _valorPago = $("#valorPago").val();
    //console.log(typeof _valorPago);
    if (!isNaN(_valorPago)) {
        //not a number / não é um numero
        _valorPago = parseFloat(_valorPago);
        if (_valorPago >= __totalVenda__) {

            $("#posvenda").show();
            $("#prevenda").hide();
            $("#valorPago").prop("disabled", true);
            var _troco = _valorPago - __totalVenda__;
            $("#troco").val(_troco);



            //Processar array de compras
            compra.forEach(elemento => {
                elemento.produto = elemento.produto.id;
            });

            //Preparar um novo objeto
            var _venda = { total: __totalVenda__, troco: _troco, produtos: compra }

            //Enviar dados par ao back-end
            $.ajax({

                type: "POST",
                url: enderecoGerarVenda,
                dataType: "json",
                contentType: "application/json",
                data: JSON.stringify(_venda),
                success: function(data) {
                    console.log("Enviado com sucesso!");
                    console.log(data);
                }

            });


        } else {
            alert("Valor pago, é muito baixo!");
            return;
        }

    } else {
        alert("Valor pago, inválido!");
        return;
    }

})

function restaurarModal() {
    $("#posvenda").hide();
    $("#prevenda").show();
    $("#valorPago").prop("disabled", false);
    $("#troco").val("");
    $("#valorPago").val("");
}

$("#fecharModal").click(function() {
    restaurarModal();

})