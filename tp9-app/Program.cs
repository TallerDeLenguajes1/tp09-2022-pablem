
using System;
using System.Text.Json; 
using System.Text.Json.Serialization;

const int N = 7;

//1) Indexador de carpeta (formato json)

// Console.WriteLine("Ingrese la ruta: ");
// string ruta = Console.ReadLine();
string rutaScan = @"..\root";
string nombreDestino = @"..\datos\index.json";
/* Genero lista de objetos "Archivos" */
var listaArchivos = generarListaArchivos(rutaScan);
/* Serializo la lista de objetos "Archivos" */
string archivosJson = JsonSerializer.Serialize(listaArchivos);
/* Guardo en archivo .json la lista de objetos "Archivos"*/ 
guardarJson(nombreDestino, archivosJson);


//2) Listado de Productos

nombreDestino = @"..\datos\productos.json";
/* Genero lista de objetos Productos */
var listaProductos = generarProductos();
/* Serializo la lista de Productos */
string productosJson = JsonSerializer.Serialize(listaProductos);
/* Guardo en archivo .json la lista Productos*/ 
guardarJson(nombreDestino, productosJson);
/* Abro archivo json */
var productosCargados = abrirJson(nombreDestino);
/* Deserializar y guardar en una lista */
var listaProductosCargados = JsonSerializer.Deserialize<List<Producto>>(productosCargados);
/* Mostrar por consola lista de productos */
foreach (var producto in listaProductosCargados) {
    producto.mostrarProducto();
}

/* FUNCIONES */
//1)
List<Archivo> generarListaArchivos(string rutaScan) 
{
    var listaCarpetas = Directory.GetDirectories(rutaScan).ToList();
    var listaArchivos = new List<Archivo>();
    Archivo nuevo;
    string nombre, extencion;

    foreach (var carpeta in listaCarpetas) {
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
List<Producto> generarProductos() 
{
    var listaProductos = new List<Producto>();
    Producto nuevo;
    for (int i = 0; i < N; i++) {
        nuevo = new Producto();
        nuevo.generarProducto();
        listaProductos.Add(nuevo);
    }
    return listaProductos;
}

// Funciones Json
void guardarJson(string ruta, string datos)
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
string abrirJson(string nombreArchivo)
    {
        string documento;
        using (var archivoOpen = new FileStream(nombreArchivo, FileMode.Open))
        {
            using (var strReader = new StreamReader(archivoOpen))
            {
                documento = strReader.ReadToEnd();
                archivoOpen.Close();
            }
        }
        return documento;
    }