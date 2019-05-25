using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopApp
{
    public partial class BookShop : Form
    {
        public BookShop()
        {
            InitializeComponent();
        }

        const int size = 5;
        string[] order = new string[size];
        int index = 0;

        private void SaveButton_Click(object sender, EventArgs e)
        {

            index++;

            order[0] = "Customer Name: " + nameTextBox.Text;
            order[1] = "\nContact No. : " + contactTextBox.Text;
            order[2] = "\nAddress: " + addressTextBox.Text;
            order[3] = "\nOrder: " + orderComboBox.Text;
            order[4] = "\nQuantity: " + quantityTextBox.Text;

            string store = "";
            string price = "";           
            int quantity;
            int number = 0;
            int cal;

            for (int index = 0; index < order.Length; index++)
            {
                store = store + order[index];
               
            }

            number = number + 1;

            if (orderComboBox.Text == "Math - 120")
            {
                quantity = Convert.ToInt32(quantityTextBox.Text);
                cal = 120 * quantity;
                price = price + "\nTotal Price: " + cal + " BDT. \n";

            }

            else if (orderComboBox.Text == "English - 100")
            {

                quantity = Convert.ToInt32(quantityTextBox.Text);
                cal = 100 * quantity;
                price = price + "\nTotal Price: " + cal + " BDT. \n";

            }

            else if (orderComboBox.Text == "Bangla - 90")
            {

                quantity = Convert.ToInt32(quantityTextBox.Text);
                cal = 90 * quantity;
                price = price + "\nTotal Price: " + cal + " BDT. \n";

            }

            else
            {

                quantity = Convert.ToInt32(quantityTextBox.Text);
                cal = 80 * quantity;
                price = price + "\nTotal Price: " + cal + " BDT. \n";

            }

            
            showRichTextBox.Font = new Font("Times New Roman", 14);
            showRichTextBox.AppendText("\t\t Customer Information " + index + "\n\n" + store + price + "\n\n");

           

            
          

        }
    }
}
