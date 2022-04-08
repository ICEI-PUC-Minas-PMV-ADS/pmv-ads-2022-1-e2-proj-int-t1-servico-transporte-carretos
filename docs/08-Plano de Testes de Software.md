# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

|Caso de Teste |CT-01 – Cadastro do usuário |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-001 - O site deve permitir ao usuário fazer login. RF-002 - O site deve permitir cadastrar usuário cliente. RF-003 - O site deve permitir cadastrar usuário prestador de serviços. |
|**Entrada** | Cadastro: Após preencher o email, senha e informações pessoais (telefone, endereço, etc). Login: Após preencher o email e senha. |
|**Objetivo do Teste** | Permitir que o usuário acesse a plataforma através do login e cadastro. Permitir o cadastro do usuário que quer solitar carreto/mudança e o que deseja transportar o material/mercadoria.  |
|**Passos** | 1) Acessar o Navegador  2) Informar o endereço do Site  3) Clicar no botão Cadastre-se  4) Preencher os campos com informações validas 5) Clicar no botão Cadastrar. |
|**Critérios de Êxito** | "Cadastro concluido :) seja muito bem vindo". |

|Caso de Teste |CT-02 – Login do usuário |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-001 - O site deve permitir ao usuário fazer login. |
|**Entrada** | Login: Após preencher o email e senha. |
|**Objetivo do Teste** | Permitir que o usuário acesse a plataforma através do login. |
|**Passos** | 1) Acessar o Navegador  2) Informar o endereço do Site  3) Clicar no botão no canto superior de login  4) Preencher os campos com informações validas 5) Clicar no botão Logar. |
|**Critérios de Êxito** | O usuário será direcionado a homepage e terá acesso ao seu menu. |

|Caso de Teste |CT-03 – Alterar dados cadastrais (por exemplo senha)  |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** |RF-02 - O site deve permitir ao usuário alterar dados cadastrais. |
|**Entrada** | Após clicar no botão esqueci senha, o usuário deverá informar o email cadastrado. |
|**Objetivo do Teste** | Verificar se os campos do formulário estão sendo exibidos corretamente.  |
|**Passos** |1) Acessar o Navegador  2) Informar o endereço do Site  3) Visualizar a página de login  4)Esqueci senha 5) Informar o email, onde será enviado um link para a nova senha 11) Insira uma nova senha no campo [senha] e no campo [confirme sua senha] redigite a senha e clique no botão próximo que levará para a próxima tela |
|**Critérios de Êxito** | "Senha alterada com sucesso." |

|Caso de Teste |CT-04 – Usuário Cliente fazer um pedido (solicitar um serviço de carreto ou mudança)  |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-004 - O site deve permitir o usuário cliente solicitar um serviço. RF-005 - O site deve permitir o usuário cliente selecionar se será um serviço de carreto ou de mudança. RF-006 - O site deve permitir o usuário cliente descrever a mercadoria a ser transportada. RF-008 - O site deve permitir ao usuário cliente finalizar o pedido.  |
|**Entrada** | Após efetuar o login, o usuário acessa o menu de criação de pedidos. |
|**Objetivo do Teste** | Verificar se o usuário cliente consegue criar um pedido preenchendo todos os campos obrigatórios, alternando o tipo (carreto ou mudança)  |
|**Passos** | 1) Acessar o Navegador  2) Informar o endereço do Site  3) Clicar no botão no canto superior de login  4) Preencher os campos com informações validas 5) Clicar no botão Logar. 6) Acessar o menu de criação de pedidos. 7) Preencher formulário com dados do pedido. 8) Criar pedido após clicar no botão Finalizar.|
|**Critérios de Êxito** | "Pedido criado com sucesso." |
