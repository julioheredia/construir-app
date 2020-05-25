using ConstruirApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstruirApp
{
    public partial class EditarObraForm : Form
    {
        Obra obra;

        public EditarObraForm(Obra _selectedObra)
        {
            this.obra = _selectedObra;
            
            InitializeComponent();

            this.textBox1.Text = obra.Nome;
        }

        private void EtapasForm_Load(object sender, EventArgs e)
        {
            foreach (EtapaObra _etapa in obra.EtapaObras)
            {
                string[] itens = { "", _etapa.EtapaObraId.ToString(), _etapa.Etapa };
                ListViewItem listViewItem = new ListViewItem(itens);
                this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem });
            }
        }
            
    }
}
