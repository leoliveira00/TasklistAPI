# TasklistAPI

* Instale o Postman
* Inicie o aplicativo Web.
* Inicie o Postman.
* Desabilite a Verificação do certificado SSL no Postman
  ** Arquivo > Configurações (guia Geral), desabilite Verificação de certificado SSL
  
Testar requisição GET:

* Defina o método HTTP como GET.
* Defina a URL de solicitação como https://localhost:1234/api/task
* Selecione Enviar.
  
Testar requisição POST:

* Defina o método HTTP como POST.
* Selecione a guia Body.
* Selecione o botão de opção raw.
* Defina o tipo como JSON (aplicativo/json) .
* No corpo da solicitação, insira JSON para inserir o registro:

{
    "taskTitulo": "Título",
    "taskDescricao": "Descrição teste",
    "taskDataCriacao": "2019-09-14T00:00:00",
    "taskFlgConcluido": false
}

Testar requisição GET{id}

* Defina o método HTTP como GET.
* Envie na url o id desejado. Por exemplo: https://localhost:1234/api/task/1

Testar requisição PUT:

* Defina o método HTTP como PUT.
* Selecione a guia Body.
* Selecione o botão de opção raw.
* Defina o tipo como JSON (aplicativo/json) .
* No corpo da solicitação, altere conforme desejado:

{
    "taskTitulo": "Título",
    "taskDescricao": "Descrição teste",
    "taskDataCriacao": "2019-09-14T00:00:00",
    "taskFlgConcluido": true
}

Testar requisição DELETE{id}

* Defina o método HTTP como DELETE.
* Envie na url o id desejado. Por exemplo: https://localhost:1234/api/task/1
