<div align="center">
<h1>Programação orientada a objetos</h1>
</div>

* É um paradigma de programação, ou seja, corresponde a uma tecnica de programação para um fim específico.
### Dentro desta técnica, existem quatro pilares:

* Abstração

* Encapsulamento

* Herança

* Polimorfismo

## Classe: 
* É um molde...ex: planta de uma casa.

## Objeto: 
* A construção da classe...ex: casa.

## Tipos de paradigmas

* Programação orientada a objetos (é o que estamos estudando...)

* Programação estruturada

* Programação imperativa

* Programação procedural

* Programação orientada a eventos

* Programação lógica...

## Pilares

* Abstração: Abstrair um objeto do mundo real para um contexto específico, considerando apenas os atributos importantes.

Exemplo 1:
> using System;
namespace ExemploPOO.Models
{
public class Pessoa --Nome da classe
{
public string Nome { get; set;} --Nome e tipo do atributo da classe
public int Idade { get; set; }
public void Apresentar() --Cria um método(ação) para a classe
{
Console.WriteLine($¨Olá, meu nome é {Nome} e tenho {Idade} anos"); --$: Mistura o texto com a propriedade.
}
}

Exemplo 2:
> using System;
namespace ExemploPOO
{
class Program
{
static void Main(string[] args)
{
Pessoa p1 = new Pessoa(); --Cria um objeto chamado p1 do tipo Pessoa
p1.Nome = "Bob";
p1.Idade = 20;
p1.Apresentar(); --Chama o método da pessoa, chamado Apresentar
}
}
}

## Encapsulamento: 
* Serve para proteger uma classe e definir limites para alteração de suas propriedades. Serve para ocultar seu comportamento e expor somente o necessário.

Exemplo:
> namespace ExemploPOO.Models
{
public class Retangulo
{
private double comprimento;--Cria uma propriedade privada do tipo double
private double largura;
public void DefinirMedidas(double comprimento, double largura --parametros recebidos pelo método)--Método publico(vai aparecer publicamente) capaz de alterar as duas propriedades.
{
this.comprimento = comprimento; --Coloca o atributo que eu estou recebendo como parametro para os atributos privados da classe Retangulo.
this.largura = largura;
}
}
}

## Herança: 
* Nos permite reutilizar atributos, métodos e comportamentos de uma classe em outras classes. Serve para agrupar objetos que são do mesmo tipo porém com características diferentes.

Exemplo:
>namespace ExemploPOO.Models
{
public class Aluno : Pessoa --Classe Aluno herdando a classe Pessoa
{
public int Nota {get; set;} --Propriedade publica da classe Aluno
{
{

## Polimorfismo: 
* Significa "muitas formas". Com o polimorfismo podemos sobrescrever métodosdas classes filhas para que se comportem de maneira diferente e ter sua própria implementação.

> public virtual void Apresentar() --Significa que o método pode ser sobrescrito.

> public override void Apresentar() --Significa sobrescrita

### Classe abstrata: 
* Tem como objetivo ser exclusivamente um modelo para ser herdado, portanto não pode ser instanciada. Você pode implementar métodos ou deixa-los a cargo de quem herdar.

### Classe selada: 
* Tem como objetivo de impedir que outras classes façam uma herança dela, ou seja, nenhuma classe pode ser sua derivada. Também existem métodos e propriedades seladas.

> public sealed class Professor --Classe selada

### Classe object: 
* A classe System.Object é a mãe de todas as classes na hierarquia do .NET. Todas as classes derivam, direta ou indiretamente da classe Object, e ela tem como objetivo prover serviços de baixo nível para suas classes filhas.

## Interfaces: 
* São um contrato que pode ser implementado por uma classe. É como se fosse uma classe abstrata, podendo definir métodos abstratos para serem implementados. Assim como uma classe abstrata, uma interface não pode ser instanciada.

## Arquivos: 
* O C# nos apresenta algumas classes estáticas que facilitam o trabalho com arquivos, dentre elas:

* File

* Directory

* Path


