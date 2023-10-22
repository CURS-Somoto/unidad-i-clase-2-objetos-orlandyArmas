public class Guerreros 
{
    public int Vida { get; set; }
    public int NivelAtaque { get; set; }
    public static void Main()
    {
        Participante Jersan  = new Participante("Jersan");
        Participante Javier = new Participante("Javier");
        Enfrentamiento ataque = new Enfrentamiento (Jersan, Javier);
        Console.WriteLine($"{ataque.iniciar()}");
    }
}
public class Participante
{
    public string Nombre { get; set; }
    public Participante(string n)
    {
        Nombre = n;
    }

    public string ataque()
    {
        string[] opciones = new[] { "balazo en el corazon ", "balazo en el brazo", "balazo en la cabeza" };
        Random i = new Random();
        return opciones[i.Next(0, 3)];
    }

}
public class Enfrentamiento
{
    public string Ganador { get; set; }
    public Participante Guerrero1 { get; set; }
    public Participante Guerrero2 { get; set; }
    public Enfrentamiento (Participante G1, Participante G2)
    {
        Guerrero1 = G1;
        Guerrero2 = G2;
    }
    public string iniciar()
    {
        string Guer1 = Guerrero1.ataque();
        string Guer2 = Guerrero2.ataque();
        Console.WriteLine($"{Guerrero1.Nombre} dio un  {Guer1}");
        Console.WriteLine($"{Guerrero2.Nombre} dio un {Guer2}");
        if (Guer1 == Guer2)
        {
            Console.WriteLine(" los guerreros han tenido un empate");
        }
        else if ((Guer1 == "balazo en el corazon" && Guer2 == "balazo en el brazo") ||(Guer1 == "balazo en la cabeza" && Guer2 == "balazo en el brazo")||(Guer1 == "balazo en el corazon" && Guer2 == "balazo en la cabeza"))
        {   
            Console.WriteLine($"Gano {Guerrero1.Nombre}");;
             Ganador = Guerrero1.Nombre;
        }
        else 
        {
            Console.WriteLine($"Gano {Guerrero2.Nombre}");
            Ganador = Guerrero2.Nombre;
        }
         return Ganador;
    }        
}

