namespace _211084_trabalho_quarto_bimestre.Views
{
    partial class FrmProdutos
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
            this.tx = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.dgv_produto = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produto)).BeginInit();
            this.SuspendLayout();
            // 
            // tx
            // 
            this.tx.AutoSize = true;
            this.tx.Location = new System.Drawing.Point(435, 95);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(49, 13);
            this.tx.TabIndex = 96;
            this.tx.Text = "CÓDIGO";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(491, 92);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 95;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(610, 284);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 94;
            this.btn_fechar.Text = "FECHAR";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(491, 284);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 93;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(359, 284);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 92;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(234, 284);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 91;
            this.btn_alterar.Text = "ALTERAR";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(119, 284);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar.TabIndex = 90;
            this.btn_iniciar.Text = "INCLUIR";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(96, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 89;
            this.label10.Text = "Nome:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(402, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 88;
            this.label9.Text = "Valor da venda:";
            // 
            // txtVenda
            // 
            this.txtVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVenda.Location = new System.Drawing.Point(406, 158);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(160, 20);
            this.txtVenda.TabIndex = 87;
            // 
            // nome
            // 
            this.nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nome.Location = new System.Drawing.Point(100, 88);
            this.nome.Name = "nome";
            this.nome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nome.Size = new System.Drawing.Size(260, 20);
            this.nome.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(96, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 85;
            this.label8.Text = "Categoria:";
            // 
            // descricao
            // 
            this.descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricao.Location = new System.Drawing.Point(100, 227);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(260, 20);
            this.descricao.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 82;
            this.label7.Text = "Descrição";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(100, 134);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(260, 21);
            this.cboCategoria.TabIndex = 77;
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(626, 88);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(187, 190);
            this.picFoto.TabIndex = 76;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btn_pesquisar);
            this.groupBox1.Controls.Add(this.dgv_produto);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(119, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 273);
            this.groupBox1.TabIndex = 75;
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
            // dgv_produto
            // 
            this.dgv_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produto.Location = new System.Drawing.Point(10, 99);
            this.dgv_produto.Name = "dgv_produto";
            this.dgv_produto.Size = new System.Drawing.Size(658, 151);
            this.dgv_produto.TabIndex = 14;
            this.dgv_produto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_produto_CellContentClick);
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
            this.label4.Size = new System.Drawing.Size(296, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Digite o nome do produto para pesquisa:";
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(100, 178);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(260, 21);
            this.cboMarca.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 98;
            this.label1.Text = "Marca:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstoque.Location = new System.Drawing.Point(406, 217);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(160, 20);
            this.txtEstoque.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 100;
            this.label2.Text = "Estoque:";
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 658);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.tx);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtVenda);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProdutos";
            this.Text = "FrmProdutos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tx;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.DataGridView dgv_produto;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label2;
    }
}