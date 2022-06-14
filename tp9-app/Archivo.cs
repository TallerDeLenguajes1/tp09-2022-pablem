public class Archivo
{
    int indice;
    string nombre;
    string extension;

    public Archivo(int indice, string nombre, string extension)
    {
        this.indice = indice;
        this.nombre = nombre;
        this.extension = extension;
    }

    public int Indice { get => indice; set => indice = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Extension { get => extension; set => extension = value; }

}