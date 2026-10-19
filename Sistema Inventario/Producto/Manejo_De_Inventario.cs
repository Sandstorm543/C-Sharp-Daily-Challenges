class Inventario
{
    // Declaracion de la list, que captura los valores del constructor de Producto.

    // Uso el modificador private, para que nadie, pueda cambiarla o mejor dicho el readonly, 

    // para que despues de ser inicializada, no se le pueda modificar

    private readonly List<Producto> productos = new List<Producto>();

    private readonly Buscar_Producto buscador;

    private readonly Mostrar_Productos mostrarProductos;

    // Al crear el inventario, conecta el buscador y el mostrador con la lista de productos
    // para que ambas clases consulten los mismos productos que este inventario administra.
    
    internal Inventario()
    {
        buscador = new Buscar_Producto(productos);
        
        mostrarProductos = new Mostrar_Productos(productos);
    }

    // Declaracion de metodo agregarProducto, el cual recibe el contructor de producto y lo captura en la list.

    // Ojo este metodo hace una validacion en la variable ID, para que si se repite salte un error de que ese ID no se podra usar, ya que fue utilizado en otro producto, 

    // para esto declaro el metodo como bool y utilizo un loops foreach, para recorrer la list y verificar el ID, si es encontrado uno similar, pues salatara un error y 

    // usara el return false; ya que es un bool negativo y te sacara de la list y te enviara al menu sin haber registrado tu ID, ya que es repetitivo, y si no esta repetido,

    // pues lo registrara en la list y devolvera un return true y lo guardara en la list. Y saldra un mensaje de que su producto fue registrado correctamente.

    public bool AgregarProducto(Producto producto)
    {

        foreach (var existente in productos)
        {
            if (existente.ID == producto.ID)
            {
                return false;
            }
        }

        productos.Add(producto);

        return true;

    }
    
    internal void Buscar_Producto()
    {
        buscador.Buscar_Articulo();
    }

    internal void Mostrar_Inventario()
    {
        mostrarProductos.Mostrar_Inventario();
    }
}