public class Producto{
    private int id;
    private string nombre;
    private double precio;
    private int stock;

    public double Precio{
        get { return precio; }
        set {
            if (value < 0)
                throw new InvalidOperationException("El precio debe ser no Negativo.");
            precio = value; 
        }
    }
    public int Stock{
        get { return stock; }
        set {
            if (value < 0)
                throw new InvalidOperationException("El valor del Stock debe ser no Negativo.");
            stock = value; 
        }
    }

    public void DescontarStock(int cantidad){
        if(cantidad <= stock){
            stock -= cantidad;
            Console.WriteLine("Se descontó la cantidad del Stock exitosamente.");
        }else{
            Console.WriteLine("Intentó descontar una cantidad mayor que el Stock dispnible.");
        }
    }

}