internal class GerenciaRelatorio
{
    public void GerarRelatorio(string titulo, string conteudo, string tipo_relatorio)
    {
        Relatorio relatorio = new TXT();

        if (tipo_relatorio.ToLower() == "pdf")
        {
            relatorio = new PDF();
        }
        else if (tipo_relatorio.ToLower() == "html")
        {
            relatorio = new HTML();
        }

        relatorio.GerarRelatorio(titulo, conteudo);
    }
}