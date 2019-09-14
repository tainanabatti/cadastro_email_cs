using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroEmail
{

    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void emailBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

           
            this.Validate();
 
            this.emailBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.envio_emailDataSet);

        }

        private void cadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'envio_emailDataSet.email'. Você pode movê-la ou removê-la conforme necessário.
            this.emailTableAdapter.Fill(this.envio_emailDataSet.email);

        }

        private void nome_destinoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nome_destinoLabel_Click(object sender, EventArgs e)
        {

        }

        private void email_origemTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
