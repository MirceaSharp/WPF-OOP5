using System;
using System.Collections.Generic;
using System.Windows;

namespace WPF_OOP5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            List<Employee> EmployeesList = new List<Employee>();

            if (rdCommission.IsChecked == true)
            {
                CommissionWorker myCommissionWorker = new CommissionWorker(txtFirst.Text, txtLast.Text, Convert.ToDecimal(txtSalary.Text), Convert.ToDecimal(txtNumber.Text), Convert.ToInt32(txtCommission.Text));
                EmployeesList.Add(myCommissionWorker);
                lbDisplay.ItemsSource = EmployeesList;


            }
            else if (rdEmployee.IsChecked == true)
            {
                Employee myEmployee = new Employee(txtFirst.Text, txtLast.Text, Convert.ToDecimal(txtSalary.Text));
            }
            else if (rdHourly.IsChecked == true)

            {
                HourlyWorker myHourlyWorker = new HourlyWorker(txtFirst.Text, txtLast.Text, Convert.ToDecimal(txtSalary.Text), Convert.ToInt32(txtNumber.Text));

            }
            else if(rdTemporary.IsChecked ==true)
            {
                TemporaryWorker myTemporaryWorker = new TemporaryWorker(txtFirst.Text, txtLast.Text, Convert.ToDecimal(txtSalary), Convert.ToInt32(txtNumber.Text));

            }
            else
            {

            }
        }
    }
}
