using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeSalary;

namespace EmployeeSalaryWindowsApp
{
    public partial class EmployeeSalaryUI : Form
    {
         Employee employee=new Employee();
        double incBasic;
        
        public EmployeeSalaryUI()
        {
            InitializeComponent();
            employeeInformationGroupBox.Enabled = true;
            employee.NumberOFIncrement = 0;
            saveButton.Enabled = false;
            incrementGroupBox.Enabled = false;
            salaryGroupBox.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            employee.ID = IDTextBox.Text;
            employee.Name = nameTextBox.Text;
            employee.Email = emailTextBox.Text;
            employee.Basic = Convert.ToDouble(basicTextBox.Text);
            employee.Medical = Convert.ToDouble(medicalTextBox.Text);
            employee.Conveyance = Convert.ToDouble(conveyanceTextBox.Text);
            employeeInformationGroupBox.Enabled = false;
            MessageBox.Show("Successfully Saved All INFO");
            incrementGroupBox.Enabled = true;
            salaryGroupBox.Enabled = true;
        }

        private void incrementButton_Click(object sender, EventArgs e)
        {
           
            employee.increment = Convert.ToDouble(increaseTextBox.Text);
            incBasic=employee.setIncrement();
            employee.NumberOFIncrement++;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = employee.calculateTotal();
            incReturnTextBox.Text = employee.NumberOFIncrement.ToString();
            basicReturnTextBox.Text = employee.Basic.ToString();
            medicalReturnTextBox.Text = employee.calculateMedical().ToString();
            convReturnTextBox.Text = employee.calculateConvenacne().ToString();
            totalTextBox.Text = total.ToString();
        }
        

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {
            Ebable();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            Ebable();

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            Ebable();
        }

        private void basicTextBox_TextChanged(object sender, EventArgs e)
        {
            Ebable();
        }

        private void medicalTextBox_TextChanged(object sender, EventArgs e)
        {
            Ebable();
        }

        private void conveyanceTextBox_TextChanged(object sender, EventArgs e)
        {
            Ebable();

        }

        void Ebable()
        {
            if (!string.IsNullOrWhiteSpace(IDTextBox.Text) && !string.IsNullOrWhiteSpace(nameTextBox.Text) &&
              !string.IsNullOrWhiteSpace(emailTextBox.Text) && !string.IsNullOrWhiteSpace(basicTextBox.Text) &&
              !string.IsNullOrWhiteSpace(medicalTextBox.Text) && !string.IsNullOrWhiteSpace(conveyanceTextBox.Text)
              )
            {
                saveButton.Enabled = true;
            }

            else
            {
                saveButton.Enabled = false;
            }
        }
    }
}
