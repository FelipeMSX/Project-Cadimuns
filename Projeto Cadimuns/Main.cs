using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Cadimuns
{
	public partial class Main : DevComponents.DotNetBar.Office2007Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void mskTextBox_KeyDown(object sender, KeyEventArgs e)
		{
	

		}

		private void mskTextBox_Validating(object sender, CancelEventArgs e)
		{
	
			Regex addressIP = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
			bool valid = addressIP.IsMatch(mskAddressIP.Text.Replace(",","."));
			if (valid)
			{
				errorProvidermskAddress.Clear();
			}
			else
			{
				errorProvidermskAddress.SetError(mskAddressIP, "Error");
			}
			//e.Cancel = !s;
		}

		private void comboBoxDataBase_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void comboBoxDataBase_KeyDown(object sender, KeyEventArgs e)
		{
			e.SuppressKeyPress = true;
		}
	}
}
