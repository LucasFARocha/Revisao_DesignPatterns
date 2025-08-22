internal class GerenciaBusca
{
    private LivroFactory livroFactory = new LivroFactory();

    public Obra BuscarObra(string autor, string titulo, string genero, string tipo)
    {
        return livroFactory.GetObra(autor, titulo, genero, tipo);
    }
    public string ListarObras(Colecao colecao)
    {
        return colecao.GetObras();
    }
}