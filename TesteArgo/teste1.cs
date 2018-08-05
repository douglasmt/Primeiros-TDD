using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo
{
    public class teste1
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
            for (int i = 0; i < valores.Length; i++)
            {
                quant = i + 1;
                Console.Write("\n " + quant + " - " + valores[i] + " =  " + soma + "\n ");

                soma += valores[i];

            }
            int media = soma / quant;
            Console.Write("\n--- \nA média é " + media + "\n");
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

        public int Maior(params int[] valores)
        {
            int maior = 0;
            for (int i = 0; i < valores.Length; i++)
            {

                if ((i != 0))
                {
                    if (valores[i] > maior)
                    {
                        maior = valores[i];
                    }
                }

            }
            Console.Write("\n--- \nO maior é " + maior + "\n");
            return maior;
        }

                

    }
    public class Multiplicador
    {
        private int _resultado = 1;
        public void Multiplicar(int number)
        {
            _resultado *= number;
        }
        public int Resultado()
        {
            int retorno = _resultado;
            _resultado = 1;
            return retorno;
        }
    }
}
