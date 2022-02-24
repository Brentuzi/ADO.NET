using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQsqlM4
{
	public partial class LINQsqlM : Form
	{
		public LINQsqlM()
		{
			InitializeComponent();
		}

		private void buttonShowTop10_Click(object sender, EventArgs e)
		{
			var db = new DataClassesProcDataContext();
			foreach (var r in db.Ten_Most_Expensive_Products())
			{
				ListViewItem item = listView10Most.Items.Add(r.TenMostExpensiveProducts.ToString());
				item.SubItems.Add(r.UnitPrice.ToString());
			}
		}

        private void LINQsqlM_Load(object sender, EventArgs e)
        {

        }
    }
}
