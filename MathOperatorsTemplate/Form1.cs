/* date: September 2012
 * author: Mr. T.
 * purpose: template created to demonstrate math operations
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathOperatorsTemplate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void runButton_Click(object sender, EventArgs e)
        {
            //1. Declare a string variable, store your name in it, and display it
            string name = "Phoenix";
            outputLabel.Text = name;
            //2. Declare an integer variable, store your age in it, and display it
            int age = 16;
                outputLabel.Text += $"\n{age}";
            //3. Declare a double variale, store a decimal number, and display it
            Double pi = 3.14;
            outputLabel.Text += $"\n{ pi}";


            //4. Combine a text with a variable to display "Hello" followed by your name
            outputLabel.Text += $"\nHello {name}";

            /* 5. Simple arithmetic is done by using the +, -, * and / operators, 
               (plus, minus, times and divide). Results of mathematical expressions 
               should be stored in a variable. 

               Uncomment and un the code below to see what the result is. Notice that 
               the output does not show the values of x and y, but instead the words x and y. 

               Change the code to subtract y from x, and output the following:

               6 - 4 = 2
            */

            int x = 6;
            int y = 4;
            int answer = x - y;

            outputLabel.Text += $"\n\n{x} - {y} = {answer}";


            /* 6. Create a program that calculates how much money an employee has made based
               on their pay rate and the number of hours worked.


               - Create a variable to hold the rate of pay, (payRate), and set it to 15.25
               - Create a variable to hold the hours worked, (hoursWorked), and set it to 8
               - Create a variable to hold the total pay, (totalPay)
               - Calculate the total pay
               - Display the results to the screen as per the output below.

               Rate of Pay: 15.25
               Hours Worked: 8
               Total Pay: 122
            */
            int HoursWorked = 8;
            Double Payrate = 15.25;
            Double TotalPay = HoursWorked * Payrate;

            outputLabel.Text += $"\n\nPayrate: {Payrate}";
            outputLabel.Text += $"\nHours Worked: {HoursWorked}";
            outputLabel.Text += $"\nToatalpay: {TotalPay}";





            /* 7. Create a program which calculates the tax amount for meal at a restaurant.
                   
              - Create a variable to hold the bill amount, (billAmount), of 22.50
              - Create a variable to hold the tax rate, (taxRate), of 0.13
              - Create a variable to hold the tax amount, (taxAmount)
              - Calculate the tax, (billAmount * taxRate) and store it in taxAmount 

                Bill Amount: 22.50
                13% Tax: 2.925             
            */
            Double BillAmount = 22.50;
            Double TaxRate = 0.13;
            Double TaxAmount = BillAmount * TaxRate;

            outputLabel.Text += $"\n\nBillAmount: {BillAmount}";
            outputLabel.Text += $"\nTaxRate: {TaxRate}";
            outputLabel.Text += $"\nTaxAmount: {TaxAmount}";




            // 8. Increment your age variable by 1 using ++ and display it
            age++;
            outputLabel.Text += $"\n\n{age}";

            // 9. Decrement the value created above by 1 using -- and dislay it          
            age--;
            outputLabel.Text += $"\n\n{age}";

            // 10. Format the output of question 7 above to show dollar signs and 2 decimal places


        }
    }
}
