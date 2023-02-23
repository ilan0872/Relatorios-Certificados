using Relatorio_Certificados;
using System;
using System.Data;
using System.Windows.Forms;

namespace Relatorio_Certtificado
{
    public partial class RelatorioCertificados : Form
    {
        private RepositorioCertificado repositorioCertificados = new RepositorioCertificado();
        readonly DataTable dataTable = new DataTable();
        public int TotalPaginas = 1;
        private object objDataTable;

        public string ordernarPor {  get; set; }

        public RelatorioCertificados()
        {
            InitializeComponent();
        }

        //método que faz a açao da tela 
        private void RelatorioCertificados_Load(object sender, EventArgs e)
        {
            CarregaValidadeCertificado();
            comboBoxMes.SelectedIndex = 0;
            CarregaTipoCertificado();
        }

        // carrega o status do certificado se ele esta ativo ou vencido.
        private void CarregaValidadeCertificado()
        {
            DataTable objDataTable = repositorioCertificados.GetValidadeCertificado();
            comboBoxStatus.Items.Add("<Todos>");

            foreach (DataRow dataRow in objDataTable.Rows)
            {
                string valido = dataRow["Valido"].ToString();
                comboBoxStatus.Items.Add(valido);
            }
            comboBoxStatus.SelectedIndex = 0;

        }

        private void CarregaTipoCertificado()
        {
            DataTable objDataTable = repositorioCertificados.GetTipoCertificado();
            comboBoxTipo.Items.Add("<Todos>");

            foreach (DataRow dataRow in objDataTable.Rows)
            {
                string tipocertificado = dataRow["Tipocertificado"].ToString();
                comboBoxTipo.Items.Add(tipocertificado);
            }
            comboBoxTipo.SelectedIndex = 0;
        }

        private void timerHoras_Tick(object sender, EventArgs e)
        {

            this.labelHoras.Text = DateTime.Now.ToString("HH:mm:ss");
        }

      
    }
}
