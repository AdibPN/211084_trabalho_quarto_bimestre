using _211084_trabalho_quarto_bimestre.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211084_trabalho_quarto_bimestre.Views
{
    public partial class FrmProdutos : Form
    {

        Produto p;
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {

        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (nome.Text == String.Empty) return;

            p = new Produto()
            {
                
                nome = nome.Text,
                idCategoria = (int)cboCategoria.SelectedValue,
                idMarca = (int)cboMarca.SelectedValue,
                valorVenda = txtVenda.Text,
                estoque = txtEstoque.Text,
                foto = picFoto.ImageLocation,
                
            };
            p.Incluir();

            limpaControles();
            carregarGrid("");
        }

        void limpaControles()
        {
            txtId.Clear();
            nome.Clear();
            cboCategoria.SelectedIndex = -1;
            cboMarca.SelectedIndex = -1;
            txtVenda.Clear();
            txtEstoque.Clear();
            picFoto.ImageLocation = "";
            
        }

        

        void carregarGrid(string pesquisa)
        {
            p = new Produto()
            {

                nome = pesquisa

            };
            dgv_produto.DataSource = p.Consultar();
        }




        private void btn_alterar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;


            if (MessageBox.Show("deseja excluir o produto?", "exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                p = new Produto()
                {
                    Id = int.Parse(txtId.Text)

                };
                p.excluir();

                limpaControles();
                carregarGrid("");
            }
        }

        

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();


        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }

        private void dgv_produto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_produto.RowCount > 0)
            {

                txtId.Text = dgv_produto.CurrentRow.Cells["id"].Value.ToString();
                nome.Text = dgv_produto.CurrentRow.Cells["nome"].Value.ToString();
                cboCategoria.Text = dgv_produto.CurrentRow.Cells["categoria"].Value.ToString();
                cboMarca.Text = dgv_produto.CurrentRow.Cells["marca"].Value.ToString();
                picFoto.ImageLocation = dgv_produto.CurrentRow.Cells["foto"].Value.ToString();
                descricao.Text = dgv_produto.CurrentRow.Cells["descricao"].Value.ToString();
                txtVenda.Text = dgv_produto.CurrentRow.Cells["venda"].Value.ToString();
                txtEstoque.Text = dgv_produto.CurrentRow.Cells["estoque"].Value.ToString();

            }
        }
    }
}
