class Captura_Menu
{
    // Guarda la opción ingresada; private protected permite acceder desde esta clase y sus clases derivadas del mismo ensamblado.
    private protected int opcion;
    internal void Mostrar_Datos_Menu()
    {

    Console.WriteLine("1. Registrar Producto");

    Console.WriteLine("2. Mostrar Inventario");

    Console.WriteLine("3. Buscar producto");

    Console.WriteLine("4. Salir");

    while (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.Error.WriteLine("Entrada no válida. Escribe un caracter numerico");
    }

    }

}