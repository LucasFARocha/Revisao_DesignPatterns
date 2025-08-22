internal class PDF : Relatorio
{
    protected override void ImprimirTitulo(string texto_titulo)
    {
        Console.WriteLine($"\nRelatório PDF: {texto_titulo}");
    }

    protected override void ImprimirConteudo(string texto_conteudo)
    {
        Console.WriteLine($"\n{texto_conteudo}");
    }
}