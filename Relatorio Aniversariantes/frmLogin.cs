using Relatorio_Certtificado;
using System;
using System.Windows.Forms;

namespace Relatorio_Aniversariantes
{
    public partial class frmLogin : Form
    {
        RepositorioPass repositorioPass = new RepositorioPass();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("O nome deve ser preenchido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("A senha deve ser preenchida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            repositorioPass.Insert(textBox1.Text, txtSenha.Text);
            
            RelatorioCertificados frm = new RelatorioCertificados();
            this.Hide();
            frm.Show();
            
        }
    }
}
