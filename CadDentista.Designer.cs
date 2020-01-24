namespace Consultorio
{
    partial class CadDentista
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeDentista = new System.Windows.Forms.Label();
            this.txtNomeDentista = new System.Windows.Forms.TextBox();
            this.txtCro = new System.Windows.Forms.TextBox();
            this.txtIdDentista = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbLinkedin = new System.Windows.Forms.CheckBox();
            this.cbTwitter = new System.Windows.Forms.CheckBox();
            this.cbFacebook = new System.Windows.Forms.CheckBox();
            this.cbInstagram = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(8, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(78, 24);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Novo";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(114, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 24);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(223, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 24);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(328, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 24);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.label2);
            this.gbDados.Controls.Add(this.label1);
            this.gbDados.Controls.Add(this.lblNomeDentista);
            this.gbDados.Controls.Add(this.txtNomeDentista);
            this.gbDados.Controls.Add(this.txtCro);
            this.gbDados.Controls.Add(this.txtIdDentista);
            this.gbDados.Location = new System.Drawing.Point(12, 42);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(473, 135);
            this.gbDados.TabIndex = 4;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CRO";
            // 
            // lblNomeDentista
            // 
            this.lblNomeDentista.AutoSize = true;
            this.lblNomeDentista.Location = new System.Drawing.Point(7, 29);
            this.lblNomeDentista.Name = "lblNomeDentista";
            this.lblNomeDentista.Size = new System.Drawing.Size(18, 13);
            this.lblNomeDentista.TabIndex = 3;
            this.lblNomeDentista.Text = "ID";
            // 
            // txtNomeDentista
            // 
            this.txtNomeDentista.Location = new System.Drawing.Point(48, 70);
            this.txtNomeDentista.Name = "txtNomeDentista";
            this.txtNomeDentista.Size = new System.Drawing.Size(365, 20);
            this.txtNomeDentista.TabIndex = 2;
            // 
            // txtCro
            // 
            this.txtCro.Location = new System.Drawing.Point(223, 26);
            this.txtCro.Name = "txtCro";
            this.txtCro.Size = new System.Drawing.Size(190, 20);
            this.txtCro.TabIndex = 1;
            // 
            // txtIdDentista
            // 
            this.txtIdDentista.Location = new System.Drawing.Point(48, 26);
            this.txtIdDentista.Name = "txtIdDentista";
            this.txtIdDentista.Size = new System.Drawing.Size(116, 20);
            this.txtIdDentista.TabIndex = 0;
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(29, 279);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(466, 160);
            this.dgvDados.TabIndex = 5;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Controls.Add(this.rbFeminino);
            this.groupBox1.Location = new System.Drawing.Point(12, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 78);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(63, 28);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(34, 17);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "M";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Checked = true;
            this.rbFeminino.Location = new System.Drawing.Point(6, 28);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(31, 17);
            this.rbFeminino.TabIndex = 0;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "F";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbLinkedin);
            this.groupBox2.Controls.Add(this.cbTwitter);
            this.groupBox2.Controls.Add(this.cbFacebook);
            this.groupBox2.Controls.Add(this.cbInstagram);
            this.groupBox2.Location = new System.Drawing.Point(146, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 78);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Redes Sociais";
            // 
            // cbLinkedin
            // 
            this.cbLinkedin.AutoSize = true;
            this.cbLinkedin.Location = new System.Drawing.Point(199, 55);
            this.cbLinkedin.Name = "cbLinkedin";
            this.cbLinkedin.Size = new System.Drawing.Size(66, 17);
            this.cbLinkedin.TabIndex = 3;
            this.cbLinkedin.Text = "Linkedin";
            this.cbLinkedin.UseVisualStyleBackColor = true;
            // 
            // cbTwitter
            // 
            this.cbTwitter.AutoSize = true;
            this.cbTwitter.Location = new System.Drawing.Point(199, 19);
            this.cbTwitter.Name = "cbTwitter";
            this.cbTwitter.Size = new System.Drawing.Size(58, 17);
            this.cbTwitter.TabIndex = 2;
            this.cbTwitter.Text = "Twitter";
            this.cbTwitter.UseVisualStyleBackColor = true;
            // 
            // cbFacebook
            // 
            this.cbFacebook.AutoSize = true;
            this.cbFacebook.Location = new System.Drawing.Point(38, 55);
            this.cbFacebook.Name = "cbFacebook";
            this.cbFacebook.Size = new System.Drawing.Size(74, 17);
            this.cbFacebook.TabIndex = 1;
            this.cbFacebook.Text = "Facebook";
            this.cbFacebook.UseVisualStyleBackColor = true;
            // 
            // cbInstagram
            // 
            this.cbInstagram.AutoSize = true;
            this.cbInstagram.Location = new System.Drawing.Point(40, 19);
            this.cbInstagram.Name = "cbInstagram";
            this.cbInstagram.Size = new System.Drawing.Size(72, 17);
            this.cbInstagram.TabIndex = 0;
            this.cbInstagram.Text = "Instagram";
            this.cbInstagram.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CadDentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.gbDados);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "CadDentista";
            this.Text = "Cadastro de Dentista";
            this.Load += new System.EventHandler(this.CadDentista_Load);
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.TextBox txtNomeDentista;
        private System.Windows.Forms.TextBox txtCro;
        private System.Windows.Forms.TextBox txtIdDentista;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeDentista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbLinkedin;
        private System.Windows.Forms.CheckBox cbTwitter;
        private System.Windows.Forms.CheckBox cbFacebook;
        private System.Windows.Forms.CheckBox cbInstagram;
        private System.Windows.Forms.Button button1;
    }
}

