using System;
using System.Windows.Forms;
using To_Do_List.Services;

namespace To_Do_List
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            btnGerenciar.Click += BtnGerenciar_Click;
            btnConsulta.Click += BtnConsulta_Click;
            btnPerfil.Click += BtnPerfil_Click;
            btnSair.Click += BtnSair_Click;
            FormClosed += FrmMenu_FormClosed;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (AppData.UsuarioLogado == null)
            {
                MessageBox.Show("Sessão expirada. Faça login novamente.",
                    "Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }

            LblUsuario.Text = AppData.UsuarioLogado.Nome;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private static void AbrirDialog(Form form)
        {
            using (form)
            {
                form.ShowDialog();
            }
        }

        private void BtnGerenciar_Click(object? sender, EventArgs e)
        {
            AbrirDialog(new FrmGerenciarTarefas());
        }

        private void BtnConsulta_Click(object? sender, EventArgs e)
        {
            AbrirDialog(new FrmConsultaTarefas());
        }

        private void BtnPerfil_Click(object? sender, EventArgs e)
        {
            AbrirDialog(new FrmPerfil());
            if (AppData.UsuarioLogado != null)
            {
                LblUsuario.Text = AppData.UsuarioLogado.Nome;
            }
        }

        private void BtnSair_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void FrmMenu_FormClosed(object? sender, FormClosedEventArgs e)
        {
            AppData.Deslogar();
        }

        private void btnConsulta_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGerenciar_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
        private void btnConsultaData_Click(object sender, EventArgs e)
        {
            FrmConsultaDatas tela = new FrmConsultaDatas();
        }
    }
}
