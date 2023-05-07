using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios07_05
{
    public  class BancoAcoes
    {
        public bool InserirRegistro(Funcionario pessoa)
        {
            var sql = new SqlConnection();
            sql.ConnectionString = "";
            sql.Open();

            var sqlCommand = new SqlCommand();
            sqlCommand.Connection = sql;
            sqlCommand.Parameters.AddWithValue("@nome", pessoa.Nome);
            sqlCommand.Parameters.AddWithValue("@idade", pessoa.Idade);
            sqlCommand.Parameters.AddWithValue("@Sexo", pessoa.Sexo);

            sqlCommand.CommandText = "Insert into pessoa(nome,idade,sexo)values(@nome,@idade,@sexo)";

            var resultado = sqlCommand.ExecuteNonQuery();
            if (resultado == 1)
            {
                return true;
            }
            return false;

        }

        public List<Funcionario> ListarFuncionario()
        {
            var list = new List<Funcionario>();
            var sql = new SqlConnection();
            sql.ConnectionString = "";
            sql.Open();

            var sqlCommand = new SqlCommand();
            sqlCommand.Connection = sql;
            

            sqlCommand.CommandText = "select Nome,Idade,Sexo from Tbl_Pessoa" ;

            var reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
              var funcionario = new Funcionario();
              funcionario.Nome = reader["Nome"].ToString();
              funcionario.Idade = reader["Idade"].ToString();
              funcionario.Sexo = reader["Sexo"].ToString();

              list.Add(funcionario);

            }

            return list;
        }
    }

    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Idade { get; set; }
    }
}
