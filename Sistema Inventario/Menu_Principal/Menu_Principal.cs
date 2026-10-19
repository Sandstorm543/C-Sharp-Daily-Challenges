class Menu_Principal : Captura_Menu
{
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

            // Muestra las opciones del menú y captura la opción ingresada por el usuario.

            Mostrar_Datos_Menu();

            switch(opcion)
            {
                case 1:

                //Aca llamo la class Producto con una instancia, para poder traer la captura de datos.

                Producto producto = new Producto();
                
                producto.Registrar_Producto();

                // Aca hago uso de la list que esta en inventario, la cual llame la class en los atributos, por lo que explique arriba

                if (inventario.AgregarProducto(producto))
                {
                    Console.WriteLine("Producto registrado.");
                }
                    else
                {
                    Console.WriteLine("Ya existe un producto con ese ID.");
                }

                break;

                case 2:

                // De igual forma aqui llamo el metodo Mostrar_inventario con la misma instancia que en el caso 1, 
                // para que compartan list y los datos registrados en la captura de datos sean lo mismo..

                inventario.Mostrar_Inventario();

                break;

                case 3:

                 // De igual forma aqui llamo el metodo Mostrar_inventario con la misma instancia que en el case 1 y case 2, 
                 // Para que compartan la misma intancia de la list y los datos capturdos sean lo mismos.

                inventario.Buscar_Producto();

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