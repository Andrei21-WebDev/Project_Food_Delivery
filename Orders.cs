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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        //Add Button
        private void AddButton_Click(object sender, EventArgs e)
        {
           
            //OrdersDataGridView.DataSource = Lista.....
            OrdersDataGridView.Rows.Add(OrderIDTextBox.Text, ProductNameTextBox.Text, RestaurantTextBox.Text, QuantityTextBox.Text, PriceTextBox.Text, DeliveryCostTextBox.Text);
        }

        //Delete Function
        private void Delete()
        {
            foreach (DataGridViewRow item in this.OrdersDataGridView.SelectedRows)
            {
                OrdersDataGridView.Rows.RemoveAt(item.Index);
            }
        }

        //Delete Button
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        //Clean Button
        private void CleanButton_Click(object sender, EventArgs e)
        {
            OrderIDTextBox.Text = null;
            ProductNameTextBox.Text = null;
            RestaurantTextBox.Text = null;
            QuantityTextBox.Text = null;
            PriceTextBox.Text = null;
            DeliveryCostTextBox.Text = null;
        }

        private void OrderIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            LiveryForm LiveryForm = new LiveryForm();
            LiveryForm.ShowDialog();
            Hide();
        }

        private void OrdersDataGridView_CellEndEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            foreach (DataGridViewRow row in OrdersDataGridView.Rows)
            {
                row.Cells["Total Cost"].Value = (Convert.ToDouble(row.Cells["Quantity"].Value) * Convert.ToDouble(row.Cells["Price/Unit"].Value)) + Convert.ToDouble(row.Cells["Delivery Cost"].Value);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateOrdersDataGridView UpdateOrdersDataGridView = new UpdateOrdersDataGridView();
            UpdateOrdersDataGridView.ShowDialog();
        }
    }
}
