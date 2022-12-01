namespace _211084_trabalho_quarto_bimestre.Views
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkVenda = new System.Windows.Forms.CheckBox();
            this.renda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataNasc = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.cboCidades = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.tx = new System.Windows.Forms.Label();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // chkVenda
            // 
            this.chkVenda.AutoSize = true;
            this.chkVenda.Location = new System.Drawing.Point(365, 179);
            this.chkVenda.Name = "chkVenda";
            this.chkVenda.Size = new System.Drawing.Size(115, 17);
            this.chkVenda.TabIndex = 62;
            this.chkVenda.Text = "Bloqueia a venda?";
            this.chkVenda.UseVisualStyleBackColor = true;
            // 
            // renda
            // 
            this.renda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.renda.Location = new System.Drawing.Point(34, 165);
            this.renda.Name = "renda";
            this.renda.Size = new System.Drawing.Size(260, 20);
            this.renda.TabIndex = 61;
            this.renda.TextChanged += new System.EventHandler(this.renda_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Renda:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(352, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Data de Nascimento:";
            // 
            // dataNasc
            // 
            this.dataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNasc.Location = new System.Drawing.Point(350, 149);
            this.dataNasc.Name = "dataNasc";
            this.dataNasc.Size = new System.Drawing.Size(160, 20);
            this.dataNasc.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "CPF:";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(34, 119);
            this.mskCPF.Mask = "999.999.999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(260, 20);
            this.mskCPF.TabIndex = 56;
            // 
            // cboCidades
            // 
            this.cboCidades.FormattingEnabled = true;
            this.cboCidades.Location = new System.Drawing.Point(34, 72);
            this.cboCidades.Name = "cboCidades";
            this.cboCidades.Size = new System.Drawing.Size(260, 21);
            this.cboCidades.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, -27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "UF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, -27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Cidade:";
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(560, 26);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(187, 190);
            this.picFoto.TabIndex = 51;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btn_pesquisar);
            this.groupBox1.Controls.Add(this.dgv_clientes);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(53, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 273);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(586, 51);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(82, 23);
            this.btn_pesquisar.TabIndex = 15;
            this.btn_pesquisar.Text = "PESQUISAR";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(10, 99);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.Size = new System.Drawing.Size(658, 151);
            this.dgv_clientes.TabIndex = 14;
            this.dgv_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellContentClick);
            this.dgv_clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellContentClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(10, 50);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(541, 24);
            this.txtPesquisa.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Digite o nome do cliente para pesquisa:";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(64, -58);
            this.txtNome.Name = "txtNome";
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.Size = new System.Drawing.Size(446, 20);
            this.txtNome.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, -81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nome:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 63;
            this.label8.Text = "Cidade:";
            // 
            // nome
            // 
            this.nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nome.Location = new System.Drawing.Point(34, 26);
            this.nome.Name = "nome";
            this.nome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nome.Size = new System.Drawing.Size(260, 20);
            this.nome.TabIndex = 64;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // txtUF
            // 
            this.txtUF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUF.Location = new System.Drawing.Point(340, 84);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(160, 20);
            this.txtUF.TabIndex = 65;
            this.txtUF.TextChanged += new System.EventHandler(this.txtUF_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(346, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 66;
            this.label9.Text = "UF:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 67;
            this.label10.Text = "Nome:";
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(53, 222);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar.TabIndex = 68;
            this.btn_iniciar.Text = "INCLUIR";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(168, 222);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 69;
            this.btn_alterar.Text = "ALTERAR";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(293, 222);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 70;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(425, 222);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 71;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(544, 222);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 72;
            this.btn_fechar.Text = "FECHAR";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(425, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 73;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // tx
            // 
            this.tx.AutoSize = true;
            this.tx.Location = new System.Drawing.Point(369, 33);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(49, 13);
            this.tx.TabIndex = 74;
            this.tx.Text = "CÓDIGO";
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "ofdArquivo";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 578);
            this.Controls.Add(this.tx);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkVenda);
            this.Controls.Add(this.renda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataNasc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.cboCidades);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkVenda;
        private System.Windows.Forms.TextBox renda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dataNasc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.ComboBox cboCidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label tx;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
    }
}