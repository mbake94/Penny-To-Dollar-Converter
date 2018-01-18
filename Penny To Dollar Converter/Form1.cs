using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penny_To_Dollar_Converter
{ 
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnConvert_Click(object sender, EventArgs e)
		{
			int dollars, quarters, dimes, nickles, pennies;
			int totalPennies;

			totalPennies = int.Parse(txtInput.Text);
			quarters = int.Parse(txtQuarters.Text);
			dollars = int.Parse(txtDollars.Text);
			dimes = int.Parse(txtDimes.Text);
			nickles = int.Parse(txtNickles.Text);
			pennies = int.Parse(txtPennies.Text);


			dollars = totalPennies % 100;
			quarters = totalPennies % 25;
			dimes = totalPennies % 10;
			nickles = totalPennies % 5;
			pennies = totalPennies;


			txtDollars.Text = dollars.ToString();
			txtQuarters.Text = quarters.ToString();
			txtDimes.Text = dimes.ToString();
			txtNickles.Text = nickles.ToString();
			txtPennies.Text = pennies.ToString();
		}
	}
	
}
