
using System.Text.Json; 
using System.Text.Json.Serialization;



const int N = 7;


// Console.WriteLine("Ingrese la ruta: ");
// string ruta = Console.ReadLine();
string rutaScan = @"..\root";
string nombreDestino = @"..\datos\index.json";
string nombreDestino2 = @"..\datos\productos.json";

//1) Indexador de carpeta (formato json)

/* Genero lista de objetos "Archivos" */
var listaArchivos = generarListaArchivos(rutaScan);
/* Serializo la lista de objetos "Archivos" */
string archivosJson = JsonSerializer.Serialize(listaArchivos);
/* Guardo en archivo .json la lista de objetos "Archivos"*/ 
guardarJson(nombreDestino, archivosJson);


//2) Listado de Productos

/* Genero lista de objetos Productos */
var listaProductos = generarProductos();
/* Serializo la lista de Productos */

/* Guardo en archivo .json la lista Productos*/ 

/* Deserializar json en una lista */

/* Mostrar por consola lista de productos */


//1) Métodos 
static List<Archivo> generarListaArchivos(string rutaScan) 
{
    var listaCarpetas = Directory.GetDirectories(rutaScan).ToList();
    var listaArchivos = new List<Archivo>();
    Archivo nuevo;
    string nombre, extencion;

    foreach (var carpeta in listaCarpetas)
    {
        int i=1;
        foreach (var archivo in Directory.GetFiles(carpeta)) {
            nombre = archivo.ToString().Split(@"\").Last().Split(".")[0];
            extencion = archivo.ToString().Split(@"\").Last().Split(".")[1];
            nuevo = new Archivo(i,nombre,extencion);
            listaArchivos.Add(nuevo);
        }
    }
    return listaArchivos;
}
//2)
static List<Producto> generarProductos() 
{
    var listaProductos = new List<Producto>();
    Producto nuevo;
    for (int i = 0; i < length; i++)
    {
        
    }


}
static void guardarJson(string ruta, string datos)
    {
            using(var archivo = new FileStream(ruta, FileMode.Create))
        {
            using (var strWriter = new StreamWriter(archivo))
            {
                strWriter.WriteLine("{0}", datos);
                strWriter.Close();
            }
        }
    }
