Fachada fachada = new Fachada();

// -----------------------------------------------------
// Criando uma coleção e adicionando um livro
Colecao SenhorDosAneis = (Colecao) fachada.CriarObra("Tolkien", "O Senhor dos Anéis", "Fantasia", "Coleção");
Livro Hobbit = (Livro) fachada.CriarObra("Tolkien", "O Hobbit", "Fantasia", "Livro");

fachada.AdicionarObra(Hobbit, SenhorDosAneis);

Console.WriteLine(fachada.ListarObras(SenhorDosAneis));

// -----------------------------------------------------
// Criando uma coleção e adicionando vários livros
Colecao TrilogiaSenhorDosAneis = (Colecao)fachada.CriarObra("Tolkien", "Trilogia Senhor dos Anéis", "Fantasia", "Coleção");
Livro sociedadeAnel = (Livro)fachada.CriarObra("Tolkien", "A Sociedade do Anel", "Fantasia", "Livro");
Livro duasTornes = (Livro)fachada.CriarObra("Tolkien", "As Duas Torres", "Fantasia", "Livro");
Livro retornoRei = (Livro)fachada.CriarObra("Tolkien", "O Retorno do Rei", "Fantasia", "Livro");

fachada.AdicionarObra(sociedadeAnel, TrilogiaSenhorDosAneis);
fachada.AdicionarObra(duasTornes, TrilogiaSenhorDosAneis);
fachada.AdicionarObra(retornoRei, TrilogiaSenhorDosAneis);

Console.WriteLine(fachada.ListarObras(TrilogiaSenhorDosAneis));

// -----------------------------------------------------
// Adicionando a coleção TrilogiaSenhorDosAneis à coleção SenhorDosAneis
fachada.AdicionarObra(TrilogiaSenhorDosAneis, SenhorDosAneis);

Colecao colecao = (Colecao)fachada.BuscarObra("Tolkien", "O Senhor dos Anéis", "Fantasia", "Coleção");
Console.WriteLine(fachada.ListarObras(colecao));

// -----------------------------------------------------
// Supondo que o livro volte rasgado, vamos removê-lo da coleção
fachada.EmprestarObra(sociedadeAnel, "01/01/2023", "Lucas");
fachada.DevolverObra(sociedadeAnel, "10/01/2023", "Lucas");

fachada.RemoverObra(sociedadeAnel, TrilogiaSenhorDosAneis);
Console.WriteLine(fachada.ListarObras(SenhorDosAneis));

// -----------------------------------------------------
// Gerando um relatório sobre a coleção SenhorDosAneis
fachada.GerarRelatorio("\nRelatório Semanal", "Cliente retornou o livro com rasgos", "PDF");
fachada.GerarRelatorio("\nRelatório Semanal", "Cliente retornou o livro com rasgos", "HTML");
fachada.GerarRelatorio("\nRelatório Semanal", "Cliente retornou o livro com rasgos", "TXT");