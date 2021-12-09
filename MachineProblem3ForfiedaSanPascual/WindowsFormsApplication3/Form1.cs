using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Pizza Type Selection Fn1353

            if (radioButton1.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Thin Crust Small Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("100.00");
                    listView1.Items.Add(item);
         
                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Thick Crust Small Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("100.00");
                    listView1.Items.Add(item);
               
                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Regular Crust Small Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("100.00");
                    listView1.Items.Add(item);
             
                }

            }

            else if (radioButton2.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Thin Crust Medium Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("200.00");
                    listView1.Items.Add(item);
              
                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Thick Crust Medium Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("200.00");
                    listView1.Items.Add(item);
             
                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Regular Crust Medium Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("200.00");
                    listView1.Items.Add(item);
                
                }
            }

            else if (radioButton3.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Thin Crust Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("300.00");
                    listView1.Items.Add(item);
              
                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Thick Crust Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("300.00");
                    listView1.Items.Add(item);
              
                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Regular Crust Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("300.00");
                    listView1.Items.Add(item);
            
                }
            }


            //Pizza Topping Selection

            if (checkBox1.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Pepperoni Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("20.00");
                listView1.Items.Add(item);
           
            }
            
            if (checkBox2.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Mushroom Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("20.00");
                listView1.Items.Add(item);
          
            }

            if (checkBox3.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Black Olives Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("20.00");
                listView1.Items.Add(item);
         
            }

            if (checkBox4.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Onions Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("20.00");
                listView1.Items.Add(item);
             
            }

            if (checkBox5.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Tomatoes Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("20.00");
                listView1.Items.Add(item);
            
            }

            if (checkBox6.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Bell Pepper Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("20.00");
                listView1.Items.Add(item);

            }

            if (checkBox7.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Cheese Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("20.00");
                listView1.Items.Add(item);
            
            }

            if (checkBox8.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Pineapple Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("20.00");
                listView1.Items.Add(item);
       
            }

            if (checkBox9.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Ham Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("20.00");
                listView1.Items.Add(item);

            }

            if (checkBox10.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Bacon Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("20.00");
                listView1.Items.Add(item);

            }


            //Drink Selection

            if (checkBox15.Checked == true)
            {
                ListViewItem item = new ListViewItem("Soft drinks");
                item.SubItems.Add(textBox1.Text);
                int qty = Convert.ToInt32(textBox1.Text);
                double cost = qty * 25;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
          
            }

            else
            {
                textBox1.Text = "";
            }

            if (checkBox19.Checked == true)
            {
                ListViewItem item = new ListViewItem("Iced Tea");
                item.SubItems.Add(textBox5.Text);
                int qty = Convert.ToInt32(textBox5.Text);
                double cost = qty * 30;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox5.Text = "";
            }

            if (checkBox20.Checked == true)
            {
                ListViewItem item = new ListViewItem("Fruit Juice");
                item.SubItems.Add(textBox6.Text);
                int qty = Convert.ToInt32(textBox6.Text);
                double cost = qty * 30;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox6.Text = "";
            }

            if (checkBox21.Checked == true)
            {
                ListViewItem item = new ListViewItem("Bottled Water");
                item.SubItems.Add(textBox7.Text);
                int qty = Convert.ToInt32(textBox7.Text);
                double cost = qty * 25;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox7.Text = "";
            }

 
            double total = 0;
            double vat = 0;
            double totaldue = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                total += Convert.ToDouble(item.SubItems[2].Text);
            }

            vat = total * 0.12;
            totaldue = vat + total;

            string vatDisplay = vat.ToString("c2");
            string totalDisplay = totaldue.ToString("c2");
            string amount = total.ToString("c2");
            
            textBox8.Text = amount;
            textBox9.Text = vatDisplay;
            textBox10.Text = totalDisplay;

            tabControl1.SelectTab("tabPage2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage3");
            textBox19.Text = textBox10.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton5.Checked = true;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox19.Enabled = false;
            textBox21.Enabled = false;

            comboBox1.Items.Add("Caloocan");
            comboBox1.Items.Add("Las Piñas");
            comboBox1.Items.Add("Makati City");
            comboBox1.Items.Add("Malabon");
            comboBox1.Items.Add("Mandaluyong");
            comboBox1.Items.Add("Manila City");
            comboBox1.Items.Add("Marikina");
            comboBox1.Items.Add("Muntinlupa");
            comboBox1.Items.Add("Navotas");
            comboBox1.Items.Add("Parañaque");
            comboBox1.Items.Add("Pasay");
            comboBox1.Items.Add("Pasig");
            comboBox1.Items.Add("Pateros");
            comboBox1.Items.Add("Quezon City");
            comboBox1.Items.Add("San Juan");         
            comboBox1.Items.Add("Taguig");
            comboBox1.Items.Add("Valenzuela");

            comboBox2.Items.Add("Cash");
            comboBox2.Items.Add("Credit Card");
            comboBox2.Items.Add("Debit Card");
            comboBox2.Items.Add("E-wallet");

            button8.Enabled = false;

        }

      
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8 && q != 46)
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");
        }

        private void button7_Click(object sender, EventArgs e)
        {


            if (textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || comboBox1.Text == "" || textBox16.Text == "" || textBox18.Text == "" || textBox20.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please fill in required fields");
            }
    
            else
            {
                string money = textBox19.Text;
                char[] peso = { '₱' };
                string paymoney = money.TrimStart(peso);
                double paymentDue = Convert.ToDouble(paymoney);
                double amountPaid = Convert.ToDouble(textBox20.Text);
                double change = 0;
                change = amountPaid - paymentDue;
                textBox21.Text = change.ToString("c2");

                if (change < 0)
                {
                    MessageBox.Show("Please pay your balance");

                }

                else
                {
                    button8.Enabled = true;
                }
                  

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
           DialogResult dialog = MessageBox.Show("Thanks for ordering at Pizza Express. Your ordered items will be ready and delivered in 30 minutes. Do you want to order some more?", "Exit", MessageBoxButtons.YesNo);

           if (dialog == DialogResult.Yes)
           {

               //Clearing all data
               checkBox1.Checked = false;
               checkBox2.Checked = false;
               checkBox3.Checked = false;
               checkBox4.Checked = false;
               checkBox5.Checked = false;
               checkBox7.Checked = false;
               checkBox8.Checked = false;
               checkBox19.Checked = false;
               checkBox20.Checked = false;
               checkBox21.Checked = false;

               textBox1.Text = "";
               textBox5.Text = "";
               textBox6.Text = "";
               textBox7.Text = "";

               listView1.Items.Clear();
               textBox8.Text = "";
               textBox9.Text = "";
               textBox10.Text = "";

               textBox11.Text = "";
               textBox12.Text = "";
               textBox13.Text = "";
               textBox14.Text = "";
               textBox15.Text = "";
               textBox16.Text = "";
               textBox17.Text = "";
               textBox18.Text = "";
               textBox19.Text = "";
               textBox20.Text = "";
               textBox21.Text = "";
               comboBox1.Text = "";
               comboBox2.Text = "";

               tabControl1.SelectTab("tabPage1");
           }

           else if(dialog == DialogResult.No)
           {
               this.Close();
           }
        
        
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Cash")
            {
                textBox18.Enabled = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 
//cpfn
