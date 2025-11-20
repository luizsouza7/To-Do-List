namespace To_Do_List
{
    partial class FrmPerfil
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
            label1 = new Label();
            label3 = new Label();
            lblNome = new Label();
            lblEmail = new Label();
            label5 = new Label();
            label2 = new Label();
            txtSenha1 = new TextBox();
            txtSenha2 = new TextBox();
            label4 = new Label();
            btnSalvar = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 28);
            label1.Name = "label1";
            label1.Size = new Size(196, 44);
            label1.TabIndex = 7;
            label1.Text = "Meu Perfil";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(213, 116);
            label3.Name = "label3";
            label3.Size = new Size(77, 30);
            label3.TabIndex = 9;
            label3.Text = "Nome:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(315, 116);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(83, 30);
            lblNome.TabIndex = 10;
            lblNome.Text = "usuario";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(315, 162);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(83, 30);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(213, 162);
            label5.Name = "label5";
            label5.Size = new Size(77, 30);
            label5.TabIndex = 11;
            label5.Text = "E-mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, 220);
            label2.Name = "label2";
            label2.Size = new Size(132, 30);
            label2.TabIndex = 13;
            label2.Text = "Nova Senha:";
            label2.Click += label2_Click;
            // 
            // txtSenha1
            // 
            txtSenha1.Location = new Point(315, 227);
            txtSenha1.Name = "txtSenha1";
            txtSenha1.Size = new Size(177, 23);
            txtSenha1.TabIndex = 14;
            // 
            // txtSenha2
            // 
            txtSenha2.Location = new Point(315, 285);
            txtSenha2.Name = "txtSenha2";
            txtSenha2.Size = new Size(177, 23);
            txtSenha2.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(118, 278);
            label4.Name = "label4";
            label4.Size = new Size(172, 30);
            label4.TabIndex = 15;
            label4.Text = "Confirmar Senha";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(222, 361);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(101, 41);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(391, 361);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(101, 41);
            btnVoltar.TabIndex = 19;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // FrmPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(txtSenha2);
            Controls.Add(label4);
            Controls.Add(txtSenha1);
            Controls.Add(label2);
            Controls.Add(lblEmail);
            Controls.Add(label5);
            Controls.Add(lblNome);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FrmPerfil";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label lblNome;
        private Label lblEmail;
        private Label label5;
        private Label label2;
        private TextBox txtSenha1;
        private TextBox txtSenha2;
        private Label label4;
        private Button btnSalvar;
        private Button btnVoltar;
    }
}