using System;
using System.Windows.Forms;
using To_Do_List.Services;

namespace To_Do_List
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtSenha.UseSystemPasswordChar = true;
            button1.Click += BtnEntrar_Click;
            button2.Click += BtnCriarConta_Click;
        }

        private void BtnEntrar_Click(object? sender, EventArgs e)
        {
            var email = txtEmail.Text.Trim();
            var senha = txtSenha.Text;

            if (!AppData.Autenticar(email, senha, out var mensagem))
            {
                MessageBox.Show(mensagem, "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Hide();
            using (var menu = new FrmMenu())
            {
                menu.ShowDialog();
            }

            AppData.Deslogar();
            txtSenha.Clear();
            Show();
        }

        private void BtnCriarConta_Click(object? sender, EventArgs e)
        {
            using var cadastro = new FrmCadastro();
            cadastro.ShowDialog();
        }
    }
}
