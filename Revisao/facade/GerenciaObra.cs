internal class GerenciaObra
{
    public void AdicionarObra(Obra obra, Colecao colecao)
    {
        colecao.Add(obra);
    }

    public void RemoverObra(Obra obra, Colecao colecao)
    {
        colecao.Remove(obra);
    }
}