namespace To_Do_List
{
    partial class FrmMenu
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
            btnGerenciar = new Button();
            btnConsulta = new Button();
            btnPerfil = new Button();
            btnSair = new Button();
            label1 = new Label();
            label2 = new Label();
            LblUsuario = new Label();
            SuspendLayout();
            // 
            // btnGerenciar
            // 
            btnGerenciar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerenciar.Location = new Point(170, 172);
            btnGerenciar.Name = "btnGerenciar";
            btnGerenciar.Size = new Size(226, 43);
            btnGerenciar.TabIndex = 0;
            btnGerenciar.Text = "Gerenciar Tarefas";
            btnGerenciar.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            btnConsulta.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsulta.Location = new Point(439, 172);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(185, 43);
            btnConsulta.TabIndex = 1;
            btnConsulta.Text = "Consultar Tarefas";
            btnConsulta.UseVisualStyleBackColor = true;
            // 
            // btnPerfil
            // 
            btnPerfil.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPerfil.Location = new Point(170, 245);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(226, 43);
            btnPerfil.TabIndex = 3;
            btnPerfil.Text = "Meu Perfil";
            btnPerfil.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(439, 245);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(185, 43);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(170, 24);
            label1.Name = "label1";
            label1.Size = new Size(484, 44);
            label1.TabIndex = 6;
            label1.Text = "To-Do list - Menu Principal";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 350);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 7;
            label2.Text = "Usuário Logado:";
            label2.Click += label2_Click;
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Location = new Point(191, 350);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(12, 15);
            LblUsuario.TabIndex = 8;
            LblUsuario.Text = "-";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSair);
            Controls.Add(btnPerfil);
            Controls.Add(btnConsulta);
            Controls.Add(btnGerenciar);
            Name = "FrmMenu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGerenciar;
        private Button btnConsulta;
        private Button btnPerfil;
        private Button btnSair;
        private Label label1;
        private Label label2;
        private Label LblUsuario;
    }
}