Coleções

Arrays

O array é uma estrutura de dados que armazena valores do mesmo tipo, com um tamanho fixo.

1. int[] array = new int [4];
1. int[] array = new int []{42,75,74,61};
1. string[] nomes = {"Jan", "Fev"};

Índice: É a posição de um determinado valor de um array, sempre começando com zero.

1. var elemento = array[0] --Obtém o valor no índice 0 e armazena na variável elemento.
1. array[0] = 42 --Se quiser modificar o valor da variável, basta colocar "array" sua posição e o valor que queremos colocar...

Array Multidimensional

O array pode possuir mais de uma dimensão:

int[,]array = new int[4,2];     \_\_\_\_\_\_\_\_\_\_\_\_\_\_

4 = Número de linhas           | 1     |    2  |

| 3     |    4  |

| 5     |    6  |

|\_7\_\_\_\_\_|\_\_\_\_8\_\_|

1. = Número de colunas

Acessar um valor: array[1,1]

Ordenando Arrays

Para ordenar um array, existem diversos algoritmos de ordenação, diferentes técnicas e casos a serem considerados.

Valores não ordenados: 12 5 15 14 1 18 4 15

Valores ordenados: 1 4 5 12 14 15 15 18

Classe Array

A classe Array é uma classe do C3 que nos oferece diversos métodos que nos auxiliam a trabalhar com arrays.

Coleção genérica

No C#, existem classes de coleções que agrupam valores, e essas classes são padronizadas para as operações mais comuns, como:

- Ordenação
- Obter valor por índice
- Obeter valor com expressões
- Trabalhar com tamanhos dinâmicos

Coleção específica

As coleções específicas implementam regras para sua odem de acesso e manipulação de seus elementos, são elas:

- Queue (fila): Obedece a ordem FIFO(First In First Out)
- Stack (Pilha): Obedece a ordem LIFO(Last In First Out)

Dicionários

- Um dicionário é uma coleção de chave e valor, permitindo que você recupere rapidamente seus itens baseado em sua chave.
- O dicionário armazena a sua chave em hash.

Criação de um dicionário: Dictionary<string,string>estados = new Dictionary<string,string>()

LINQ

O Language-Integrated Query (LINQ) é uma maneira de você utilizar uma sintaxe de consulta padronizada para coleções de objetos.
