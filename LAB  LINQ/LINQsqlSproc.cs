using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace LINQsqlSproc
{
	public partial class LINQsqlSproc : Form
	{
		public LINQsqlSproc()
		{
			InitializeComponent();
		}

		Northwnd db = new Northwnd(@"Data Source=DESKTOP-IITVJLG\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");

		private void buttonOrderDetails_Click(object sender, EventArgs e)
		{
			string param = textBoxOrderCode.Text;
			var custquery = db.CustOrdersDetail(Convert.ToInt32(param));
			

			string msg = "";
			foreach (CustOrdersDetailResult custOrdersDetail in custquery)
			{
				msg = msg + custOrdersDetail.ProductName + "\n";
			}
			if (msg == "")
				msg = "No results.";
			MessageBox.Show(msg);

			param = "";
			textBoxOrderCode.Text = "";
		}

		private void buttonOrderHistory_Click(object sender, EventArgs e)
		{
			string param = textBoxClientCode.Text;
			var custquery = db.CustOrderHist(param);
			string msg = "";
			foreach (CustOrderHistResult custOrderHist in custquery)
			{
				msg = msg + custOrderHist.ProductName + "\n";
			}
			MessageBox.Show(msg);
			param = "";
			textBoxClientCode.Text = "";
		}

        private void LINQsqlSproc_Load(object sender, EventArgs e)
        {

        }
    }
}
