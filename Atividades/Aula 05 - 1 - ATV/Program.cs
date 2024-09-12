using Aula_05___1___ATV;

List<Livro> livros = new List<Livro>
{
    new Livro { Nome = "Dom Casmurro", Editora = "Companhia das Letras", Autor = "Machado de Assis", NumeroDePaginas = 256 },
    new Livro { Nome = "1984", Editora = "Companhia das Letras", Autor = "George Orwell", NumeroDePaginas = 336 },
    new Livro { Nome = "O Senhor dos Anéis", Editora = "HarperCollins", Autor = "J.R.R. Tolkien", NumeroDePaginas = 1216 },
    new Livro { Nome = "A Revolução dos Bichos", Editora = "Companhia das Letras", Autor = "George Orwell", NumeroDePaginas = 128 },
    new Livro { Nome = "A Menina que Roubava Livros", Editora = "Intrínseca", Autor = "Markus Zusak", NumeroDePaginas = 592 }                
};

Livro livroComMaisPaginas = livros.OrderByDescending(l => l.NumeroDePaginas).FirstOrDefault();
            
if(livroComMaisPaginas != null)
{
    Console.WriteLine("Livro com o maior número de páginas:");
    Console.WriteLine(livroComMaisPaginas);
}
else
{
    Console.WriteLine("Nenhum livro encontrado.");
}
