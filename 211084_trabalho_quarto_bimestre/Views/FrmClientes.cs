using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _211084_trabalho_quarto_bimestre.Models;

namespace _211084_trabalho_quarto_bimestre.Views
{
    public partial class FrmClientes : Form
    {

        Cidade ci;
        Clientes cl;
        public FrmClientes()
        {
            InitializeComponent();
            carregarGrid("");
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (nome.Text == String.Empty) return;

            cl = new Clientes()
            {
                nome = nome.Text,
                idCidade = (int)cboCidades.SelectedValue,
                dataNasc = dataNasc.Value,
                renda = double.Parse(renda.Text),
                cpf = mskCPF.Text,
                foto = picFoto.ImageLocation,
                venda = chkVenda.Checked,
            };
            cl.Incluir();

            limpaControles();
            carregarGrid("");
        }

        void limpaControles()
        {
            txtId.Clear();
            txtNome.Clear();
            cboCidades.SelectedIndex = -1;
            txtUF.Clear();
            mskCPF.Clear();
            renda.Clear();
            dataNasc.Value = DateTime.Now;
            picFoto.ImageLocation = "";
            chkVenda.Checked = false;
        }

        void carregarGrid(string pesquisa)
        {
            cl = new Clientes()
            {

                nome = pesquisa

            };
            dgv_clientes.DataSource = cl.Consultar();   
        }
        

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ci = new Cidade();
            cboCidades.DataSource = ci.Consultar();
            cboCidades.DisplayMember = "nome";
            cboCidades.ValueMember = "id";


            limpaControles();
            carregarGrid("");


            dgv_clientes.Columns["idCidade"].Visible = false;
            dgv_clientes.Columns["foto"].Visible = false;
        }

        private void cboCides_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_clientes.RowCount > 0)
            {

                txtId.Text = dgv_clientes.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = dgv_clientes.CurrentRow.Cells["nome"].Value.ToString();
                cboCidades.Text = dgv_clientes.CurrentRow.Cells["cidade"].Value.ToString();
                txtUF.Text = dgv_clientes.CurrentRow.Cells["uf"].Value.ToString();
                chkVenda.Checked = (bool)dgv_clientes.CurrentRow.Cells["venda"].Value;
                mskCPF.Text = dgv_clientes.CurrentRow.Cells["cpf"].Value.ToString();
                dataNasc.Text = dgv_clientes.CurrentRow.Cells["DataNasc"].Value.ToString();
                renda.Text = dgv_clientes.CurrentRow.Cells["renda"].Value.ToString();
                picFoto.ImageLocation = dgv_clientes.CurrentRow.Cells["foto"].Value.ToString();
            }
        }

        


        private void btn_alterar_Click(object sender, EventArgs e)
        {
            string a;
            
            if (dgv_clientes.Rows.Count <= 1) return;
            a = dgv_clientes.CurrentRow.Cells[0].Value.ToString();

            if (a == "") return;

            if (MessageBox.Show("Deseja alterar o cadastro?", "alterar", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)

            {
                cl = new Clientes()
                {
                    Id = int.Parse(a),
                    nome = txtNome.Text,
                    idCidade = (int)cboCidades.SelectedValue,
                    dataNasc = dataNasc.Value,
                    renda = double.Parse(renda.Text),
                    cpf = mskCPF.Text,
                    foto = picFoto.ImageLocation,
                    venda = chkVenda.Checked

                };

                cl.Alterar();

                limpaControles();
                carregarGrid("");
            }

            

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;


            if (MessageBox.Show("deseja excluir o cliente?", "exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                cl = new Clientes()
                {
                    Id = int.Parse(txtId.Text)

                };
                cl.excluir();

                limpaControles();
                carregarGrid("");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            limpaControles();
            carregarGrid("");
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text); 
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void renda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUF_TextChanged(object sender, EventArgs e)
        {

        }

        private void picFoto_Click_1(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "D:/fotos/clientes/";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picFoto.ImageLocation = ofdArquivo.FileName;
        }
    }


}
