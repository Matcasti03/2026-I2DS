internal class Program
{
    private static void Main(string[] args)
    {
      //Classe -> É a abstracao de um objeyo do mundo real para o mundo computacional,
      //objeto -> É a instancia de uma classe.

//Instanciar um projeto do tipo aluno
Aluno aluno01 = new Aluno();
Aluno aluno02 = new Aluno();

aluno01.Nome = "Matheus Castilho";
aluno01.RM = 2444;
aluno01.DataNascimento = new DateOnly(2010,01,15);

aluno02.Nome = "João dos Santos";
aluno02.RM = 1234;
aluno02.DataNascimento = new DateOnly(1006,12,07);

//Executar metodos
aluno01.ApresentarSE();
aluno02.ApresentarSE();

    }

    //Delcaracao de uma classe
        public class Aluno //Declaracao de uma classe
    {
        //Atributos -> Caracteristicas
        public string Nome { get; set; }
        public int RM {get; set;}
        public DateOnly DataNascimento {get; set;}

        //Metodos -> Acoes ou funcionalidades
        public void ApresentarSE()
        {
            Console.WriteLine($"Meu nome é {Nome}, Meu RM é {RM} e nasci no dia {DataNascimento}");
        }
    } 
}