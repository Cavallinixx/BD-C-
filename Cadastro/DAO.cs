using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Cadastro
{
     class DAO
    {
        public MySqlConnection Conexão;//Conectar ao banco de dados
        public string dados;
        public string sql;
        public string resultado;
        public DAO()
        {
            Conexão = new MySqlConnection("server=localhost;DataBase=ti18nPessoa;Uid=root;Password=");
            try
            {
                Conexão.Open();//Abrindo a conexão com BD
                Console.WriteLine("Conectando com sucesso!");
            }
            catch (Exception erro)
            {
                Console.WriteLine("Algo deu errado!! Verifique os dados de conexão!\n\n " + erro);
                Conexão.Close();//Fechar a conexão com BD
            }//fim do try catch
        }//fim do método
        
        //Metodo Inserir
        public void Inserir(string nome,string telefone, string cidade, string endereco) 
        {
            try
            {
                dados = "('','" + nome + "','" + telefone + "','" + cidade + "','" + endereco + "',)";
                sql = "insert into pessoa(codigo,nome,telefone,cidade,endereco) values" + dados;

                MySqlCommand conn = new MySqlCommand(sql, Conexão);//prepara a conexão no banco
                resultado = "" + conn.ExecuteNonQuery();//Ctrl + Enter -> Executando o comando no BD
                Console.WriteLine(resultado + "Linha afetada");
            }
            catch(Exception erro)
 
            {
                Console.WriteLine("Erro!!! Algo deu errado!\n\n\n " + erro);
            }
        }//fim do metodo inserir 

    }//fim da classe
}//fim do projto 
