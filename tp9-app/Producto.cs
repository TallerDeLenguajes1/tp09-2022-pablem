public class Producto
{
    string nombre;
    DateTime fechavencimiento;
    float precio; //entre 1000 y 5000;
    string tamanio;

    public Producto(string nombre, DateTime fechavencimiento, float precio, string tamanio)
    {
        this.nombre = nombre;
        this.fechavencimiento = fechavencimiento;
        this.precio = precio;
        this.tamanio = tamanio;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public DateTime Fechavencimiento { get => fechavencimiento; set => fechavencimiento = value; }
    public float Precio { get => precio; set => precio = value; }
    public string Tamanio { get => tamanio; set => tamanio = value; }


    public void generarProducto()
    {
        const string[] nombresProductos = {"Remera","Campera","Pantalón","Bufanda","Boxer","Camisa","Medias","Zapatillas"}; //cambiar por productos c/vencimiento y diferentes tamaños 
        const string[] tamaniosProductos = {"Chico","Mediano","Grande"};

        var rnd = new Random();
        Nombre = nombresProductos(rnd.Next(0,nombresProductos.Count-1));
        Fechavencimiento = DateTime.Today.AddDays(rnd.Next(0,1095));
        Precio = rnd.NextDouble(1000,5000);
        Tamanio = tamaniosProductos(rnd.Next(0,tamaniosProductos.Count-1));
    }

    public void mostrarProducto()
    {
        Console.WriteLine("Producto: {0}, Tamaño: {1}, Precio: {2}, Vto.: {3}",Nombre,Tamanio,Precio,Fechavencimiento);
    }
}