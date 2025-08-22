internal class LivroConcreto
{
    private string? data_emprestimo;
    private string? data_devolucao;
    private string? adquirente;
    private ILivro livro;

    public LivroConcreto(ILivro livro)
    {
        this.livro = livro;
    }

    public void Adquirir(string data_emprestimo, string adquirente)
    {
        this.data_emprestimo = data_emprestimo;
        this.adquirente = adquirente;

        livro.Adquirir(data_emprestimo, adquirente);
    }
    public void Devolver(string data_devolucao, string adquirente)
    {
        this.data_devolucao = data_devolucao;
        this.adquirente = adquirente;

        livro.Devolver(data_devolucao, adquirente);
    }
}