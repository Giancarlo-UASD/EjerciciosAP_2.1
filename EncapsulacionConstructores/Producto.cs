public class Producto{
    private int id;
    private string nombre;
    private double precio;
    private int stock;

    public double precio{
        get { return precio; }
        set {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException();
            precio = value; 
        }
    }
    public int stock{
        get { return stock; }
        set {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException();
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