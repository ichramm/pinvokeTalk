using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pinvokeApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			lblLenAnsi.Text = NativeMethods.GetStringLength1(textBox1.Text).ToString();

			lblLenUnicode.Text = NativeMethods.GetStringLength2(textBox1.Text).ToString();

			lblLenCrazy1.Text = NativeMethods.GetStringLengthCrazy1(textBox1.Text).ToString();
			
			lblLenCrazy2.Text = NativeMethods.GetStringLengthCrazy2(textBox1.Text).ToString();
		}
	}
}
