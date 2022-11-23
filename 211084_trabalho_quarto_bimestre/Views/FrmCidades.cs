using _211084_trabalho_quarto_bimestre.Models;
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
    public partial class FrmCidades : Form
    {
        Cidade C;
        public FrmCidades()
        {
            InitializeComponent();
            carregarGrid("");
        }
           

        void LimpaControles()
            {
                
                txtNome.Clear();
                txtUF.Clear();
                txtPesquisa.Clear();
            }

            void carregarGrid(string pesquisa)
            {
                C = new Cidade()
                {
                    Nome = pesquisa
                };
                dgvCidades.DataSource = C.Consultar();

            }

            public void FrmCidades_Load(object sender, EventArgs e)
            {
                LimpaControles();
                carregarGrid("");
            }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty) return;

            C = new Cidade()
            {
                Nome = txtNome.Text,
                Uf = txtUF.Text
            };

            C.Incluir();

            LimpaControles();
            carregarGrid("");


        }

        private void DgvCidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCidades.RowCount > 0)
            {
                
                txtNome.Text = dgvCidades.CurrentRow.Cells["nome"].Value.ToString();
                txtUF.Text = dgvCidades.CurrentRow.Cells["uf"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string a;
            if (dgvCidades.Rows.Count <= 1) return;
            a = dgvCidades.CurrentRow.Cells[0].Value.ToString();

            if (a == "") return;

            if (MessageBox.Show("Deseja alterar o cadastro?", "alterar", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                C = new Cidade()
                {
                    Id = int.Parse(a),
                    Nome = txtNome.Text,
                    Uf = txtUF.Text
                };

                C.Alterar();

                LimpaControles();
                carregarGrid("");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string a;
            if (dgvCidades.Rows.Count <= 1) return;

            a = dgvCidades.CurrentRow.Cells[0].Value.ToString();

            if (a == "") return;

            if (MessageBox.Show("Deseja excluir o cadastro?", "Exclusão", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                C = new Cidade()
                {
                    Id = int.Parse(a)
                };

                C.Excluir();

                LimpaControles();
                carregarGrid("");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaControles();
            carregarGrid("");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
