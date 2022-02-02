<div align="center">
  <h1>C# Estrutura de programa</h1>
</div>

* Programas C# consistem em um ou mais arquivos.
* Os programas declaram tipos, que contêm membros e podem ser organizados em namespaces.
* Classes e interfaces são exemplos de tipos.
* Campos, métodos, propriedades e eventos são exemplos de membros.

## Tipos de variaveis

### Tipos de valor

* Variáveis de tipos de valor contêm diretamente seus dados.
* As variáveis têm sua própria cópia dos dados e não é possível que as operações afetem outra variável (exceto no caso das variáveis de parâmentro ref e out).
* Numéricos:sbyte, short, int, long, byte, ushort, uint, unlog.
* Caracteres Unicode: char.
* Pontos flutuantes: float, double, decimal.
* Booleano: bool.

### Tipos de referência

* Variáveis de tipos de referência armazenam referências a seus dados.
* É possível que duas variáveis façam referência ao mesmo objeto e, portanto, que oprações em uma variável afetem o objeto referenciado pela outra variável.
* Tipos Classe: class, object, string.
* Tipos Arrays: int[], int[,], etc...

## Instruções

### Ações de um programa são expressas usando instruções.
{
  Um bloco permite que várias instruções sejam escritas em contextos
}
* Declaração de variáveis e constantes locais
* if
* switch
* while
* do
* for
* foreach
* break
* continue
* return
* throw
* try...catch...finally
* using

## Array

* Um array é uma estrutura de dados que contém um número X de elementos, todos do mesmo tipo, acessados através de índices computados.
* Arrays são tipos e referência e a declaração de uma variável array simplismente reserva espaço para uma referência de uma instância de array.
* Ao criar um array é especificado o tamanho da nova instância, que é fixo durante todo o tempo de vida da instãncia.
* Os índices dos elementos de um array variam de 0 a comprimento do array -1.

### Array unidimensional 

> int[] a= new int [10];
 for (int i = 0; i < a.Length; i++)
 {
   a[i] = i * i;
}
for (int i = 0; i < a.Length; i++)
{
   Console.WriteLine ($"a[{i}] = {a[i]}");
}

### Array multidimensional (matrizes)

> int [,] a2 = new int[10, 5];

> int[,,] a3 = new int[10, 5, 2];

### Inicializador de array

1) > int[] a = new int[] {1, 2, 3};

ou

> int[] a = {1, 2, 3};

2) > int[] t = new int[3];
t[0] = 1;
t[1] = 2;
t[2] = 3;
int[] a = t;

## Classes e Objetos

* Classes são os tipos mais fundamentais de C#.
* Uma classe é uma estrutura de dados que combina estado (campos) e ações (métodos).
* Objetos são instâncias de uma classe.
* As classes suportam herança e polimorfismo, mecanismos pelos quias as classes derivadas podem estender e epecializar as classes base.
Declaração de uma classe:

> public class Ponto
 {
    public int x, y;
    public Ponto (int x, int y)
     {
        this.x = x;
        thid.y = y;
     }
 }

* Instâncias de classes (objetos) são criadas usando o operador new, que aloca memória para uma nova instância, chama um construtor para inicializar a instância e retorna uma referência à instância:

Ponto p1 = newPonto(0,0);
Ponto p2 + newPonto(10,20);

* A memória ocupada por um objeto é recuperada automaticamente quando o objeto não está mais acessível. Não é necessário nem possível deslocar explicitamente objetos em C#.

## Membros

* Os membros de uma classe podem ser estáticos ou membros da instância.
* Membros estáticos pertecem a classe e membros de instância pertecem ao objeto.
* Constantes, variáveis, métodos, propriedades,
construtores, etc...
* Cada membro de uma classe tem uma acessibilidade associada, que controla as regiões do texto do programa que podem acessar o membro.
  Podem ser: 
    public
    protected
    internal
    private

## Herança

* Uma declaração de classe pode especificar uma classe base, herdando os membros public, internal e protected da classe base.
* Omitir uma especificação de classe base é o mesmo que derivar do tipo object.

## Métodos

* Um método é um membro que implementa uma computação ou ação que pode ser executada por um objeto ou classe.
* Os métodos podem ter uma lista de parâmetros, que representam valores ou referências de variáveis passados para o método, e um tipo de retorno, que especifica o tipo do valor calculado e retornado pelo método.

## Structs

* Como as classes, as structs são estruturas de dados que podem conter membros de dados e membros de ação, mas, diferentemente das classes, as structs são tipos de valor e não requerem alocação de heap.
* Uma variável de um tipo de struct armazena diretamente os dados da estrutura, enquanto uma variável de um tipo de classe armazena uma referência a um pbjeto alocado na memória.
* Structs não aceitam herança determinada pelo desenvolvedor.
* São úteis para pequenas estruturas de dados que possuem semântica de valor: números complexos, pontos em um sistema de coordenadas ou pares de chave-valor em um dicionário são bons exemplos de utilização.
* O uso de structs em vez de classes para pequenas estruturas de dados pode fazer uma grande diferença no número de alocações de memória.
exemplo:

> public struct Ponto
 { 
    public int x, y;
    public Ponto (int x, int y)
     {
        this.x = x;
        this.y = y;
     }
 }
 
* Construtores de structs são chamados com o operador new, semelhante a um construtor de classe, mas em vez de alocar dinamicamente um objeto no heap gerenciado e retornar uma referência a ele, um construtor struct simplesmente retorna o próprio valor struct (normalmente em um local temporário na stack), e esse valor é copiado conforme necessário.

## Estruturas - exemplos:

### Names
* Os namespaces são usados para organizar classes: 

<p align="center">
  <img width="200" src="https://github.com/WelbertJr/Bootcamp-DIO---LocalizaLabs-.NET-Developer-2/blob/main/Imagens/namespace.png?raw=true">  
  <br>
</p> 

* Para usar uma classe de outro namespace, colocamos using no começo do código:

<p align="center">
  <img width="200" src="https://github.com/WelbertJr/Bootcamp-DIO---LocalizaLabs-.NET-Developer-2/blob/main/Imagens/using.png?raw=true">  
  <br>
</p> 

### Classe

* Uma classe pode ter campos, propriedades, métodos e eventos dentro dela que são denominados membros:

<p align="left">
  <img width="200" src="https://github.com/WelbertJr/Bootcamp-DIO---LocalizaLabs-.NET-Developer-2/blob/main/Imagens/classe-membro.png?raw=true">  
  <br>
</p> 

* Quando um classe é instanciada, essa instância é chamada de objeto, e nesse objeto podem ser criados os valores de acordo com os campos da classe:

p align="center">
  <img width="200" hspace="30" src="https://github.com/WelbertJr/Bootcamp-DIO---LocalizaLabs-.NET-Developer-2/blob/main/Imagens/animal1.png?raw=true">
  <img width="190" src= "https://github.com/WelbertJr/Bootcamp-DIO---LocalizaLabs-.NET-Developer-2/blob/main/Imagens/animal2.png?raw=true">
  <br>
</p> 

### Interface

* É como uma classe base que serve de molde para várias classes.
* Uma interface define um contrato que pode ser implementado por classes e structs. 
* Pode conter métodos, propriedades, eventos e indexadores. 
* Não fornece implementações dos membros que define - apenas suas "assinaturas". 
* As interfaces podem empregar herança múltipla.

<p align="center">
  <img width="200" src="https://github.com/WelbertJr/Bootcamp-DIO---LocalizaLabs-.NET-Developer-2/blob/main/Imagens/interface1.png?raw=true">  
  <br>
</p> 

* Uma classe que implementa uma interface deve implementar todos os membros:

<p align="center">
  <img width="200" src="https://github.com/WelbertJr/Bootcamp-DIO---LocalizaLabs-.NET-Developer-2/blob/main/Imagens/interface1.png?raw=true">  
  <br>
</p> 

### Enum
* Um enum é um tipo de valor distinto com um conjunto de constantes nomeadass.
* Você define enumerações quando precisa definir um tipo que pode ter um conjunto de valores discretos. Eles usam um dos tipos de valor integral como armazanamento subjacente. Eles fornecem significado semântico aos valores discretos.
* Cada tipo de enum possui um tipo integral correspondente chamado tipo subjacente do tipo de enum.
* Um tipo de enumeração que não declara explicitamente um tipo subjacente tem um tipo subiacente int.
* Declara um conjunto de constantes nomeadas que começam de 0 e aumentam de 1 em 1:

<p align="center">
  <img width="135" src="https://github.com/WelbertJr/Bootcamp-DIO---LocalizaLabs-.NET-Developer-2/blob/main/Imagens/enum.png?raw=true">
   <br>
</p> 

# Debugging

* A depuração pode ser feita colocando um BreakPoint no canto esquerdo do código ou apertando f9 e executando ele.
* O código vai parar onde foi colocado o BreakPoint e então o código poderá ser inspecionado:
<p align="center">
  <img width="250" src="https://github.com/WelbertJr/Bootcamp-DIO---LocalizaLabs-.NET-Developer-2/blob/main/Imagens/debugging.png?raw=true">
   <br>
</p> 
