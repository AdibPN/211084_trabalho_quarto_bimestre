using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211084_trabalho_quarto_bimestre.Models
{
    internal class Produto
    {
        public int Id { get; set; }
        public string descricao { get; set; }
        public int idCategoria { get; set; }
        public string nome { get; set; }
        public int idMarca { get; set; }
        public string estoque { get; set; }
        public string valorVenda { get; set; }
        public string foto { get; set; }



        public void Incluir()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand
                    ("INSERT INTO Produto (nome, descricao, idCategoria, idMarca, estoque, valorVenda, foto)" +
                    "VALUES (@nome, @descricao, @idCategoria, @idMarca, @estoque, @valorVenda, @foto)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome", nome);
                Banco.Comando.Parameters.AddWithValue("@descricao", descricao);
                Banco.Comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                Banco.Comando.Parameters.AddWithValue("@idMarca", idMarca);
                Banco.Comando.Parameters.AddWithValue("@estoque", estoque);
                Banco.Comando.Parameters.AddWithValue("@valorVenda", valorVenda);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void Alterar()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand
                    ("UPDATE Produto SET nome = @nome, descricao = @descricao, idCategoria = @idCategoria, idMarca = @idMarca, estoque = @estoque, valorVenda = @valorVenda, foto = @foto", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome", nome);
                Banco.Comando.Parameters.AddWithValue("@descricao", descricao);
                Banco.Comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                Banco.Comando.Parameters.AddWithValue("@idMarca", idMarca);
                Banco.Comando.Parameters.AddWithValue("@estoque", estoque);
                Banco.Comando.Parameters.AddWithValue("@valorVenda", valorVenda);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void excluir()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand("delete from Produto where Id = @Id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@Id", Id);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable Consultar()
        {
            try
            {
                Banco.Comando = new MySqlCommand("SELECT p.*, m.marca, c.categoria FROM " +
                    "Produtos p inner join Marcas m on (m.id = p.idCategoria)" +
                    "where p.descricao like @descricao order by p.descricao", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@descricao", descricao + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.dataTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.dataTabela);
                return Banco.dataTabela;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
