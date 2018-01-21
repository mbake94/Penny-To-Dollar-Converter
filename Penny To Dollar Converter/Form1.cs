using System;
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
            int dollars, quarters, dimes, nickels, pennies;
            int totalPennies;
            int leftovers;

            totalPennies = int.Parse(txtInput.Text);

            dollars = totalPennies / 100;
            leftovers = totalPennies % 100;
            quarters = leftovers / 25;
            leftovers = leftovers % 25;
            dimes = leftovers / 10;
            leftovers = leftovers % 10;
            nickels = leftovers / 5;
            leftovers = leftovers % 5;
            pennies = leftovers;

            txtDollars.Text = dollars.ToString();
            txtQuarters.Text = quarters.ToString();
            txtDimes.Text = dimes.ToString();
            txtNickels.Text = nickels.ToString();
            txtPennies.Text = pennies.ToString();
        }
    }

}
