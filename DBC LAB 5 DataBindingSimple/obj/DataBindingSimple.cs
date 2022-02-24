using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO.NET_Practice_5._2_DataBindingSimple
{
	public partial class DataBindingSimple : Form
	{

		private BindingSource bindingSourceProducts;
		
		public DataBindingSimple()
		{
			InitializeComponent();
		}

		private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.productsBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.northwindDataSet);

		}

		private void DataBindingSimple_Load(object sender, EventArgs e)
		{
			

			productsBindingSource = new BindingSource(northwindDataSet, "Products");

			textBoxProductID.DataBindings.Add("Text", productsBindingSource, "ProductID");
			textBoxProductName.DataBindings.Add("Text", productsBindingSource, "ProductName");

		}

		private void buttonPrevious_Click(object sender, EventArgs e)
		{
			productsBindingSource.MovePrevious();
		}

		private void buttonNext_Click(object sender, EventArgs e)
		{
			productsBindingSource.MoveNext();
		}

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
