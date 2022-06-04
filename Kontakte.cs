using Kontakte.Models;
using System.Data;
using System.Data.SqlClient;

namespace Kontakte
{
    public partial class Kontakte : Form
    {
        public Kontakte()
        {
            InitializeComponent();
        }
        Kontakt contact = new Kontakt();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = contact.Select();
            dataGridViewContactsList.DataSource = dt;
            dataGridViewContactsList.AutoResizeColumns();
            dataGridViewContactsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //retrieve values from fields
            contact.firstName = textBoxFirstName.Text;
            contact.lastName = textBoxLastName.Text;
            contact.phoneNumber = textBoxPhoneNumber.Text;
            contact.address = textBoxAddress.Text;
            contact.email = textBoxEmail.Text;

            bool success = contact.Insert(contact);

            if(success)
            {
                //successfully inserted data
                MessageBox.Show($"New Contact {contact.firstName} {contact.lastName} successfully added !");
                //Clear the fields after inserting succesfully
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add contact. Try again");
            }
            //after inserting, load the new data on DataGridViewSearchResults field
            DataTable dt = contact.Select();
            dataGridViewContactsList.DataSource = dt;  


        }


        private void buttonClearAll_Click(object sender, EventArgs e)
        {
             Clear();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void dataGridViewContactsList_CellContentClick(object sender, EventArgs e)
        {
            

        }




        //method to clear all the fields
        public void Clear()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxAddress.Text = "";
            textBoxEmail.Text = "";
            textBoxContactID.Text = "";

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //retrieve values from fields
            contact.contactID = Convert.ToInt32(textBoxContactID.Text);
            contact.firstName = textBoxFirstName.Text;
            contact.lastName = textBoxLastName.Text;
            contact.phoneNumber = textBoxPhoneNumber.Text;
            contact.address = textBoxAddress.Text;
            contact.email = textBoxEmail.Text;

            bool success = contact.Update(contact);

            if (success)
            {
                //successfully inserted data
                MessageBox.Show($"Your Contact {contact.firstName} {contact.lastName} was successfully Updated !");
                //Clear the fields after inserting succesfully
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update contact. Try again");
            }
            //after inserting, load the new data on DataGridViewSearchResults field
            DataTable dt = contact.Select();
            dataGridViewContactsList.DataSource = dt;
        }

        private void dataGridViewContactsList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // we fill the fields with the clicked contact data from the data grid view
            int row = e.RowIndex;
            textBoxContactID.Text = dataGridViewContactsList.Rows[row].Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridViewContactsList.Rows[row].Cells[1].Value.ToString(); 
            textBoxLastName.Text = dataGridViewContactsList.Rows[row].Cells[2].Value.ToString();
            textBoxPhoneNumber.Text = dataGridViewContactsList.Rows[row].Cells[3].Value.ToString();
            textBoxAddress.Text = dataGridViewContactsList.Rows[row].Cells[4].Value.ToString();
            textBoxEmail.Text = dataGridViewContactsList.Rows[row].Cells[5].Value.ToString();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            contact.contactID = Convert.ToInt32(textBoxContactID.Text);
            bool success = contact.Delete(contact);

            if (success)
            {
                //successfully inserted data
                MessageBox.Show($"Your Contact {contact.firstName} {contact.lastName} was successfully Deleted !");
                //Clear the fields after inserting succesfully
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete contact. Try again");
            }
            //after inserting, load the new data on DataGridViewSearchResults field
            DataTable dt = contact.Select();
            dataGridViewContactsList.DataSource = dt;

        }


        static string connectionString = "Server=(local);DataBase=Kontakte; Integrated Security=true";
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //get the keyword from searchbar
            string keyword = textBoxSearch.Text;
            var conn = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
           //query
            string sql = "SELECT * FROM Table_Contact WHERE firstName LIKE '%"+keyword+ "%' OR lastName LIKE '%" + keyword + "%' OR phoneNumber LIKE '%" + keyword + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
            adapter.Fill(dt);

            //fill the data grid view with results 
            dataGridViewContactsList.DataSource = dt;
           
        

        }
    }
}