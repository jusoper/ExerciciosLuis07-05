using Exercicios07_05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

public class Program
{
    static void Main(string[] args)
    {
        var chamadaBancoDados = new BancoAcoes();
        while (true)
        {
            Console.WriteLine("Digite as informacoes do funcionario");
            var funcionario = new Funcionario();
            Console.WriteLine("Digite nome do funcionario");
            funcionario.Nome = Console.Read().ToString();
            chamadaBancoDados.InserirRegistro(funcionario);
            var listaFuncionario = chamadaBancoDados.ListarFuncionario();


        }


        
        



        //List<string> Funcionarios = new List<string>();
        //Funcionarios.Add("Pascoal");
        //Funcionarios.Add("Julia");
        //Funcionarios.Add("Kaique");

        //foreach (string s in Funcionarios)
        //{
        //    Console.WriteLine(s);
        //}



        Console.ReadKey();
    }
}

/* A empresa MaxAlteirTesla possui 40.000 funcionários. 
A empresa sofre com problemas de controle de seus funcionários
O setor de RH não consegue ter controle do estado de seus funcionários.
Exemplo: quantidade de funcionários por setor.
Média de salário de cada setor.
Registro de tempo por setor.
Cadastro de funcionário por setor.
Listagem de funcionários por setor.
*/

