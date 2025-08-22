internal class Livro : Obra, ILivro
{
    public Livro(string autor, string titulo, string genero) : base(autor, titulo, genero)
    {
    }

    // ILivro
    public void Adquirir(string data_emprestimo, string adquirente)
    {
        Console.WriteLine($"\n{titulo} adquirido por {adquirente} em {data_emprestimo}");
    }

    // ILivro
    public void Devolver(string data_devolucao, string adquirente)
    {
        Console.WriteLine($"\n{titulo} devolvido por {adquirente} em {data_devolucao}");
    }

    // Obra
    public override string GetObras()
    {
        string info = $"\n- Autor: {autor} | Título: {titulo} | Gênero: {genero}";

        return info;
    }
}