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
    public partial class FormMarca : Form
    {
        Marca m;
        public FormMarca()
        {
            InitializeComponent();
            carregarGrid("");
        }

        void limpaControles()
        {
            txtNome.Clear();
            txtPesquisa.Clear();
        }

        void carregarGrid(string pesquisa)
        {
            m = new Marca()
            {
                Nome = pesquisa
            };
            dgv_marcas.DataSource = m.Consultar();
        }

        private void FormMarca_Load(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_alterar_Click_1(object sender, EventArgs e)
        {
            string a;
            if (dgv_marcas.SelectedRows.Count == 0) return;

            a = dgv_marcas.CurrentRow.Cells[0].Value.ToString();

            if (a == "") return;

            if (MessageBox.Show("Deseja alterar o cadastro?", "alterar", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m = new Marca()
                {
                    Id = int.Parse(a),
                    Nome = txtNome.Text
                };

                m.Alterar();

                limpaControles();
                carregarGrid("");
            }
        }

        private void btn_iniciar_Click_1(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty) return;
            m = new Marca()
            {
                Nome = txtNome.Text,
            };
            m.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btn_excluir_Click_1(object sender, EventArgs e)
        {
            string a;
            if (dgv_marcas.Rows.Count == 1) return;

            a = dgv_marcas.CurrentRow.Cells[0].Value.ToString();

            if (a == "") return;

            if (MessageBox.Show("Deseja excluir o cadastro?", "Exclusão", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m = new Marca()
                {
                    Id = int.Parse(a)
                };

                m.Excluir();

                limpaControles();
                carregarGrid("");
            }
        }

        private void btn_fechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_pesquisar_Click_1(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }

        private void selecionarLinha(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_marcas.RowCount > 0)
            {
                txtNome.Text = dgv_marcas.CurrentRow.Cells["nome"].Value.ToString();
            }
        }
    }
}

