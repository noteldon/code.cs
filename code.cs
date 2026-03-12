using System;

public class Procesador
{
    public string Marca{get; set;}
    public void MostrarMarca() => Console.WriteLine($"La marca es Adidas");
}

public class Computadora
{
    
    //composición
    private Procesador procesador;
    
    //constructor
    public Computadora()
    {
        procesador = new Procesador();
        procesador.Marca="AMD";
    }
    
    public void Encender()
    
    {
    Console.WriteLine("La computadora esta encendida");
    procesador.MostrarMarca();
    }
    
}

class Program
{
    static void Main()
    {
        Computadora PC = new Computadora();
        PC.Encender();
    }
}
