using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo
{
    public class teste2
    {
        public List<int> CriarLista(int quantidade)
        {
            List<int> lista = new List<int>();

            int quant = 0;
            for (int i = 0; i < quantidade; i++)
            {
                lista.Add(i + 1);
                Console.Write("\n  - " + i);
                quant += i;
            }


            return lista;
        }

        public List<int> OrdenarLista(params int[] valores)
        {
            var nameList = new List<int>();
            nameList.AddRange(valores);
            Console.WriteLine("List in unsorted order: ");
            foreach (var numero in nameList)
                Console.Write("   {0}", numero);
            nameList.Sort();
            foreach (var numero in nameList)
                Console.Write("   {0}", numero);


            return nameList;
        }
    }
}
