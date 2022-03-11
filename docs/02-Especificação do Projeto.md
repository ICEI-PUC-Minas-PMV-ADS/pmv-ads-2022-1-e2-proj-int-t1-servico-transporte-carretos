# Especificações do Projeto

Por meio da vivência e dificuldades expostas pelos usuários foi definido pelo grupo o problema a ser solucionado e seus relevantes pontos a serem considerados. Os detalhes apresentados nesse processo foram consolidados no modo de personas e histórias de usuários. 

## Personas

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

Ao começar um projeto todos os requisitos devem ser levantados, entendidos e documentado. O escopo deste projeto é definido por meio de requisitos funcionais, que são as características que definem os critérios de aceitação do produto e a necessidade do cliente, e requisitos não funcionais que é voltado pelas características de qualidade que o sistema todo ou uma funcionalidade em específico deve ter. A seguir estes requisitos são apresentados. 

### Requisitos Funcionais

A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues. 


|ID    | Descrição do Requisito                                                                       | Prioridade |
|------|----------------------------------------------------------------------------------------------|------------|
|RF-01| O site deve permitir ao usuário fazer login | ALTA       | 
|RF-02| O site deve permitir cadastrar usuário cliente                        | ALTA      |
|RF-03| O site deve permitir cadastrar usuário prestador de serviços                                    |  ALTA      |
|RF-04| O site deve permitir o usuário cliente solicitar um serviço                                  | ALTA       |
|RF-05| O site deve permitir o usuário cliente selecionar se será um serviço de carreto ou de mudança                          |  ALTA      |
|RF-06| O site deve permitir o usuário cliente descrever a mercadoria a ser transportada.                                |  ALTA     |
|RF-07| O site deve permitir o usuário prestador fornecer orçamento do serviço.                                |  ALTA      |
|RF-08| O site deve permitir ao usuário cliente finalizar o pedido.                                           |  ALTA      |
|RF-09| O site deve permitir ao usuário cliente visualizar os pedidos em andamento.                                          | MÉDIA      |
|RF-010| O site deve permitir o usuário prestador visualizar solicitações de usuários cliente.                                               | MÉDIA      |
|RF-011| O site deve permitir ao usuário cliente visualizar o histórico de pedidos.                                           | BAIXA      |
|RF-012| O site deve mostrar ao usuário cliente um resumo do pedido.                                      | BAIXA      |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|---------|-------------------------|----|
|RNF-01   | O sistema deve ser compatível com os principais navegadores como (Google Chrome, Mozilla Firefox, Microsoft Edge, Internet Explorer   | ALTA | 
|RNF-02  | O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku)  |  ALTA | 
|RNF-03  | Os dados do sistema podem ser migrados para qualquer sistema de gerenciamento de banco de dados SQL   |  MEDIA |
|RNF-04  | O site deverá ser responsivo permitindo a visualização em um celular de forma adequada |  MEDIA |
|RNF-05  | As informações cadastrais do cliente devem estar disponíveis apenas para o próprio cliente  |  BAIXA |
|RNF-06  | O site deve aparecer no resultado de pesquisas relacionadas a mudança e carreto  |  BAIXA |




## Restrições

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 26/06/2022.|
|RE-02| O aplicativo deve se restringir às tecnologias #C no Backend e as básicas da Web no Frontend.       |
|RE-03| A equipe não pode subcontratar o desenvolvimento do trabalho.      |






## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
