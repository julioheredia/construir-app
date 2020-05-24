using ConstruirApp.Service;
using System;
using System.Windows.Forms;

namespace ConstruirApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            ObraService.LoadObrasInCache();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NovaObraForm().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ObrasForm().Show();
        }
    }
}
