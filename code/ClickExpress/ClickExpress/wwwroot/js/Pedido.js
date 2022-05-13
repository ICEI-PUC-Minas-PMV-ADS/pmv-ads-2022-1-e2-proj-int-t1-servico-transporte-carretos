function SolicitarServico() {

    var tipoServico = $("#Tipo").val();

    var cepOrigem = $("#cep_origem").val();

    var logradouroOrigem = $("#logradouro_origem").val();

    var complementoOrigem = $("#complemento_origem").val();

    var cidadeOrigem = $("#localidade_origem").val();

    var bairroOrigem = $("#bairro_origem").val();

    var ufOrigem = $("#uf_origem").val();

    var cepDestino = $("#cep_destino").val();

    var logradouroDestino = $("#logradouro_destino").val();

    var complementoDestino = $("#complemento_destino").val();

    var cidadeDestino = $("#localidade_destino").val();

    var bairroDestino = $("#bairro_destino").val();

    var ufDestino = $("#uf_destino").val();

    var dataAgendamento = $("#data_agendamento").val();

    var servicoDescarrega = $("#serv_descarrega").val();

    var servicoMontagem = $("#serv_montagem").val();

    var token = $('input[name="__RequestVerificationToken"]').val();

    var tokenadr = $('form[action="/Pedidos/Create"] input[name="__RequestVerificationToken"]').val();

    var headers = {};

    var headersadr = {};

    headers['__RequestVerificationToken'] = token;
    headersadr['__RequestVerificationToken'] = tokenadr;

    //gravar


    var url = "/Pedidos/Create";

    $.ajax({
        url: url
        , type: "POST"
        , datatype: "json"
        , headers: headersadr
        , data: {
            Tipo: tipoServico,
            Cep_origem: cepOrigem,
            Logradouro_origem: logradouroOrigem,
            Complemento_origem: complementoOrigem,
            Cidade_origem: cidadeOrigem,
            Bairro_origem: bairroOrigem,
            UF_origem: ufOrigem,
            Cep_destino: cepDestino,
            Logradouro_destino: logradouroDestino,
            Complemento_destino: complementoDestino,
            Cidade_destino: cidadeDestino,
            Bairro_destino: bairroDestino,
            UF_destino: ufDestino,
            Dt_agendamento: dataAgendamento,
            Serv_descarrega: servicoDescarrega,
            Serv_montagem: servicoMontagem,
            __RequestVerificationToken: token
        }
        , success: function (data) {
            console.log(data);
             if (data.resultado > 0) {

                 ListarItens(data.resultado);
             }
        }
    });

}

function ListarItens(idPedido) {
    var url = "/Itens/ListarItens";

    $.ajax({
        url: url
        , type: "GET"
        , data: { id: idPedido }
        , datatype: "html"
        , success: function (data) {
            var divItens = $("#divItens");
            divItens.empty();
            divItens.show();
            divItens.html(data);

        }
    
    });
    
}
function SalvarItens() {
    var quantidade = $("#Quantidade").val();
    var descricao = $("#Descricao").val();
    var idPedido = $("#Id_contrato").val();

    var url = "/Itens/SalvarItens";

    $.ajax({
        url: url
        , data: { Quantidade: quantidade, Descricao: descricao, Id_contrato: idPedido}
        , type: "GET"
        , datatype: "html"
        , success: function (data) {
            if (data.Resultado > 0) {
                ListarItens(idPedido);
            }
            
        }

    });
}

function soma(a,b) {
    return a + b;
}
console.log(soma(9, 10))