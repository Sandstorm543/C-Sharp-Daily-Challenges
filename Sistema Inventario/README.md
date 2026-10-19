# Sistema de inventario

Este proyecto es una aplicación de consola para registrar productos, mostrar los productos registrados y buscar un producto por su ID. Las responsabilidades están separadas entre el punto de entrada, el menú, el inventario y las operaciones relacionadas con cada producto.

## Estructura y responsabilidades

- **`Main/Program.cs`**: crea el menú principal y llama a `Mostrar_Menu()` para iniciar la aplicación.
- **`Menu_Principal/Menu_Principal.cs`**: presenta las opciones, valida la opción elegida y coordina las acciones. Mantiene una única instancia de `Inventario` durante la ejecución del menú.
- **`Producto/Producto.cs`**: representa un producto con ID, nombre, precio y cantidad disponible. `Registrar_Producto()` solicita y valida esos datos.
- **`Producto/Inventario.cs`**: mantiene la lista de productos. `AgregarProducto()` impide registrar IDs duplicados; `Mostrar_inventario()` muestra los productos; y `Buscar_Producto()` delega la búsqueda al buscador.
- **`Producto/Buscar_Producto.cs`**: recibe la lista del inventario y busca en ella por ID, mostrando los datos del producto encontrado o un mensaje si no existe.

## Flujo general

1. `Program.cs` crea `Menu_Principal`.
2. El menú crea una sola instancia de `Inventario` y la reutiliza en sus opciones.
3. Al registrar un producto, el menú crea un `Producto`, solicita sus datos y pide al inventario que lo agregue.
4. Al mostrar o buscar productos, el menú llama a los métodos de esa misma instancia de `Inventario`.
5. `Inventario` crea una instancia de `Buscar_Producto` y le pasa su lista `productos`. El buscador guarda una referencia a esa misma lista, no una copia, por lo que puede consultar los productos que el inventario agrega.

## Por qué se usan `readonly` e `IReadOnlyList`

En `Inventario`, `readonly` impide reemplazar la lista después de inicializarla, pero permite agregarle productos. En `Buscar_Producto`, el campo también es `readonly` para que no se reasigne a otra colección; su tipo `IReadOnlyList<Producto>` indica que el buscador solo necesita leer y recorrer los elementos, no agregarlos o quitarlos.

La aplicación trabaja en memoria: los productos registrados se conservan mientras el programa está en ejecución y no se guardan en un archivo o base de datos.
