using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //comentario de linha
        /*comentario de blocooooooo


        varias linhas 
        */

        //imprimir uma linha de texto na tela
        Console.WriteLine("Programacao Orienta a Objetos\n");

        Console.WriteLine("Abstracao - 1° pilar da POO");
        
        //Criar uma classe em C#

//A classe deve ser declarada fora do bloco programa

//criar um objeto apartir de uma classe
    Pet pet1 = new Pet();
pet1.nome = "Totó";
pet1.tipo = "Cachorro";
pet1.idade = 3;


pet1.MostrarNome();

Pet pet2 = new Pet();
pet2.nome = "Mingau";
pet2.tipo = "gato";
pet2.idade = 8;


pet2.MostrarNome();

    }


public class Pet //Nome da classe sempre se inicia acom letras maiuscula

    {
        //declaracao dos atributos
public string nome;
public string tipo;
public int idade;

        //declaracao dos metodos
        public void MostrarNome()
        {
            Console.WriteLine("Meu nome é " + this.nome);
        }
    }
    
}