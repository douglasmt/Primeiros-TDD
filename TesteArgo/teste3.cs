using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo
{
    public class teste3
    {
        /// <summary>
        /// ex: nome = joao da silva pereira, retorno = Joao da Silva Pereira
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public string NomesComPrimeirasLetrasMaiusculas(string nome)
        {
            string strResult = "";
            bool booPrimeira = true;

            if (nome.Length > 0)
            {
                int tamPalavra = 0;
                for (int intCont = 0; intCont <= nome.Length - 1; intCont++)
                {
                    
                    if ((booPrimeira) && (!nome.Substring(intCont, 1).Equals(" ")))
                    {
                        Console.WriteLine(nome.Substring(intCont, 3));
                        if (!nome.Substring(intCont, 3).Equals("da "))
                        {
                            strResult += nome.Substring(intCont, 1).ToUpper();
                            booPrimeira = false;
                            
                            tamPalavra += 1;
                        }
                        else
                        {
                            strResult += nome.Substring(intCont, 1).ToLower();
                            booPrimeira = false;
                        }
                        Console.WriteLine("Char 1º " + intCont + " - " + strResult + " pron: " + tamPalavra);

                    }
                    else
                    {
                        strResult += nome.Substring(intCont, 1).ToLower();

                        if (nome.Substring(intCont, 1).Equals(" "))
                        {
                            if (tamPalavra == 3)
                            {
                                Console.WriteLine("Resultado " + strResult[intCont-2]);
                                //strResult[intCont - 2] = "d";
                            }
                            tamPalavra = 0;
                            booPrimeira = true;                            
                        }
                        tamPalavra += 1;
                        
                        Console.WriteLine("Char 1º " + intCont + " - " + strResult + " pron: " + tamPalavra);
                    }
                }
            }

            Console.WriteLine(strResult);
            return strResult;

        }



        /// <summary>
        /// ex: nome = cleber reis pereira, retorno = Cleber Pereira
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public string RemoverNomeDoMeio(string nome)
        {
            nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
            Console.Write("\n Nome antes: " + nome);
            string firstWord = nome.Split(' ').First();
            string lastWord = nome.Split(' ').Last();
            string newWord = firstWord + ' ' + lastWord;
            Console.Write("\n Nome depois: " + newWord);
            return newWord;
        }

    }
}
