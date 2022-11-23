namespace _211084_trabalho_quarto_bimestre.Views
{
    partial class FormMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarca));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.dgv_marcas = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marcas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btn_pesquisar);
            this.groupBox1.Controls.Add(this.dgv_marcas);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(42, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 273);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btn_pesquisar.Image")));
            this.btn_pesquisar.Location = new System.Drawing.Point(557, 42);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(113, 40);
            this.btn_pesquisar.TabIndex = 21;
            this.btn_pesquisar.Text = "PESQUISAR";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click_1);
            // 
            // dgv_marcas
            // 
            this.dgv_marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_marcas.Location = new System.Drawing.Point(10, 99);
            this.dgv_marcas.Name = "dgv_marcas";
            this.dgv_marcas.Size = new System.Drawing.Size(658, 151);
            this.dgv_marcas.TabIndex = 14;
            this.dgv_marcas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selecionarLinha);
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
            this.label4.Size = new System.Drawing.Size(285, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Digite o nome da marca para pesquisa:";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(52, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.Size = new System.Drawing.Size(408, 20);
            this.txtNome.TabIndex = 23;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Marcas:";
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(620, 92);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(113, 41);
            this.btn_fechar.TabIndex = 34;
            this.btn_fechar.Text = "FECHAR";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click_1);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(494, 92);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(113, 41);
            this.btn_excluir.TabIndex = 33;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click_1);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(360, 90);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(113, 41);
            this.btn_cancelar.TabIndex = 32;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(205, 93);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(113, 39);
            this.btn_alterar.TabIndex = 31;
            this.btn_alterar.Text = "ALTERAR";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click_1);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(51, 92);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(113, 41);
            this.btn_iniciar.TabIndex = 30;
            this.btn_iniciar.Text = "INCLUIR";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click_1);
            // 
            // FormMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Name = "FormMarca";
            this.Text = "Marcas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_marcas;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_pesquisar;
    }
}