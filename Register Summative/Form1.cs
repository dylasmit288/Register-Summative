// Dylan Smith, November 26th 2020, Cashregister replica.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Register_Summative
{
    public partial class Form1 : Form
    {
        // Stating global variables 
        double coffeeCost = 2.25;
        double donutCost = 1.75;
        double teaCost = 2;                    
        double tax = 0.13; 
        double subTotal = 0;
        double taxAmount = 0;
        double total = 0;
        double tendered = 0;
        double changeBack = 0;
        double coffeeTotal;
        double donutTotal;
        double teaTotal;
            
        public Form1()
        {
            InitializeComponent();
        }

        private void TotalButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Taking input from text boxes and assining them to the correct variables
                coffeeTotal = Convert.ToInt32(CoffeeInput.Text);
                donutTotal = Convert.ToInt32(DonutInput.Text);
                teaTotal = Convert.ToInt32(TeaInput.Text);

                // Calculating subtotal of the order and sending it to the label to be displayed 
                subTotal = coffeeCost * coffeeTotal + donutCost * donutTotal + teaCost * teaTotal;
                Subtotal.Text = $"{subTotal.ToString("$.00")}";

                // Calculating total tax amount and sending it to the label to be displayed
                taxAmount = subTotal * tax;
                Tax.Text = $"{taxAmount.ToString("$.00")}";

                // Adding subtotal and tax together to get total and displaying in the label
                total = subTotal + taxAmount;
                Total.Text = $"{total.ToString("$.00")}";
            }
            catch
            {
                ErrorLabel.Text = "Please Enter A Numerical Value!";
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Taking input from tendered text box and giving it a variable
                tendered = Convert.ToInt32(Tendered.Text);

                // Taking the amount tendered and subtracting the total for the change back and displaying on a label
                changeBack = tendered - total;
                Change.Text = $"{changeBack.ToString("$.00")}";
            }
            catch
            {
                ErrorLabel.Text = "Please Enter A Numerical Value!";
            }

        }

        private void ReciptButton_Click(object sender, EventArgs e)
        {
            //Code to play printer sound
            SoundPlayer Dylan = new SoundPlayer(Properties.Resources.Dot_Matrix_Printer_SoundBible_com_790333844);
            Dylan.Play();
           
            //Recipt being printed one line at a time 
            ReciptTitle.Text = "Sammy's";
            Thread.Sleep(300);
            Refresh();
            Recipt.Text = "Order Number 2017";
            Thread.Sleep(300);
            Refresh();
            Recipt.Text += "\nNovember 32, 2020";
            Thread.Sleep(300);
            Refresh();
            Recipt.Text += $"\n\nCoffee       x{coffeeTotal} @ {coffeeCost.ToString("$.00")}";
            Thread.Sleep(300);
            Refresh();
            Recipt.Text += $"\nDonut        x{donutTotal} @ {donutCost.ToString("$.00")}";
            Thread.Sleep(300);
            Refresh();
            Recipt.Text += $"\nTea          x{teaTotal} @ {teaCost.ToString("$.00")}";
            Thread.Sleep(300);
            Refresh();
            Dylan.Play();
            Recipt.Text += $"\n\nSubtotal          {subTotal.ToString("$.00")} ";
            Thread.Sleep(300);
            Refresh();
            Recipt.Text += $"\nTax               {taxAmount.ToString("$.00")} ";
            Thread.Sleep(300);
            Refresh();
            Recipt.Text += $"\nTotal             {total.ToString("$.00")} ";
            Thread.Sleep(300);
            Refresh();
            Recipt.Text += $"\n\nTendered          {tendered.ToString("$.00")} ";
            Thread.Sleep(300);
            Refresh();
            Recipt.Text += $"\nChange            {changeBack.ToString("$.00")} ";
            Thread.Sleep(300);
            Refresh();
            Recipt.Text += $"\n\n\n\n        Have A Great Day!";
            Thread.Sleep(300);
            Refresh();

        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            //Code for New Order button to reset variables
            subTotal = 0;
            taxAmount = 0;
            total = 0;
            tendered = 0;
            changeBack = 0;
            coffeeTotal = 0;
            donutTotal = 0 ;
            teaTotal = 0;
            CoffeeInput.Text = "";
            DonutInput.Text = "";
            TeaInput.Text = "";
            Tendered.Text = "";
            Subtotal.Text = "";
            Tax.Text = "";
            Total.Text = "";
            Change.Text = "";
            ReciptTitle.Text = "";
            Recipt.Text = "";
        }
    }
}
