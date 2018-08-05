using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo
{
    public class teste6Doug
    {
        public int Somar(int n1, int n2)
        {
            int soma = n1 + n2;
            return soma;
        }

        public int Subtrair(int n1, int n2)
        {
            int subtrai = n1 - n2;

            return subtrai;
        }

        public decimal Media(params int[] valores)
        {
            int quant = 0;
            int soma = 0;
            int maior = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                quant = i + 1;
                Console.Write("\n " + quant + " - " + valores[i] + " =  " + soma + "\n ");
                if (valores[i] > valores[i - 1]){
                    maior = valores[i];
                }
                soma += valores[i];

            }
            int media = soma / quant;
            Console.Write("\n--- \nA média é " + media + "\n");
            Console.Write("\n--- \nO maior é " + maior + "\n");
            return media;
        }

        public int CalcularIdade(int ano, int mes, int dia)
        {
            var birthdate = new DateTime(ano, mes, dia);//recebido

            var today = DateTime.Today;//new DateTime(2018, 5, 19); data atual

            Console.Write("\nAno atual " + today.Year + "\n");
            
            Console.Write("\nAno de aniversário  " + birthdate.Year + "\n");
            var age = today.Year - birthdate.Year;
            /*if (birthdate > today.AddYears(-age))
            {
                age--;
            }*/

            if (birthdate.Month > today.Month)
                age--;
            

            Console.Write("\nIdade é " + age + "\n");
            return age;
        }
    }
}
