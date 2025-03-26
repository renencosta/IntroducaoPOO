/*## Criando Objetos e Classes (25/03)
### **1 - Criando uma Classe "Livro" e Instanciando um Objeto**
Crie uma classe chamada `Livro` com os seguintes atributos:
- `titulo` (tipo `string`)
- `autor` (tipo `string`)
- `paginas` (tipo `int`)
Depois, instancie um objeto da classe `Livro`, atribua valores aos atributos e exiba as informações no console.*/

using ExerciciosPOO;

Livro livro1 = new Livro();
livro1.titulo = "Cabeça fria, coração quente";
livro1.autor = "Abel Ferreira";
livro1.paginas = 200;

//outra forma de instanciar objeto e atribuir caracteristicas
Livro livro2 = new Livro()
{
    autor = "Renan",
    titulo = "Orientacao a objetos",
    paginas = 100
};

Console.WriteLine(livro1.titulo);
Console.WriteLine(livro1.autor);
Console.WriteLine(livro1.paginas);

/* ### **2 - Criando e Utilizando um Objeto "Aluno"**
Crie uma classe chamada `Aluno` com os seguintes atributos:
- `nome` (tipo `string`)
- `idade` (tipo `int`)
- `notaFinal` (tipo `double`)
Depois, crie dois objetos da classe `Aluno`, atribua valores a eles e exiba os detalhes de ambos.*/

Aluno aluno1 = new Aluno()
{
    nome = "Isabela",
    idade = 1,
    notaFinal = 9.8
};

Console.WriteLine($"O primeiro aluno é {aluno1.nome}, idade: {aluno1.idade} e a sua nota é {aluno1.notaFinal}.");


Aluno aluno2 = new Aluno();
aluno2.nome = "Renan";
aluno2.idade = 37;
aluno2.notaFinal = 7.5;

Console.WriteLine($"O primeiro aluno é {aluno2.nome}, idade: {aluno2.idade} e a sua nota é {aluno2.notaFinal}.");


/* ### **3 - Criando uma Classe "Produto" e Trabalhando com Objetos**
Crie uma classe chamada `Produto` com os seguintes atributos:
- `nome` (tipo `string`)
- `preco` (tipo `double`)
- `quantidadeEmEstoque` (tipo `int`)
Também crie o seguinte método:
- `CalcularTotal` que retorna o total da `quantidadeEmEstoque` *  `preco`
Depois, crie um objeto da classe `Produto`, altere os valores dos atributos e imprima as informações antes e depois da alteração, também imprima o resultado do método CalcularTotal.*/

Produto produto1 = new Produto();
produto1.nome = "Notebook";
produto1.preco = 4599.99;
produto1.qtdEstoque = 10;

Console.WriteLine($"O produto informado foi {produto1.nome}, o valor atual é {produto1.preco} e a quantidade em estoque é {produto1.qtdEstoque}.");
Console.WriteLine($"O valor total do produto é {Math.Round(produto1.CalcularTotal(), 2)}");    
