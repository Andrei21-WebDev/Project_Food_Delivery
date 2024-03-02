using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Food_Delivery.Update_Forms;

namespace Project_Food_Delivery
{
    public partial class LiveryForm : Form
    {
        public LiveryForm()
        {
            InitializeComponent();
        }

        //Add Button
        private void AddButton_Click(object sender, EventArgs e)
        {
            LiveryDataGridView.Rows.Add(LiveryIDTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, PhoneNumberTextBox.Text, PhoneNumberTextBox.Text, TraveledDistanceTextBox.Text);
        }

        //Delete Function
        private void Delete()
        {
            foreach (DataGridViewRow item in this.LiveryDataGridView.SelectedRows)
            {
                LiveryDataGridView.Rows.RemoveAt(item.Index);
            }
        }

        //Delete Button
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            LiveryIDTextBox.Text = null;
            FirstNameTextBox.Text = null;
            LastNameTextBox.Text = null;
            PhoneNumberTextBox.Text = null;
            TraveledDistanceTextBox.Text = null;
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

        //Exit Button
        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateLiveryDataGridView UpdateLiveryDataGridView = new UpdateLiveryDataGridView();
            UpdateLiveryDataGridView.ShowDialog();
        }
    }
}
