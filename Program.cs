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

Console.WriteLine(livro1.titulo, livro1.autor, livro1.paginas);

