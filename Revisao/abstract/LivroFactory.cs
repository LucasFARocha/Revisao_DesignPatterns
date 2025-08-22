internal class LivroFactory
{
    private readonly Dictionary<string, Obra> obras = [];

    public Obra GetObra(string autor, string titulo, string genero, string tipo)
    {
        string key = $"{autor}_{titulo}_{genero}_{tipo}";

        if (!obras.ContainsKey(key))
        {
            if (tipo.ToLower() == "livro")
            {
                obras[key] = new Livro(autor, titulo, genero);
            }
            else
            {
                obras[key] = new Colecao(autor, titulo, genero);
            }
        }

        return obras[key];
    }
}