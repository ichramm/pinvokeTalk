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

		void UpdateText()
		{
			NativeStruct nativeStruct = new NativeStruct();
			nativeStruct.integer = (int)numericUpDown1.Value;
			nativeStruct.name = textBox1.Text;

			textBox2.Text = NativeMethods.Serialize(nativeStruct, 1);
			textBox3.Text = NativeMethods.Serialize(nativeStruct, 2);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			UpdateText();
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			UpdateText();
		}
	}
}
