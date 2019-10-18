using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysProgramingProject1
{
    public partial class ArrayProgramming1 : Form
    {
        private bool haveValidNumber;
        private decimal validNumber;

        private const int ARRAY_SIZE = 5;
        private decimal[] myData = new decimal[ARRAY_SIZE];
        private int elementsInUse = 0;
        public ArrayProgramming1()
        {
            InitializeComponent();
        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {
            //saveNumberButton.Enabled = decimal.TryParse(numberTextBox.Text.Trim(), out validNumber);

            if (decimal.TryParse(numberTextBox.Text.Trim(), out validNumber))
            {
                saveNumberButton.Enabled = true;
                Console.WriteLine(validNumber.ToString());
            }
            else
            {
                saveNumberButton.Enabled = false;
            }
        }

        private void saveNumberButton_Click(object sender, EventArgs e)
        {
            if(elementsInUse == ARRAY_SIZE)
            {
                Console.WriteLine(ARRAY_SIZE);
                MessageBox.Show("Data area is full", "Data Entry Error");
                saveNumberButton.Enabled = false;
                return;
            }
            numberDisplayListBox.Items.Add(numberTextBox.Text.Trim());

            myData[elementsInUse] = validNumber;
            elementsInUse++;
            Console.WriteLine("******************");
            for (int i = 0; i < elementsInUse; i++)
            {
                Console.WriteLine(myData[i].ToString());
            }
            
            numberTextBox.Focus();
            numberTextBox.Text = "";


        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal total = 0.0M;
            for (int i = 0; i< elementsInUse; i++)
            {
                total += myData[i];
            }
            decimal average = total / elementsInUse;

            MessageBox.Show($"Total:\t{total}\nAverage: \t{average:N3}",
                            "Statistics");
        }   
    }
}
