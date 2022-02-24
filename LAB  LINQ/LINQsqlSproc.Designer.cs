
namespace LINQsqlSproc
{
	partial class LINQsqlSproc
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
            this.buttonOrderDetails = new System.Windows.Forms.Button();
            this.buttonOrderHistory = new System.Windows.Forms.Button();
            this.textBoxOrderCode = new System.Windows.Forms.TextBox();
            this.textBoxClientCode = new System.Windows.Forms.TextBox();
            this.labelEnterOrderCode = new System.Windows.Forms.Label();
            this.labelEnterClientCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOrderDetails
            // 
            this.buttonOrderDetails.Location = new System.Drawing.Point(16, 88);
            this.buttonOrderDetails.Name = "buttonOrderDetails";
            this.buttonOrderDetails.Size = new System.Drawing.Size(159, 23);
            this.buttonOrderDetails.TabIndex = 0;
            this.buttonOrderDetails.Text = "Подробности заказа";
            this.buttonOrderDetails.UseVisualStyleBackColor = true;
            this.buttonOrderDetails.Click += new System.EventHandler(this.buttonOrderDetails_Click);
            // 
            // buttonOrderHistory
            // 
            this.buttonOrderHistory.Location = new System.Drawing.Point(16, 205);
            this.buttonOrderHistory.Name = "buttonOrderHistory";
            this.buttonOrderHistory.Size = new System.Drawing.Size(176, 23);
            this.buttonOrderHistory.TabIndex = 1;
            this.buttonOrderHistory.Text = "История заказа";
            this.buttonOrderHistory.UseVisualStyleBackColor = true;
            this.buttonOrderHistory.Click += new System.EventHandler(this.buttonOrderHistory_Click);
            // 
            // textBoxOrderCode
            // 
            this.textBoxOrderCode.Location = new System.Drawing.Point(16, 49);
            this.textBoxOrderCode.Name = "textBoxOrderCode";
            this.textBoxOrderCode.Size = new System.Drawing.Size(281, 20);
            this.textBoxOrderCode.TabIndex = 2;
            // 
            // textBoxClientCode
            // 
            this.textBoxClientCode.Location = new System.Drawing.Point(16, 166);
            this.textBoxClientCode.Name = "textBoxClientCode";
            this.textBoxClientCode.Size = new System.Drawing.Size(281, 20);
            this.textBoxClientCode.TabIndex = 3;
            // 
            // labelEnterOrderCode
            // 
            this.labelEnterOrderCode.AutoSize = true;
            this.labelEnterOrderCode.Location = new System.Drawing.Point(13, 22);
            this.labelEnterOrderCode.Name = "labelEnterOrderCode";
            this.labelEnterOrderCode.Size = new System.Drawing.Size(109, 13);
            this.labelEnterOrderCode.TabIndex = 4;
            this.labelEnterOrderCode.Text = "Введите код заказа";
            // 
            // labelEnterClientCode
            // 
            this.labelEnterClientCode.AutoSize = true;
            this.labelEnterClientCode.Location = new System.Drawing.Point(16, 139);
            this.labelEnterClientCode.Name = "labelEnterClientCode";
            this.labelEnterClientCode.Size = new System.Drawing.Size(114, 13);
            this.labelEnterClientCode.TabIndex = 5;
            this.labelEnterClientCode.Text = "Введите код клиента";
            // 
            // LINQsqlSproc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 260);
            this.Controls.Add(this.labelEnterClientCode);
            this.Controls.Add(this.labelEnterOrderCode);
            this.Controls.Add(this.textBoxClientCode);
            this.Controls.Add(this.textBoxOrderCode);
            this.Controls.Add(this.buttonOrderHistory);
            this.Controls.Add(this.buttonOrderDetails);
            this.Name = "LINQsqlSproc";
            this.Load += new System.EventHandler(this.LINQsqlSproc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonOrderDetails;
		private System.Windows.Forms.Button buttonOrderHistory;
		private System.Windows.Forms.TextBox textBoxOrderCode;
		private System.Windows.Forms.TextBox textBoxClientCode;
		private System.Windows.Forms.Label labelEnterOrderCode;
		private System.Windows.Forms.Label labelEnterClientCode;
	}
}

