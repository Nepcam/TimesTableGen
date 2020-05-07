using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// NAME: Cameron Nepe
// ID:   1262199  


namespace TimesTableGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                //Variables
                int minValue = 0;
                int maxValue = 9;
                int result = 0;
                //GET minimum value
                minValue = int.Parse(textBoxMinNum.Text);
                //GET maximum value
                maxValue = int.Parse(textBoxMaxNum.Text);
                //IF max >= min THEN
                if (maxValue >= minValue)
                {   //FOR each value from min value to max value
                    for (int i = minValue; i <= maxValue; i++)
                    {
                        //Display header for times table
                        Console.WriteLine(i + " Times Table");
                        for (int j = 1; j <= 9; j++)
                        {
                            //Your pseudo - code goes here
                            result = j * i;
                            Console.WriteLine(j.ToString() + " * " + i.ToString() + " = " + result.ToString());
                        }
                        Console.WriteLine("");
                    }
                }
                else
                {//DISPLAY error message
                    Console.WriteLine("Your min value should be between 0-9");
                }
            }
            catch (Exception ex)
            {
                //Display error message
                Console.WriteLine(ex.Message);
                //Clear text boxes
                textBoxMinNum.Clear();
                textBoxMaxNum.Clear();
                //Set focus
                textBoxMinNum.Focus();
            }
        }
    }
}
