internal class Fachada
{
    private GerenciaObra gerenciaObra;
    private GerenciaBusca gerenciaBusca;
    private GerenciaEmprestimo gerenciaEmprestimo;
    private GerenciaRelatorio gerenciaRelatorio;

    public Fachada()
    {
        gerenciaObra = new GerenciaObra();
        gerenciaBusca = new GerenciaBusca();
        gerenciaEmprestimo = new GerenciaEmprestimo();
        gerenciaRelatorio = new GerenciaRelatorio();
    }

    // Métodos para gerenciar obras dentro de uma coleção já existente
    // Para criar uma coleção, utilize o método CriarObra
    public void AdicionarObra(Obra obra, Colecao colecao)
    {
        gerenciaObra.AdicionarObra(obra, colecao);
    }
    public void RemoverObra(Obra obra, Colecao colecao)
    {
        gerenciaObra.RemoverObra(obra, colecao);
    }

    // Métodos para gerenciar buscas
    public Obra BuscarObra(string autor, string titulo, string genero, string tipo)
    {
        return gerenciaBusca.BuscarObra(autor, titulo, genero, tipo);
    }
    public Obra CriarObra(string autor, string titulo, string genero, string tipo)
    {
        return this.BuscarObra(autor, titulo, genero, tipo);
    }
    public string ListarObras(Colecao colecao)
    {
        return gerenciaBusca.ListarObras(colecao);
    }

    // Métodos para gerenciar empréstimos
    public void EmprestarObra(Livro livro, string dataEmprestimo, string adquirente)
    {
        gerenciaEmprestimo.EmprestarObra(livro, dataEmprestimo, adquirente);
    }
    public void DevolverObra(Livro livro, string dataDevolucao, string adquirente)
    {
        gerenciaEmprestimo.DevolverObra(livro, dataDevolucao, adquirente);
    }

    // Métodos para gerar relatórios
    public void GerarRelatorio(string titulo, string conteudo, string tipo_relatorio)
    {
        gerenciaRelatorio.GerarRelatorio(titulo, conteudo, tipo_relatorio);
    }
}