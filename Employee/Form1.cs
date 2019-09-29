using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            //Create an object of the ProductionWorker class
            ProductionWorker worker = new ProductionWorker();

            //Retrieve the object's properties
            worker.EmployeeName = EmployeeNameTextBox.Text;
            worker.EmployeeNumber = (Int32.Parse(EmployeeNumberTextBox.Text));
            worker.ShiftNumber = (Int32.Parse(comboBox1.Text));
            worker.HourlyPayRate = (Double.Parse(PayRateTextBox.Text));

            //Display object values
            MessageBox.Show("Name: " + worker.EmployeeName + "\n" + "Number: " + worker.EmployeeNumber
                + "\n" + "Shift: " + worker.ShiftNumber + "\n" + "Pay Rate: $" + worker.HourlyPayRate);
        }
    }
}
