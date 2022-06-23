
# Projeto de Interface

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Um projeto de interface envolve o desenvolvimento de protótipos de interfaces. Alguns elementos, tais como usabilidade, consistência, navegabilidade, interatividade, clareza, flexibilidade, funcionalidade e legibilidade, devem ser considerados no processo de produção dessas interfaces.	 

**Diagrama de Fluxo:**  

Conforme pode ser visto, a figura  mostra o diagrama de fluxo de interação do usuário pelas telas do sistema. Cada uma das telas deste fluxo é detalhada na seção de Wireframes que será desenvolvido. 

|FLUXO DO USUÁRIO| DESCRIÇÃO  |REFERÊNCIA                |
|--------------------|--------------------------------------------|----------------------------------------|
|HomePage           | A página inicial da aplicação será responsável por apresentar as funcionalidades principais        |  |
|Cadastro Cliente e Prestador de Serviços | Permitir ao usuário realizar o cadastro na aplicação como: cadastro de usuário cliente ou cadastro de prestador de serviço (PF/Autônomo)   | RF02 e RF03           |
| Login                   | Permitir ao usuário efetuar o login incluindo o email e senha.     |  RF01                                      |
|Solicitação de pedidos do cliente             | Permitir realizar a solicitação, usuário informa o endereço de origem e destino; data e hora que deseja o serviço; informa o tipo: se é carreto ou mudança; informa a listagem e quantidade de itens; escolhe o tipo de veículo de transporte; insere algumas informações tais como: local é de difícil acesso, casa ou apartamento, precisa de ajudante, possui elevador, qual andar, tem escada; informa se quer adicionar o serviço de montagem e desmontagem. Mostra o prestador de serviço que atendem ao filtro já informando seu valor de frete. Apresenta as informações do prestador escolhido, o resumo do pedido; caso houver deixar uma mensagem ou observação para o prestador; se necessário é possível modificar o pedido e  finalizar a contratação do pedido. | RF04, RF05, RF06, RF07, RF08, RF012 |
| Histórico do cliente | Permitir ao usuário cliente visualizar os pedidos em andamento e visualizar os pedidos finalizados. Permitir cancelar um pedido.      | RF09, RF011 e R0F15 |
| Minha área                     | Permitir ao usuário alterar dados cadastrais e alteração da senha.      |  RF013                                      |
| Histórico do Prestador de Serviços                    | Permitir ao usuário cliente visualizar os pedidos em andamento, pedidos finalizados e em aprovação. Permitir cancelar e aceitar um pedido.     |  RF09, RF010, RF011 e RF014                                       |


![diagrama atualizado drawio](https://user-images.githubusercontent.com/91202959/175404793-d80b3977-f4aa-42d5-9241-1cba7fa0655b.png)


## Wireframes

##### Estrutura base de todas as páginas do projeto.
![Estrutura Básica](img/wire_estrutura.png)

Abaixo mostraremos os principais fluxos dos usuários do projeto.

##### Página Inicial -> Cadastro Cliente
![Página Inicial](img/wire_index.png)
![Botão Cadastro](img/wire_cadastro.png)
![Cadastro Cliente](img/wire_cadcliente.png)
![Cadastro Realizado com sucesso](img/wire_cadsucesso.png)

##### Página Inicial -> Cadastro Prestador de Serviço
![Página Inicial](img/wire_index.png)
![Botão Cadastro](img/wire_cadastro.png)
![Cadastro Prestador Tela 1](img/wire_cadprestador1.png)
![Cadastro Prestador Tela 2](img/wire_cadprestador2.png)
![Cadastro Realizado com sucesso](img/wire_cadsucesso.png)

##### Página Inicial -> Login
![Página Inicial](img/wire_index.png)
![Botão Login](img/wire_login.png)

##### Cliente Logado -> Solicitar Serviço
![Tela Cliente Logado](img/wire_cliente.png)
![Tela Solicitar Serviço 1](img/wire_solicitar1.png)
![Tela Solicitar Serviço 2](img/wire_solicitar2.png)
![Tela Solicitar Serviço 3](img/wire_solicitar3.png)

##### Cliente Logado -> Histórico
![Tela Cliente Logado](img/wire_cliente.png)
![Tela Hisótico 1](img/wire_historico1.png)
![Tela Histórico 2](img/wire_historico2.png)

##### Cliente Logado -> Minha Área
![Tela Cliente Logado](img/wire_cliente.png)
![Tela Minha área Cliente](img/wire_minha_cliente.png)

##### Prestador de Serviço -> Solicitações
![Tela Prestador de Serviço Logado](img/wire_prestador.png)
![Tela Solicitações 1](img/wire_solicitado1.png)
![Tela Solicitações 2](img/wire_solicitado2.png)
![Tela Solicitações 3](img/wire_solicitado3.png)

##### Prestador de Serviço -> Minha Área
![Tela Prestador de Serviço Logado](img/wire_prestador.png)
![Tela Minha área Prestador de Serviço](img/wire_minha_prestador.png)
