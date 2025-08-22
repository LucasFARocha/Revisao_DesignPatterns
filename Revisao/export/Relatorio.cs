abstract class Relatorio
{
    public void GerarRelatorio(string texto_titulo, string texto_conteudo)
    {
        ImprimirTitulo(texto_titulo);
        ImprimirConteudo(texto_conteudo);
    }

    protected abstract void ImprimirTitulo(string texto_titulo);
    protected abstract void ImprimirConteudo(string texto_conteudo);
}