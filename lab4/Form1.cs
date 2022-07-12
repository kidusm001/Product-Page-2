using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab4;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            
            bool valid = true;
            if (string.IsNullOrEmpty(txt_objectName.Text))
            {
                errorProvider1.SetError(txt_objectName, "Name not given");
                valid = false;
            }
            
            else if (txt_number.Text.Length<3)
            {
                
                errorProvider1.SetError(txt_number, "number less than 3 characters");
                valid = false;
            }

            else if (txt_inventoryNumber.Text.Length < 3)
            {
                
                errorProvider1.SetError(txt_inventoryNumber, "number less than 3 characters");
                valid = false;
            }

            else if (txt_price.Text.Length < 3)
            {
                
                errorProvider1.SetError(txt_price, "number less than 3 characters");
                valid = false;
            }

            else if (txt_count.Text.Length < 3)
            {
                
                errorProvider1.SetError(txt_count, "number less than 3 characters");
                valid = false;
            }

            else if (string.IsNullOrEmpty(txt_date.Text))
            {
                
                errorProvider1.SetError(txt_date, "Date not given");
                valid = false;
            }
            else
            {
                errorProvider1.Clear();
            }
            
            if (valid)
            {
                Item i = new Item
                {
                    itemName = txt_objectName.Text,
                    number = int.Parse(txt_number.Text),
                    inventoryNumber = int.Parse(txt_inventoryNumber.Text),
                    price = Convert.ToDouble(txt_price.Text),
                    count = int.Parse(txt_count.Text),
                    date = txt_date.Text
                };

                i.save();
                displayItem.DataSource = null;
                displayItem.DataSource = Item.GetAll();
                MessageBox.Show("Saved");
            }
            

        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
