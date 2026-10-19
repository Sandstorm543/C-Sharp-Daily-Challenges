class Buscar_Producto : Captura_Datos_Buscar_Articulo
{
    // Referencia a la lista que pertenece al inventario; esta clase solo necesita consultarla.
    private readonly IReadOnlyList<Producto> productos;

    // Recibe la misma lista del inventario para buscar entre los productos registrados.
    internal Buscar_Producto(IReadOnlyList<Producto> productos)
    {
        this.productos = productos;
    }

    // Solicita un ID y muestra los datos del producto que coincida.
    internal void Buscar_Articulo()
    {
        // Obtiene el ID validado mediante el método heredado de la clase base.
        int idBuscado = Capturar_ID_Buscado();

        // Recorre la lista compartida para comparar el ID solicitado con cada producto.
        foreach (var item in productos)
        {
            if (item.ID == idBuscado)
            {
                // Muestra los datos del producto encontrado.
                Console.WriteLine($"ID del producto {item.ID}");
                Console.WriteLine($"Producto {item.nombre}");
                Console.WriteLine($"Precio del producto {item.precio}");
                Console.WriteLine($"Stock disponible {item.cantidad_disponible}");

                // Espera una tecla antes de regresar y evita seguir recorriendo la lista.
                Console.ReadKey();
                return;
            }
        }

        // Si el recorrido termina sin encontrar coincidencias, informa al usuario.
        Console.Error.WriteLine("Producto no encontrado.. ");
        Console.ReadKey();
    }
}