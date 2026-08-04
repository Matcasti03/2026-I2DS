using System.ComponentModel;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
      /* Sintaxe enquanto uma condicao for verdadeira execute um conjunto de comandos 
      for - > Quando sabemos a quantidade de repeticoes
      while -> quando a repeticao depende de uma condicao
      do.. while -> quando precisa executar ao menos uma vez o bloco de codigo
      */
/*
laco for: Imprimir numeros de 01 até 10
*/

         Console.WriteLine("Imprimindo os numeros de 1 a 10 utilizando o laco for");
        for (int numero = 1; numero <= 10; numero++)
        {
            Console.WriteLine(numero);
        }
                 Console.WriteLine("Contagem regressiva de 10 até 0 ");
        for (int numero = 10; numero >= 0; numero--)
        {
            Console.WriteLine(numero);
        }


        /*****************************************/

        Console.WriteLine("Imprimir numeros de 1 ate 10 utilizando o laco while");

        int contador = 1;
        while (contador <= 10)

        {
            Console.WriteLine(contador);
            contador++;
        }




        // Solicitar senha até acertar
         string senha = "";
         while(senha != "2444")
        {
            Console.WriteLine("Digite a senha ");

            senha = Console.ReadLine();
        }
        Console.WriteLine("Acesso permitido!");

/************************************************************/
int num;
do
        {
            Console.Write("Digite um numero positivo: ");
            num = int.Parse(Console.ReadLine());

        }while(num <=0);

    }
}
