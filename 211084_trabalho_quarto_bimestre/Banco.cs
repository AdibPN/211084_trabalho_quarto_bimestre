using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _211084_trabalho_quarto_bimestre
{
    public class Banco
    {
        //criação de variáveis publicas para conexão e consultas que serão usadas em todos os projetos
        //responsavel pela conexão
        public static MySqlConnection Conexao;
        //responsável pela instrução que será dada ao SQL e serem conectadas
        public static MySqlCommand Comando;
        //Adapter responsável por inserir dados em um dataTable
        public static MySqlDataAdapter Adaptador;
        //DAtaTable responsavel por ligar o banco em controles com propriedades DataSource
        public static DataTable dataTabela;
        public static void AbrirConexao()
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");

                Conexao.Open();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void FecharConexao()
        {
            try
            {
                Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CriarBanco()
        {
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vendas; USE vendas", Conexao);
                Comando.ExecuteNonQuery();
                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Cidades" +
                    "(id integer auto_increment primary key," +
                    "nome varchar(40)," +
                    "uf char (02))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Marcas " +
                    "(id integer auto_increment primary key, " +
                    "nome varchar(20))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Categorias " +
                    "(id integer auto_increment primary key, " +
                    "categoria char(20))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Clientes " +
                    "(Id integer auto_increment primary key, " +
                    "nome varchar(40), " +
                    "idCidade integer, " + 
                    "dataNasc date, " +
                    "renda decimal(10,2), " +
                    "cpf char(14), " +
                    "foto varchar(100), " +
                    "venda boolean)", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Produto " + 
                    "(Id integer auto_increment primary key, " +
                    "descricao char(40), " +
                    "idCategoria integer, " + 
                    "idMarca integer, " + 
                    "estoque decimal(10,3), " +
                    "valorVenda decimal(10,2), " +
                    "foto varchar(100))", Conexao);
                Comando.ExecuteNonQuery();

                FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }

}
