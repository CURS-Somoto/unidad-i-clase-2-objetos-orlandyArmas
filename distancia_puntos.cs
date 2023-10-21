using System;

class Punto
{
    public decimal x { get; set; }
    public decimal y { get; set; }

    public Punto(decimal x, decimal y)
    {
        this.x = x;
        this.y = y;
    }

    public double MedirDistancia(Punto puntoDestino)
    {
        double distancia = Math.Sqrt(Math.Pow((double)(puntoDestino.x - this.x), 2) + Math.Pow((double)(puntoDestino.y - this.y), 2));
        return distancia;
    }
}

class Program
{
    static void Main()
    {
        Punto puntoOrigen = new Punto(120M, 30M);
        Punto puntoDestino = new Punto(72M, 80M);

        double distancia = puntoOrigen.MedirDistancia(puntoDestino);

        Console.WriteLine($"La distancia entre dos puntos es: {distancia}");
    }
}
