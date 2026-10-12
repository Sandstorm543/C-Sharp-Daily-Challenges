class Inventario
{

    // Declaracion de la list, que captura los valores del constructor de Producto.
    // Uso el modificador private, para que nadie, pueda cambiarla o mejor dicho el readonly, 
    // para que despues de ser inicializada, no se le pueda modificar

    private readonly List<Producto> productos = new List<Producto>();

    // Declaracion de metodo agregarProducto, el cual recibe el contructor de producto y lo captura en la list.

    public void AgregarProducto(Producto producto)
    {
        productos.Add(producto);
    }
    // Metodo Mostrar_inventario, el cual utiliza el loops foreach para recorrer la list, 
    // y usa su respectiva condicional con validacion de entrada
    
    internal void Mostrar_inventario()
    {
        if (productos.Count == 0)
    {
        Console.WriteLine("El inventario está vacío.");
        return;
    }
        
        foreach (var elemento in productos){
        if(elemento != null && !string.IsNullOrWhiteSpace(elemento.nombre))
        {
            Console.WriteLine($"Su ID: {elemento.ID}");
            Console.WriteLine($"Producto: {elemento.nombre}");
            Console.WriteLine($"Precio: {elemento.precio}");
            Console.WriteLine($"Stock disponible: {elemento.cantidad_disponible}");

        }
        else
            {
                Console.WriteLine("El producto no tiene un nombre valido..");
            }
        }
        Console.ReadKey();
    }
    internal void Buscar_Producto()
    {
        
    }
}