class Menu_Principal
{
    // Atributo de la class Menu_Primcipal, lac cual usa el modificador Private, por que solo sera usada en el menu, 
    // y no hace falta que nadie mas tenga acceso

    private int opcion;

    // Aca llamo la class Inventario, la llamo como atributo, para no tener que estar llamando a cada rato, 
    // ya que quiero usar una unica instancia,
    // para todas las opciones del menu, por que quiero trabajar con una unica list

    private readonly Inventario inventario = new Inventario();

    // Metodo Mostrar_Menu en el que se ejecuta el menu_Principal.
    // Utilizacion del loops do while, para ejecutar el menu varias veces hasta que eusuario decida salir.
    // Y su respectiva validacion de entrada en la variable opcion

    internal void Mostrar_Menu()
    {
        do
        {
            Console.Clear();

            Console.WriteLine("1. Registrar Producto");

            Console.WriteLine("2. Mostrar Inventario");

            Console.WriteLine("3. Buscar producto");

            Console.WriteLine("4. Salir");

            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.Error.WriteLine("Entrada no válida. Escribe un caracter numerico");
            }

            switch(opcion)
            {
                case 1:

                //Aca llamo la class Producto con una instancia, para poder traer la captura de datos.

                Producto producto = new Producto();
                producto.Registrar_Producto();

                // Aca hago uso de la list que esta en inventario, la cual llame la class en los atributos, por lo que explique arriba

                inventario.AgregarProducto(producto);
                Console.WriteLine("Producto registrado.. Presione una tecla para continuar.");
                Console.ReadKey();

                break;

                case 2:

                // De igual forma aqui llamo el metodo Mostrar_inventario con la misma instancia que en el caso 1, 
                // para que compartan list y los datos registrados en la captura de datos sean lo mismo..

                inventario.Mostrar_inventario();

                break;

                case 3:
                break;

                case 4:

                //Enviroment.Exit(0) para salir del programa al selecionar el 4.

                Environment.Exit(0);
                break;

                default:
                Console.WriteLine("Por favor selecionar una de los 4 opciones disponible..");
                break;
            }
        }
        while(opcion != 4);
    }
}