using System;

int opcion;

Console.WriteLine("Introduzca la clase que quiere probar:");
Console.WriteLine("1. Clase Producto.");
Console.WriteLine("2. Clase Círculo.");

opcion = int.Parse(Console.ReadLine());

if(opcion == 1){
    Producto producto = new Producto();
    Console.WriteLine("Introduzca el Precio: ");
    double precio = double.Parse(Console.ReadLine());
    Console.WriteLine("Introduzca el valor del Stock: ");
    int stock = int.Parse(Console.ReadLine());
    producto.Precio = precio;
    producto.Stock = stock;
    Console.WriteLine("El precio del producto es: " + producto.Precio);
    Console.WriteLine("El valor del Stock es: " + producto.Stock);
    Console.WriteLine("Introduzca a valor a descontar del Stock: ");
    int descuento = int.Parse(Console.ReadLine());
    producto.DescontarStock(descuento);
    Console.WriteLine("El valor del Stock es: " + producto.Stock);
}else if(opcion == 2){
    Console.WriteLine("Introduzca el radio del segundo círculo: ");
    double radio = double.Parse(Console.ReadLine());
    Circulo c1 = new Circulo();
    Circulo c2 = new Circulo(radio);
    Console.WriteLine("El área del círculo 1 es: " + c1.CalcularArea());
    Console.WriteLine("La circunferencia del círculo 1 es: " + c1.CalcularCircunferencia());
    Console.WriteLine("El área del círculo 2 es: " + c2.CalcularArea());
    Console.WriteLine("La circunferencia del círculo 2 es: " + c2.CalcularCircunferencia());
}else{
    Console.WriteLine("Introdujo una opción incorrecta.");
}
Console.WriteLine("Fin de ejecución.");