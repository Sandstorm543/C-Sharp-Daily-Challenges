class Producto
{
    // Atributos de la class Producto.
    internal int ID;
    internal string? nombre;
    internal decimal precio;
    internal int cantidad_disponible;

    // Aca inicializo las variables con un contructor, las inicializo, por que las variables, deben tener un valor percep base.

    public Producto()
    {
        ID = 0;
        nombre = string.Empty;
        precio = 0;
        cantidad_disponible = 0;
    }

    // Aca meto todas las variables despues de ser capturadas, para poder crear la list.

    public Producto(int id, string nombre, decimal precio, int cantidad_disponible)
    {
        ID = id;
        this.nombre = nombre;
        this.precio = precio;
        this.cantidad_disponible = cantidad_disponible;
    }

    // Captura de datos de los atributos de la class Program.
    // Y sus respectivas validaciones de entrada, asi como para caracterese numericos, como para string.
    // Y el uso de (.Error.), para marcar que es un mensaje de error si la validacion resulta erronea.

    internal void Registrar_Producto()
    {
        Console.WriteLine("Intrduzca el ID: ");

        while (!int.TryParse(Console.ReadLine(), out ID))
        {
            Console.Error.WriteLine("!ERROR!.. Introduzca solo caracteres numericos");

            Console.WriteLine("Ingrese nuevamente el caracter numerico: ");
        }

            Console.WriteLine("Introduzca el nombre del producto: ");

            nombre = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(nombre) || !nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
        {
            Console.Error.WriteLine("!ERROR!.. Introduce solo letras y espacios: ");
            nombre = Console.ReadLine();
        }

        Console.WriteLine("Introduzca el precio del producto: ");

        while (!decimal.TryParse(Console.ReadLine(), out precio) || precio < 0)
        {
            Console.Error.WriteLine("!ERROR!.. Introduzca solo caracteres numericos");

            Console.WriteLine("Ingrese nuevamente el caracter numerico: ");
        }

        Console.WriteLine("Ingrese la cantidad en stock disponible: ");

        while (!int.TryParse(Console.ReadLine(), out cantidad_disponible) || cantidad_disponible < 0)
        {
            Console.Error.WriteLine("!ERROR!.. Introduzca solo caracteres numericos");
            
            Console.WriteLine("Ingrese nuevamente el caracter numerico: ");
        }

    }
}