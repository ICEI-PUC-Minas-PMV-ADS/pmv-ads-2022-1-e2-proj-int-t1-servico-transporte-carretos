// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.body.addEventListener('change', function (e) {
    let target = e.target;
    switch (target.value) {
        case "Cliente":
            //document.getElementById("teste").disabled = true;
            document.getElementById("formVeiculo").style.display = "none";
            document.getElementById("inputVeiculo").value = "N/A";
            break;
        case "Prestador":
            //document.getElementById("teste").disabled = false;
            document.getElementById("formVeiculo").style.display = "block";
            document.getElementById("inputVeiculo").value = "";
            break;
    }
});

const elementoCep = document.querySelector("#cep");
const elementoRua = document.querySelector("#logradouro");
const elementoCidade = document.querySelector("#localidade");
const elementoBairro = document.querySelector("#bairro");
const elementoUF = document.querySelector("#uf");

const elementoCepOrigem = document.querySelector("#cep_origem");
const elementoRuaOrigem = document.querySelector("#logradouro_origem");
const elementoCidadeOrigem = document.querySelector("#localidade_origem");
const elementoBairroOrigem = document.querySelector("#bairro_origem");
const elementoUFOrigem = document.querySelector("#uf_origem");

const elementoCepDestino = document.querySelector("#cep_destino");
const elementoRuaDestino = document.querySelector("#logradouro_destino");
const elementoCidadeDestino = document.querySelector("#localidade_destino");
const elementoBairroDestino = document.querySelector("#bairro_destino");
const elementoUFDestino = document.querySelector("#uf_destino");

async function buscarCep(cep) {
    const response = await fetch(`https://viacep.com.br/ws/${cep}/json/`);
    return response.json();
}

async function preencherEnderecoCadastro() {
    const cep = elementoCep.value;
    const objetoEndereco = await buscarCep(cep);

    elementoRua.value = objetoEndereco.logradouro;
    elementoCidade.value = objetoEndereco.localidade;
    elementoBairro.value = objetoEndereco.bairro;
    elementoUF.value = objetoEndereco.uf;
}

async function preencherEnderecoOrigem() {
    const cep = elementoCepOrigem.value;
    const objetoEndereco = await buscarCep(cep);

    elementoRuaOrigem.value = objetoEndereco.logradouro;
    elementoCidadeOrigem.value = objetoEndereco.localidade;
    elementoBairroOrigem.value = objetoEndereco.bairro;
    elementoUFOrigem.value = objetoEndereco.uf;
}

async function preencherEnderecoDestino() {
    const cep = elementoCepDestino.value;
    const objetoEndereco = await buscarCep(cep);

    elementoRuaDestino.value = objetoEndereco.logradouro;
    elementoCidadeDestino.value = objetoEndereco.localidade;
    elementoBairroDestino.value = objetoEndereco.bairro;
    elementoUFDestino.value = objetoEndereco.uf;
}
if (elementoCep) {
    elementoCep.addEventListener("blur", preencherEnderecoCadastro);
}


if (elementoCepOrigem) {
    elementoCepOrigem.addEventListener("blur", preencherEnderecoOrigem);
}


if (elementoCepDestino) {
    elementoCepDestino.addEventListener("blur", preencherEnderecoDestino);
}







