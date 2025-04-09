using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_11_GUI_Input
{
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }

        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            string item;
            int quantity;
            double price, totalPrice;

            item = txtItem.Text;
            price = Convert.ToDouble(txtPrice.Text);
            quantity = Convert.ToInt32(txtQuantity.Text);

            if (price < 0 || quantity < 0)
            {
                lblTotalPrice.Text = "Please enter a positive number";
            }
            else
            {
                totalPrice = price * quantity;

                // Output Result
                lblTotalPrice.Text = "Final Price for " + quantity + " " + item + "(s) is: " + totalPrice.ToString("C");
                
            }
        }
    }
}
