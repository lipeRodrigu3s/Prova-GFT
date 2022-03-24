using System;

namespace PrimeiraQuestao
{
    class Program
    {
        static void Main()
        {
            int senha;
            
            Console.WriteLine("Digite a Senha");
            senha = int.Parse(Console.ReadLine());

            while(senha != 2018)
            {
                Console.WriteLine("Senha invalida, digite novamente");
                senha = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("Acesso Garantido");    
            
        }
    }
}