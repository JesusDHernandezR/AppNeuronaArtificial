using Logica;

namespace PresentacionGuI
{
    public partial class FormPrincipal : Form
    {
        ParametroService parametroService;
        PesoService pesoService;
        public FormPrincipal()
        {
            InitializeComponent();
            parametroService = new ParametroService();
            pesoService = new PesoService();
        }
        private void buttonCargarTabla(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var response = parametroService.ConsultarTodo();
            if (!response.Error)
            {
                foreach (var p in response.ListParametros)
                {
                    dataGridTablaParametros.DataSource = response.ListParametros;
                }
            }
            else
            {
                MessageBox.Show(response.Mensaje, "INFO", MessageBoxButtons.OK);
            }
        }

        private void dataGridTablaParametros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("?Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void labelPatrones_Click(object sender, EventArgs e)
        {
            labelPatrones.Text = dataGridTablaParametros.Rows.Count.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonUnicapa_Click(object sender, EventArgs e)
        {
            var responsePeso = pesoService.ConsultarPesos();
            if (!responsePeso.Error)
            {
                foreach (var p in responsePeso.ListPeso)
                {
                    dataGridPesos.DataSource = responsePeso.ListPeso;
                }
            }
            else
            {
                MessageBox.Show(responsePeso.Mensaje, "INFO", MessageBoxButtons.OK);
            }
        }
    }
}