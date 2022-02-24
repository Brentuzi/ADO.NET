
namespace ITMO.ADO.NET_Practice_8._4_LINQsqlM
{
	partial class LINQsqlM
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.buttonShowTop10 = new System.Windows.Forms.Button();
            this.listView10Most = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonShowTop10
            // 
            this.buttonShowTop10.Location = new System.Drawing.Point(26, 413);
            this.buttonShowTop10.Name = "buttonShowTop10";
            this.buttonShowTop10.Size = new System.Drawing.Size(344, 23);
            this.buttonShowTop10.TabIndex = 1;
            this.buttonShowTop10.Text = "10 лучших";
            this.buttonShowTop10.UseVisualStyleBackColor = true;
            this.buttonShowTop10.Click += new System.EventHandler(this.buttonShowTop10_Click);
            // 
            // listView10Most
            // 
            this.listView10Most.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView10Most.HideSelection = false;
            this.listView10Most.Location = new System.Drawing.Point(26, 12);
            this.listView10Most.Name = "listView10Most";
            this.listView10Most.Size = new System.Drawing.Size(344, 395);
            this.listView10Most.TabIndex = 2;
            this.listView10Most.UseCompatibleStateImageBehavior = false;
            this.listView10Most.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ten Most";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Unit Price";
            this.columnHeader2.Width = 154;
            // 
            // LINQsqlM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.listView10Most);
            this.Controls.Add(this.buttonShowTop10);
            this.Name = "LINQsqlM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LINQsqlM_Load);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonShowTop10;
		private System.Windows.Forms.ListView listView10Most;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
	}
}

