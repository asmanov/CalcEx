using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            float dist = 0;
            float cons = 0;
            float price = 0;
            float total_fuel = 0;
            float total_price = 0;
            float.TryParse(distanceTextBox.Text, out dist);
            float.TryParse(mpgTextBox.Text, out cons);
            float.TryParse(priceTextBox.Text, out price);
            total_fuel = dist / 100 * cons;
            total_price = total_fuel * price;
            gallonsLabel.Text = $"Gallons used: {total_fuel}";
            gallonsLabel.ForeColor = Color.FromArgb(255, 255, 0, 0);
            costLabel.Text = $"Total cost: ${total_price}";
            costLabel.ForeColor = Color.FromArgb(255, 255, 0, 0);
        }
    }
}
