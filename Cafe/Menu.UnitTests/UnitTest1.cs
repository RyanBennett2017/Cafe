using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using Menu;



namespace Menu.UnitTests
{
    public class ClassUnderTest
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

        public double subtotal;
        public double total;
        public double serviceCharge;
        public bool drinksOnly;
        public bool hotFood;

        string finalAmount = "Amount To Pay: \n";

        public double getValues(string custOrder)
        {

            order.item = custOrder.Split('£')[0];
            order.price = Convert.ToDouble(custOrder.Split('£')[1]);

            finalAmount += "Item Ordered: " + order.item + "\nPrice: " + order.price.ToString("C2") + "\n";

            return updateTotal();
        }

        public double updateTotal()
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

            return total;
        }

    }


    [TestClass]
    public class MenuTests
    {
        [TestMethod]
        public void Check_Total_For_Selected_Item()
        {
            double expected = 0.50;

            var classUnderTest = new ClassUnderTest();
            classUnderTest.drinksOnly = true;
            classUnderTest.hotFood = false;
            classUnderTest.subtotal = 0;
            classUnderTest.total = 0;

            double actual = classUnderTest.getValues("Cola (Cold)  £0.50");

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Check_No_Service_Charge_For_Drinks_Only()
        {
            double expected = 1.50;

            var classUnderTest = new ClassUnderTest();
            classUnderTest.drinksOnly = true;
            classUnderTest.hotFood = false;
            classUnderTest.subtotal = 0;
            classUnderTest.total = 0;

            double actual = classUnderTest.getValues("Cola (Cold)  £0.50");        
            actual =  classUnderTest.getValues("Coffee (Hot)  £1.00");
           
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void Check_Ten_Percent_Service_Charge_For_Food()
        {
            double expected = 2.20;

            var classUnderTest = new ClassUnderTest();
            classUnderTest.drinksOnly = false;
            classUnderTest.hotFood = false;
            classUnderTest.subtotal = 0;
            classUnderTest.total = 0;

            double actual = classUnderTest.getValues("Cheese Sandwich (Cold)  £2.00");

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Check_Twenty_Percent_Service_Charge_For_HOT_Food()
        {
            double expected = 5.40;

            var classUnderTest = new ClassUnderTest();
            classUnderTest.drinksOnly = false;
            classUnderTest.hotFood = true;
            classUnderTest.subtotal = 0;
            classUnderTest.total = 0;

            double actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Check_Twenty_Pound_Limit_Service_Charge_For_HOT_Food()
        {
            double expected = 123.50;

            var classUnderTest = new ClassUnderTest();
            classUnderTest.drinksOnly = false;
            classUnderTest.hotFood = true;
            classUnderTest.subtotal = 0;
            classUnderTest.total = 0;

            double actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
            actual = classUnderTest.getValues("Steak Sandwich (Hot)  £4.50");
   
            Assert.AreEqual(expected, actual);

        }


    }


    }




  

    