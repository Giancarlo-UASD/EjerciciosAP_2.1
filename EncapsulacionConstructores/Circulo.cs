public class Circulo{
    private double radio;

    public Circulo(){
        radio = 1.0;
    }
    public Circulo(double radio){
        if (radio <= 0)
            throw new InvalidOperationException("El radio debe ser Positivo.");
        this.radio = radio;
    }
    public double CalcularArea(){
        return Math.PI*radio*radio;
    }

    public double CalcularCircunferencia(){
        return Math.PI*2.0*radio;
    }
}