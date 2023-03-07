using Relatorio_Certificados;
using System;
using System.Collections.Generic;
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
            AddColunasTabela();
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

        private void buttoncarregar_Click(object sender, EventArgs e)
        {
            string status = comboBoxStatus.Text;
            string tipo = comboBoxTipo.Text;
            string mes = comboBoxMes.Text;

            if (mes.Equals("JANEIRO"))
            {
                mes = "01";
            }
            else if (mes.Equals("FEVEREIRO"))
            {
                mes = "02";
            }
            else if (mes.Equals("MARÇO"))
            {
                mes = "03";
            }
            else if (mes.Equals("ABRIL"))
            {
                mes = "04";
            }
            else if (mes.Equals("MAIO"))
            {
                mes = "05";
            }
            else if (mes.Equals("JUNHO"))
            {
                mes = "06";
            }
            else if (mes.Equals("JULHO"))
            {
                mes = "07";
            }
            else if (mes.Equals("AGOSTO"))
            {
                mes = "08";
            }
            else if (mes.Equals("SETEMBRO"))
            {
                mes = "09";
            }

            else if (mes.Equals("OUTUBRO"))
            {
                mes = "10";
            }
            else if (mes.Equals("NOVEMBRO"))
            {
                mes = "11";
            }
            else if (mes.Equals("DEZEMBRO"))
            {
                mes = "12";
            }

            GridCertificados(repositorioCertificados.GetCertificados(status, mes, tipo));
            quantidadeCertificados.Text = repositorioCertificados.QuantidadeCertificados.ToString();
        }

        private void AddColunasTabela()
        {
            dataTable.Columns.Add("Codigo Empresa", typeof(string));
            dataTable.Columns.Add("Filial", typeof(string));
            dataTable.Columns.Add("Nome Empresa", typeof(string));
            dataTable.Columns.Add("Válido", typeof(string));
            dataTable.Columns.Add("Tipo", typeof(string));
            dataTable.Columns.Add("Vencimento", typeof(string));
        }

        private void DadosDataTable(IEnumerable<Certificados> certificados)
        {
            dataTable.Clear();
            foreach (Certificados certificado in certificados)
            {
                dataTable.Rows.Add(certificado.CodigoEmpresa, certificado.Filial, certificado.NomeEmpresa, certificado.Valido, certificado.Tipo, certificado.DataDeVencimento);
            }
        }

        private void GridCertificados(IEnumerable<Certificados> certificados)
        {
            DadosDataTable(certificados);
            bindingSource1.DataSource = dataTable;
            dgvCertificados.DataSource = bindingSource1;

            dgvCertificados.Columns[0].Width = 50;
            dgvCertificados.Columns[1].Width = 30;
            dgvCertificados.Columns[3].Width = 40;
            dgvCertificados.Columns[4].Width = 30;
            dgvCertificados.Columns[5].Width = 100;
        }
    }
}
