using System;
using System.Windows.Forms;
using To_Do_List.Services;

namespace To_Do_List
{
    public partial class FrmPerfil : Form
    {
        public FrmPerfil()
        {
            InitializeComponent();
            txtSenha1.UseSystemPasswordChar = true;
            txtSenha2.UseSystemPasswordChar = true;
            Load += FrmPerfil_Load;
            btnSalvar.Click += BtnSalvar_Click;
        }

        private void FrmPerfil_Load(object? sender, EventArgs e)
        {
            if (AppData.UsuarioLogado == null)
            {
                MessageBox.Show("Sessão expirada. Faça login novamente.",
                    "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }

            lblNome.Text = AppData.UsuarioLogado.Nome;
            lblEmail.Text = AppData.UsuarioLogado.Email;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            var novaSenha = txtSenha1.Text;
            var confirmar = txtSenha2.Text;

            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                MessageBox.Show("Informe a nova senha.", "Perfil",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.Equals(novaSenha, confirmar, StringComparison.Ordinal))
            {
                MessageBox.Show("As senhas não coincidem.", "Perfil",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AppData.AtualizarSenha(novaSenha, out var mensagem))
            {
                MessageBox.Show(mensagem, "Perfil",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha1.Clear();
                txtSenha2.Clear();
            }
            else
            {
                MessageBox.Show(mensagem, "Perfil",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
