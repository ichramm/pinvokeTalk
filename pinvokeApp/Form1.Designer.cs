namespace pinvokeApp
{
	partial class Form1
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblLenUnicode = new System.Windows.Forms.Label();
			this.lblLenAnsi = new System.Windows.Forms.Label();
			this.lblLenCrazy1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblLenCrazy2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(12, 36);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(383, 29);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Text";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Length (Unicode)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "Length (Ansi)";
			// 
			// lblLenUnicode
			// 
			this.lblLenUnicode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblLenUnicode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLenUnicode.ForeColor = System.Drawing.Color.YellowGreen;
			this.lblLenUnicode.Location = new System.Drawing.Point(288, 121);
			this.lblLenUnicode.Name = "lblLenUnicode";
			this.lblLenUnicode.Size = new System.Drawing.Size(107, 39);
			this.lblLenUnicode.TabIndex = 4;
			this.lblLenUnicode.Text = "0";
			this.lblLenUnicode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblLenAnsi
			// 
			this.lblLenAnsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblLenAnsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLenAnsi.ForeColor = System.Drawing.Color.YellowGreen;
			this.lblLenAnsi.Location = new System.Drawing.Point(288, 73);
			this.lblLenAnsi.Name = "lblLenAnsi";
			this.lblLenAnsi.Size = new System.Drawing.Size(107, 39);
			this.lblLenAnsi.TabIndex = 5;
			this.lblLenAnsi.Text = "0";
			this.lblLenAnsi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblLenCrazy1
			// 
			this.lblLenCrazy1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblLenCrazy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLenCrazy1.ForeColor = System.Drawing.Color.YellowGreen;
			this.lblLenCrazy1.Location = new System.Drawing.Point(288, 169);
			this.lblLenCrazy1.Name = "lblLenCrazy1";
			this.lblLenCrazy1.Size = new System.Drawing.Size(107, 39);
			this.lblLenCrazy1.TabIndex = 7;
			this.lblLenCrazy1.Text = "0";
			this.lblLenCrazy1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(147, 24);
			this.label5.TabIndex = 6;
			this.label5.Text = "Length (Crazy 1)";
			// 
			// lblLenCrazy2
			// 
			this.lblLenCrazy2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblLenCrazy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLenCrazy2.ForeColor = System.Drawing.Color.YellowGreen;
			this.lblLenCrazy2.Location = new System.Drawing.Point(288, 216);
			this.lblLenCrazy2.Name = "lblLenCrazy2";
			this.lblLenCrazy2.Size = new System.Drawing.Size(107, 39);
			this.lblLenCrazy2.TabIndex = 9;
			this.lblLenCrazy2.Text = "0";
			this.lblLenCrazy2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 231);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(147, 24);
			this.label6.TabIndex = 8;
			this.label6.Text = "Length (Crazy 2)";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 264);
			this.Controls.Add(this.lblLenCrazy2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblLenCrazy1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblLenAnsi);
			this.Controls.Add(this.lblLenUnicode);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblLenUnicode;
		private System.Windows.Forms.Label lblLenAnsi;
		private System.Windows.Forms.Label lblLenCrazy1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblLenCrazy2;
		private System.Windows.Forms.Label label6;
	}
}

