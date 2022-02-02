O que é API?

-Application Program Interface.

- Pense em API como a camada que esconde as regras e possibilita uma comunicação externa.
-Facilita muito a integração.
-Existem várias metodologias (ou arquiteturas), como por exemplo: SOA, Rest, uso por meio de SDK.

Https Methods

Get: Sempre obtém os dados.
Post: Cria um novo registro ou recurso.
Put: Atualiza um registro existente.
Delete: Remove um registro existente.

Padrões

Get: /api/dev/user
Post: /api/dev/user
Put: / api/dev/user/{id}
Delete: /api/dev/user/{id}

Erros comuns

Post: /api/dev/user/{id}
Post: /api/dev/user/create
Put: /api/dev/user
Delete: /api/dev/user?id=2

Status Codes
Geralmente:
2x...= Sucesso
4x...=Erro no cliente
5x...=Erro server side

Status comuns:
200 = OK
401 = Unauthorized
403 = Forbidden
404 = Not found
500 = Internal Server Error
504 = Gateway Timeout
DICA DE TECNOLOGIA PARA CONSUMIR API: Postman﻿
