Construtores

São um método especial, que contém o mesmo nome do seu tipo classe, e tem o objetivo de definir valores padrão, limitar uma instância e facilitar a instanciação de um objeto.

- Um construtor não possui um retorno.
- Um construtor padrão é sempre definido quando não declaramos nenhum para sua classe.
- Uma classe pode ter mais de um construtor.

public class Pessoa

{

private string nome;

public Pessoa()--Construtor

{

}

public Pessoa(string nome)--Construtor

{

this.nome = nome;

}

}

static void Main(string[] args)

{

Pessoa p1 = new Pessoa();--Chamando os construtores

Pessoa p2 = new Pessoa("Leo");

}

Get e Set

Serve para que você possa atribuir um valor em uma variável de maniera controlada e com validações.

namespace ExemploConstrutores.Models

{

public class Data

{

private int mes;--Variável

public int GetMes()--Get

{

return this.mes;

}

public void SetMes(int mes)--Set

{

if(mes > 0 && mes <=12)

{

this.mes = mes;

}

}

}

}

Modificadores

Readonly(somente leitura), bloqueia um campo contra alterações que não sejam em sua inicialização ou pelo próprio construtor.

Constante

Representa um valor que somente pode ser atribuído no momento de sua inicialização, e não pode ser modificado posteriormente.

Delegates

É uma maneira de passar um método como referência, podendo ser usado como um callback, aceitando qualquer método que contenha a mesmo assinatura.

Eventos

Mecanismo de comunicação entre objetos, onde existe um publisher, que realiza o evento e o subscriber, que se inscreve em um evento.

