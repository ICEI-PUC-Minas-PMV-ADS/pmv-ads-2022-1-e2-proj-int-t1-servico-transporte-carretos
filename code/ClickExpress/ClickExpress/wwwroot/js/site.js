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


const cep = document.querySelector("#cep")

const showData = (result) => {
    for (const campo in result) {
        if (document.querySelector("#" + campo)) {        
            document.querySelector("#"+campo).value = result[campo]
        }
    }
}

cep.addEventListener("blur", (e) => {
    let search = cep.value.replace("-", "")

    const options = {
        method: 'GET',
        mode: 'cors',
        cache: 'default'
    }

    fetch(`https://viacep.com.br/ws/${search}/json/`, options)
        .then(response => { response.json()
            .then(data => showData(data))
        })
    .catch(e=>console.log('Deu Erro: '+ e,message))
})


const cep2 = document.querySelector("#cep")

const showData2 = (result) => {
    for (const campo in result) {
        if (document.querySelector("#" + campo)) {
            document.querySelector("#" + campo).value = result[campo]
        }
    }
}

cep2.addEventListener("blur", (e) => {
    let search = cep2.value.replace("-", "")

    const options = {
        method: 'GET',
        mode: 'cors',
        cache: 'default'
    }

    fetch(`https://viacep.com.br/ws/${search}/json/`, options)
        .then(response => {
            response.json()
            .then(data => showData2(data))
        })
        .catch(e => console.log('Deu Erro: ' + e, message))
})