using System;
using System.Windows.Forms;
using To_Do_List.Services;

namespace To_Do_List
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
            button1.Click += BtnCriarConta_Click;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void BtnCriarConta_Click(object? sender, EventArgs e)
        {
            var nome = textBox1.Text.Trim();
            var email = textBox2.Text.Trim();
            var senha = textBox3.Text;

            if (!AppData.RegistrarUsuario(nome, email, senha, out var mensagem))
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
