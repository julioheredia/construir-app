using ConstruirApp.Models;
using ConstruirApp.Service;
using System;
using System.Windows.Forms;

namespace ConstruirApp
{
    public partial class ObrasForm : Form
    {

        Obra _selectedObra;

        public ObrasForm()
        {
            InitializeComponent();
        }

        private void ObrasForm_Load(object sender, EventArgs e)
        {
            foreach (Obra _obra in ObraService.Obras())
            {
                string[] itens = { "", _obra.ObraId.ToString(), _obra.Nome };
                ListViewItem listViewItem = new ListViewItem(itens);
                this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem });
            }

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection checkedItems = listView1.CheckedItems;

            int result = -1;
            foreach (ListViewItem item in checkedItems)
            {
                var id = item.SubItems[1].Text;
                result = Int32.Parse(id);
                _selectedObra = ObraService.findObraById(result);
            }

            if (result != -1)
            {
                this.Hide();
                EtapaObraForm EtapaObraForm = new EtapaObraForm(_selectedObra);
                EtapaObraForm.Show();
            }
            else
            {
                MessageBox.Show("Não foi selecionada nenhuma Obra");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
