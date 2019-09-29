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
            ProductionWorker worker = new ProductionWorker();
            worker.EmployeeName = EmployeeNameTextBox.Text;
            worker.EmployeeNumber = (Int32.Parse(EmployeeNumberTextBox.Text));
            worker.ShiftNumber = (Int32.Parse(comboBox1.Text));
            worker.HourlyPayRate = (Double.Parse(PayRateTextBox.Text));

            MessageBox.Show("Name: " + worker.EmployeeName + "Number: " + worker.EmployeeNumber
                + "Shift: " + worker.ShiftNumber + "Pay Rate: " + worker.HourlyPayRate);
        }
    }
}
