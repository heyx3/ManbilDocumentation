using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTMLGenerator
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void memberFields_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void classNameText_TextChanged(object sender, EventArgs e)
		{
			htmlFileLocationText.Text = systemNameText.Text + "/" + classNameText.Text;
		}

		private void systemNameText_TextChanged(object sender, EventArgs e)
		{
			htmlFileLocationText.Text = systemNameText.Text + "/" + classNameText.Text;
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
