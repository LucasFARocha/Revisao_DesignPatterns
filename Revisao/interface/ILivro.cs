internal interface ILivro
{
    public void Adquirir(string data_emprestimo, string adquirente);
    public void Devolver(string data_devolucao, string adquirente);
}