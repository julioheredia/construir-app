using ConstruirApp.Models;
using ConstruirApp.Service;
using System;
using System.Windows.Forms;

namespace ConstruirApp
{
    public partial class NovaObraForm : Form
    {
        public NovaObraForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Obra NovaObra = new Obra();
            NovaObra.Nome = textBox1.Text;
            ObraService.AddObra(NovaObra);

            MessageBox.Show("Nova Obra adicionada com sucesso!");

            this.Hide();
            new MainForm().Show();
        }
    }
}
