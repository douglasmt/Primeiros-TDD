using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;
using System.Net.NetworkInformation;
using System.Data.SqlClient;
using System.Data;

namespace TesteArgo
{
    /// <summary>
    /// Nessa classe deve ser feito o acesso a banco de dados
    /// Dados de conexao do banco de dados
    /// host: den1.mssql6.gear.host
    /// base: testecore
    /// user:testecore
    /// senha : Dz2iI~!U1Edq
    /// 
    /// Tabela Destino
    /// 
    /// Colunas:
    /// DestinoId inteiro 
    /// Nome texto nulavel
    /// Dia data nulavel
    /// 
    /// </summary>
    public class teste5
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public List<object> ListarDestino()
        {
            List<object> results = new List<object>();
            SqlConnection conn = new SqlConnection("Data Source = den1.mssql6.gear.host; Initial Catalog = testecore; User Id = testecore; Password = Dz2iI~!U1Edq;");
            
            using (SqlCommand command = new SqlCommand())
            {
                conn.Open();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "Select DestinoId, Nome, Dia from Destino";
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        results.Add(dr["DestinoId"].ToString());
                        //Console.Write("dr[DestinoId].ToString()" + dr["DestinoId"].ToString());
                    }
                }
                conn.Close();
            }

            Console.Write("\n results: " + results);

            return results;
        }

        public object buscarPorId(int id)
        {
            List<object> results = new List<object>();
            SqlConnection conn = new SqlConnection("Data Source = den1.mssql6.gear.host; Initial Catalog = testecore; User Id = testecore; Password = Dz2iI~!U1Edq;");

            using (SqlCommand command = new SqlCommand())
            {
                conn.Open();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "Select DestinoId, Nome, Dia from Destino where DestinoId = " + id;
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        results.Add(dr["DestinoId"].ToString());
                        //Console.Write("dr[DestinoId].ToString()" + dr["DestinoId"].ToString());
                    }
                }
                conn.Close();
            }

            Console.Write("\n results: " + results);

            return results;
        }
    }
}
