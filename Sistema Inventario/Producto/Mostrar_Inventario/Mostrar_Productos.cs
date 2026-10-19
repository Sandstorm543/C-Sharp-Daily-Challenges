class Mostrar_Productos
{
    // Referencia de solo lectura a los productos registrados en el inventario.
    private readonly IReadOnlyList<Producto> productos;

    // Recibe la misma lista del inventario para poder mostrar sus productos.
    internal Mostrar_Productos(IReadOnlyList<Producto> productos)
    {
        this.productos = productos;
    }

    // Muestra todos los productos registrados o informa si la lista está vacía.
    internal void Mostrar_Inventario()
    {
        // Comprueba si hay productos antes de intentar recorrer la lista.
        if (productos.Count == 0)
        {
            Console.WriteLine("El inventario está vacío.");
            return;
        }

        // Recorre la lista y muestra los datos de cada producto que tenga un nombre válido.
        foreach (var elemento in productos)
        {
            if (!string.IsNullOrWhiteSpace(elemento.nombre))
            {
                // Presenta los datos principales del producto.
                Console.WriteLine($"Su ID: {elemento.ID}");
                Console.WriteLine($"Producto: {elemento.nombre}");
                Console.WriteLine($"Precio: {elemento.precio}");
                Console.WriteLine($"Stock disponible: {elemento.cantidad_disponible}");
                
            }

            else
            {
                // Informa cuando un elemento no tiene un nombre válido para mostrar.
                Console.WriteLine("El producto no tiene un nombre valido..");
            }
        }

        // Espera una tecla para que el usuario pueda leer los resultados antes de continuar.

        Console.ReadKey();
    }
}