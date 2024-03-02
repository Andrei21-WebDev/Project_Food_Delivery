using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Food_Delivery.DataBase;
using Project_Food_Delivery.Entities;
using Project_Food_Delivery.Repositories;
using Project_Food_Delivery.Update_Forms;

namespace Project_Food_Delivery
{
    public partial class CustomersForm : Form
    {
        private ICustomerRepository customerRepository;

        public CustomersForm()
        {
            InitializeComponent();
            customerRepository = new CustomerRepository();
        }

        //Add Button
        private void AddButton_Click(object sender, EventArgs e)
        {
            CustomersDataGridView.Rows.Add(CustomerIDTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, DeliveryAddressTextBox.Text, PhoneNumberTextBox.Text, PaymentMethodTextBox.Text);
        }

        //Delete Function
        private void Delete()
        {
            foreach(DataGridViewRow item in this.CustomersDataGridView.SelectedRows)
            {
                CustomersDataGridView.Rows.RemoveAt(item.Index);
            }
        }

        //Delete Button
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        //Exit Function
        private void Exit()
        {
            DialogResult Exit;

            Exit = MessageBox.Show("Do you want to exit ?", "Save your work", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Clean TextBox Button
        private void CleanButton_Click(object sender, EventArgs e)
        {
            CustomerIDTextBox.Text = null;
            FirstNameTextBox.Text = null;
            LastNameTextBox.Text = null;
            DeliveryAddressTextBox.Text = null;
            PhoneNumberTextBox.Text = null;
            PaymentMethodTextBox.Text = null;
        }

        private void Customers_Load(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            OrdersForm OrdersDataGridView = new OrdersForm();
            OrdersDataGridView.ShowDialog();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateCustomersDataGridView UpdateCustomersDataGridView = new UpdateCustomersDataGridView();
            UpdateCustomersDataGridView.ShowDialog();
        }

    }
}