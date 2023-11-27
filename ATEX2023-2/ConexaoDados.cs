using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATEX2023_2
{
    internal class ConexaoDados
    {
        private SqlConnection conn = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();

        public void Conectar()
        {
            string aux = "Server = Giovani\\SQLEXPRESS; Database = Atex; UID = sa; PWD = 123";
            conn.ConnectionString = aux;
            conn.Open();
        }

        public void Desconectar()
        {
            conn.Close();
        }

        public void Executar(string sql)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            Desconectar();
        }

        public (List<string>, List<string>, List<int>) loadIMG(string sql)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<string> caminhos = new List<string>();
            List<string> nomes = new List<string>();
            List<int> ids = new List<int>();
            while (dr.Read())
            {
                caminhos.Add(dr.GetString(0));
                nomes.Add(dr.GetString(1));
                ids.Add(dr.GetInt32(2));
            }
            Desconectar();
            return (caminhos, nomes, ids);
        }

        public List<string> LoadPerguntas(string sql)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<string> descricao = new List<string>();
            while (dr.Read())
            {
                descricao.Add(dr.GetString(0));
            }
            Desconectar();
            return descricao;
        }

        public void CriaJogo(List<string> dados)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("CriaApp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Nome", dados[0]));
            cmd.Parameters.Add(new SqlParameter("@CaminhoImagem", dados[1]));
            cmd.Parameters.Add(new SqlParameter("@perDesc1", dados[2]));
            cmd.Parameters.Add(new SqlParameter("@perDesc2", dados[3]));
            cmd.Parameters.Add(new SqlParameter("@perDesc3", dados[4]));
            cmd.Parameters.Add(new SqlParameter("@perDesc4", dados[5]));
            cmd.Parameters.Add(new SqlParameter("@opDesc1", dados[6]));
            cmd.Parameters.Add(new SqlParameter("@opDesc2", dados[7]));
            cmd.Parameters.Add(new SqlParameter("@opDesc3", dados[8]));
            cmd.Parameters.Add(new SqlParameter("@opDesc4", dados[9]));
            cmd.Parameters.Add(new SqlParameter("@opDesc5", dados[10]));
            cmd.Parameters.Add(new SqlParameter("@opDesc6", dados[11]));
            cmd.ExecuteNonQuery();
            Desconectar();
        }

        public void CriaRede(List<string> dados)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("CriaRede", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Nome", dados[0]));
            cmd.Parameters.Add(new SqlParameter("@CaminhoImagem", dados[1]));
            cmd.Parameters.Add(new SqlParameter("@perDesc1", dados[2]));
            cmd.Parameters.Add(new SqlParameter("@perDesc2", dados[3]));
            cmd.Parameters.Add(new SqlParameter("@perDesc3", dados[4]));
            cmd.Parameters.Add(new SqlParameter("@perDesc4", dados[5]));
            cmd.Parameters.Add(new SqlParameter("@opDesc1", dados[6]));
            cmd.Parameters.Add(new SqlParameter("@opDesc2", dados[7]));
            cmd.Parameters.Add(new SqlParameter("@opDesc3", dados[8]));
            cmd.ExecuteNonQuery();
            Desconectar();
        }
    }
}

