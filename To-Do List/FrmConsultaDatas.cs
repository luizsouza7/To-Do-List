using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
    {
        public partial class FrmConsultaDatas : Form
        {
            public FrmConsultaDatas()
            {
                InitializeComponent();
            }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Consultando de {dtpInicio.Value:dd/MM/yyyy} até {dtpFim.Value:dd/MM/yyyy}");
        }

        private void CarregarResultados()
            {
                string dataInicio = dtpInicio.Value.ToString("yyyy-MM-dd");
                string dataFim = dtpFim.Value.ToString("yyyy-MM-dd");

                using (SqlConnection conexao = new SqlConnection("SUA_STRING_DE_CONEXAO"))
                {
                    string sql = @"
                    SELECT titulo, descricao, data_limite, status
                    FROM tarefas
                    WHERE data_limite BETWEEN @inicio AND @fim
                    ORDER BY data_limite ASC;
                ";

                    SqlCommand cmd = new SqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@inicio", dataInicio);
                    cmd.Parameters.AddWithValue("@fim", dataFim);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvResultados.DataSource = dt;
                }
            }

            // CHAMA O MÉTODO AO CLICAR NO BOTÃO
            private void btnConsultar_Click(object sender, EventArgs e)
            {
                CarregarResultados();
            }
        }
    }

}
}
