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
    public partial class FrmMarca : Form
    {
        public FrmMarca()
        {
            InitializeComponent();
        }

        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
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

     
            void limpaControles()
            {
                txtNome.Clear();
                txtPesquisa.Clear();
            }
        
    }
}
