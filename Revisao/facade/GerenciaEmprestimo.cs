internal class GerenciaEmprestimo
{
    public void EmprestarObra(Livro livro, string data_emprestimo, string adquirente)
    {
        LivroConcreto livroConcreto = new LivroConcreto(livro);
        livroConcreto.Adquirir(data_emprestimo, adquirente);
    }
    
    public void DevolverObra(Livro livro, string data_devolucao, string adquirente)
    {
        LivroConcreto livroConcreto = new LivroConcreto(livro);
        livroConcreto.Devolver(data_devolucao, adquirente);
    }
}