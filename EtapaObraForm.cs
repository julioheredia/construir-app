using ConstruirApp.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ConstruirApp
{
    public partial class EtapaObraForm : Form
    {
        Obra obra;

        public EtapaObraForm(Obra _selectedObra)
        {
            this.obra = _selectedObra;
            DataGridView dataGridView = GetDataGridView();
            
            foreach (EtapaObra _etapaObra in obra.EtapaObras)
            {
                foreach (Item _item in _etapaObra.Itens)
                {
                    AddDataGridViewItens(_item, dataGridView);
                }
            }

            this.Controls.Add(dataGridView);
            this.ResumeLayout(false);

            InitializeComponent();
        }

        private void AddDataGridViewItens(Item item, DataGridView dataGridView)
        {
            dataGridView.Rows.Add(item.Descricao, item.Quantidade.ToString(), item.Modelo, item.LocalCompra, item.Valor.ToString());
        }

        private DataGridView GetDataGridView()
        {
            DataGridView dataGridView = new DataGridView();
            DataGridViewTextBoxColumn Desc = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Quant = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Modelo = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn LocalCompra = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Valor = new DataGridViewTextBoxColumn();
            
            ((ISupportInitialize)(dataGridView)).BeginInit();

            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Desc, Quant, Modelo, LocalCompra, Valor });
            dataGridView.Location = new Point(30, 30);
            dataGridView.Name = "dataGridView1";
            dataGridView.Size = new Size(700, 290);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);

            Desc.FillWeight = 200F;
            Desc.HeaderText = "Descrição";
            Desc.Name = "Desc";
            Desc.Width = 250;

            Quant.FillWeight = 70F;
            Quant.HeaderText = "Quantidade";
            Quant.Name = "Quant";
            Quant.Width = 90;

            Modelo.FillWeight = 120F;
            Modelo.HeaderText = "Modelo";
            Modelo.Name = "Modelo";
            Modelo.Width = 150;

            LocalCompra.FillWeight = 120F;
            LocalCompra.HeaderText = "Local de Compra";
            LocalCompra.Name = "LocalCompra";
            LocalCompra.Width = 140;

            Modelo.FillWeight = 70F;
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Modelo.Width = 80;

            ((ISupportInitialize)(dataGridView)).EndInit();
            
            return dataGridView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EtapaObraForm_Load(object sender, EventArgs e)
        {

        }
    }
}
