class Captura_Datos_Buscar_Articulo
{
    // Solicita y valida el ID que se utilizará para buscar un producto.
    private protected int Capturar_ID_Buscado()
    {
        Console.WriteLine("Ingrese el ID del producto que desea buscar");
        int idBuscado;

        while (!int.TryParse(Console.ReadLine(), out idBuscado))
        {
            Console.Error.WriteLine("!ERROR!.. Introduzca solo caracteres numericos.");
            Console.WriteLine("Ingrese nuevamente el caracter numerico: ");
        }

        return idBuscado;
    }
}
