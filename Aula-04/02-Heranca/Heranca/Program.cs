using System.Dynamic;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //Heranca: uma sub classe ou conhecida tambem como classe filha, recebe os atributos e metodos da super classe
        animal animal1 = new animal();
        Cachorro dog1 = new Cachorro();

        animal1.Nome = "Ferdinando";
        animal1.Idade = 2;
        Console.WriteLine($"Nome do animal: {animal1.Nome}  -  Idade {animal1.Idade}");

        dog1.Nome = "Snoop";
        dog1.Idade = 5;
        dog1.Raca = "Vira-Lata";
        dog1.Latir();

        Console.WriteLine($"Nome:  {dog1.Nome}  |  Idade:  {dog1.Idade}  |  Raça:  {dog1.Raca}");
    }
    //Super classe animal (MÃE)

public class animal 
{
public string Nome {get; set;}
public int Idade {get; set;}
}

//Sub Claasse (Filha)

public class Cachorro : animal
    {
        public string Raca {get; set;}
        public void Latir()
        {
            Console.WriteLine("Au Au");

        }
    }
}