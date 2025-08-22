internal class Colecao : Obra
{
    public Colecao(string autor, string titulo, string genero) : base(autor, titulo, genero)
    {
    }

    public override string GetObras()
    {
        string listagem = $"\nObras na coleção {titulo}:";

        if (lista_obras.Count != 0)
        {
            foreach (Obra obra in lista_obras)
            {
                listagem += obra.GetObras();
            }
        }
        
        return listagem;
    }
}