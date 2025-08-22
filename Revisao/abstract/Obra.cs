using System.ComponentModel;

abstract class Obra
{
    public List<Obra> lista_obras = new List<Obra>();
    protected string autor;
    protected string titulo;
    protected string genero;

    public Obra(string autor, string titulo, string genero)
    {
        this.autor = autor;
        this.titulo = titulo;
        this.genero = genero;
    }

    public virtual void Add(Obra obra)
    {
        lista_obras.Add(obra);
    }
    public virtual void Remove(Obra obra)
    {
        lista_obras.Remove(obra);
    }

    public abstract string GetObras();
}