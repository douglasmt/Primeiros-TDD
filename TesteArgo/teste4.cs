using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TesteArgo
{
    public class teste4
    {
        ///www.omdbapi.com/
        const string ApiKey = "de1dcecb";//i=tt3896198&apikey=de1dcecb
        //private object JsonConvert;

        /// <summary>
        /// By Search
        /// www.omdbapi.com/?s=titulo&apikey=de1dcecb
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public List<Filme> ListarFilmes(string filtro)
        {
            //listar cósigo
            List<Filme> ResultFilm = new List<Filme>();

            using (WebClient webClient = new System.Net.WebClient())
            {
                var json = 
                    webClient.DownloadString("http://www.omdbapi.com/?s=" 
                    + filtro + "&apikey=" + ApiKey );
                JToken search = JObject.Parse(json).GetValue("Search");

                Console.Write("\n0 ----------\n  json: \n" + json);
                Console.Write("\n1 ----------\n  search: \n" + search);

                ResultFilm = search.Select(f => f.ToObject<Filme>()).ToList();
            }

            return ResultFilm;
            //return null;
        }

        /// <summary>
        /// By ID or Title
        /// www.omdbapi.com/?i=tt0096895&apikey=18693fd6
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Filme ListarPorId(string id)
        {
            //listar cósigo
            Filme ResultFilm = new Filme();
            List<Filme> ResultFilmLista = new List<Filme>();

            using (WebClient webClient = new System.Net.WebClient())
            {
                var json =
                    webClient.DownloadString("http://www.omdbapi.com/?i="
                    + id + "&apikey=" + ApiKey);

                JToken search = JObject.Parse(json).GetValue("Title");
                Console.Write("\n2 ----------\n  search: " + search);

                ResultFilm.Titulo = search.ToString();
                
                Console.Write("\n2 ----------\n  ResultFilm: " + ResultFilm.Titulo);

            }            

            return ResultFilm;
        }
    }

    public class Filme
    {
        /// <summary>
        /// Title
        /// </summary>
        public string Titulo { get; set; }
        /// <summary>
        /// Year
        /// </summary>
        public int? Ano { get; set; }
        /// <summary>
        /// imdbID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Poster
        /// </summary>
        public string Imagem { get; set; }
    }
}
