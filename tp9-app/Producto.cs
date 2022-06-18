public class Producto
{
    static string[] nombresProductos = {"Hamburguesa", "Tarta", "Pizza","Gaseosa","Pollo","Merluza","Lomo","Nuggets","Ensalada"};
    static string[] tamaniosProductos = {"Chico","Mediano","Grande"};

    string nombre;
    DateTime fechavencimiento;
    float precio; //entre 1000 y 5000;
    string tamanio;

    // public Producto() {
        
    // }
    // public Producto(string nombre, DateTime fechavencimiento, float precio, string tamanio)
    // {
    //     this.nombre = nombre;
    //     this.fechavencimiento = fechavencimiento;
    //     this.precio = precio;
    //     this.tamanio = tamanio;
    // }

    public string Nombre { get => nombre; set => nombre = value; }
    public DateTime Fechavencimiento { get => fechavencimiento; set => fechavencimiento = value; }
    public float Precio { get => precio; set => precio = value; }
    public string Tamanio { get => tamanio; set => tamanio = value; }


    public void generarProducto()
    {
        var rnd = new Random();
        Nombre = nombresProductos[rnd.Next(0,nombresProductos.Length-1)];
        Fechavencimiento = DateTime.Today.AddDays(rnd.Next(0,1095));
        Precio = (float)rnd.NextDouble()*4000+1000;
        Tamanio = tamaniosProductos[rnd.Next(0,tamaniosProductos.Length-1)];
    }

    public void mostrarProducto()
    {
        Console.WriteLine("Producto: {0}, Tamaño: {1}, Precio: ${2:F2}, Vto.: {3}",Nombre,Tamanio,Precio,Fechavencimiento.ToString("dd/MM/yy"));
    }
}