using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {

        public class orders
        {
            public string item;
            public double price;
        }

        const double ServiceChargeForFood = 0.10; // 10% service charge
        const double ServiceChargeForHotFood = 0.20; // 20% service charge
        const double ServiceChargeForDrinks = 0.00; // 0% service charge

        orders order = new orders();

        static double subtotal;
        static double total;
        static double serviceCharge;
        bool drinksOnly = true;
        bool hotFood = false;

        string finalAmount = "Amount To Pay: \n";


        public Form1()
        {
            InitializeComponent();
        }

        public void getValues(string custOrder)
        {

            order.item = custOrder.Split('£')[0];
            order.price = Convert.ToDouble(custOrder.Split('£')[1]);

            lstTotal.Items.Add("Price: " + order.price); 
            finalAmount += "Item Ordered: " + order.item + "\nPrice: " + order.price.ToString("C2") + "\n";

            updateTotal();
        }

        public void updateTotal()
        {
               if (drinksOnly == true)
                {
                serviceCharge = ServiceChargeForDrinks;
                }
               else if (drinksOnly == false && order.item.Contains("Steak Sandwich (Hot)"))
               {
                   serviceCharge = ServiceChargeForHotFood;
                   hotFood = true;
               }
               else if (drinksOnly == false && !hotFood)
                {
                    serviceCharge = ServiceChargeForFood;
                }


            if (Math.Round(total, 0) - Math.Round(subtotal, 0) >= 20.00)
            {
                subtotal += order.price;
                total = subtotal + 20.00;
                serviceCharge = 20.00;
            }
            else if (total - subtotal < 20.00)
            {
                subtotal += order.price;
                total += order.price + (order.price * serviceCharge);     
            }
         

            lstTotal.Items.Clear();
            lstTotal.Items.AddRange(finalAmount.Split('\n'));
            lstTotal.Items.Add("Subtotal: " + subtotal.ToString("C2"));
            lstTotal.Items.Add("Service Charge: " + serviceCharge.ToString("C2"));
            lstTotal.Items.Add("Final Amount: " + total.ToString("C2"));
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
             drinksOnly = true;
             hotFood = false;
             subtotal = 0;
             total = 0;
             finalAmount = "Amount To Pay: \n";
             cmbFood.SelectedIndex = 0;
             cmbDrink.SelectedIndex = 0;
             lstTotal.Items.Clear();      
        }

        private void cmbDrink_SelectedIndexChanged(object sender, EventArgs e)
        { 
                getValues(cmbDrink.SelectedItem.ToString());       
        }

        private void cmbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            drinksOnly = false;
            getValues(cmbFood.SelectedItem.ToString());
        }


    }
}
