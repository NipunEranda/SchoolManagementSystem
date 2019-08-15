using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Events : Form
    {

        MainClass main = MainClass.getInstance();

        public Events()
        {
            InitializeComponent();
            ControlBox = false;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6TO1UR3\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True");
        public int eventID;

        private void Form1_Load(object sender, EventArgs e)
        {
            GetEventRecord();

        }

        private void GetEventRecord()
        {

            SqlCommand cmd = new SqlCommand("select * from EventTb", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            EventGridView.DataSource = dt;

        }



        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();

        }



        private void hideBtn_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == false)
                monthCalendar1.Visible = true;
            else
                monthCalendar1.Visible = false;
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }





        private void venue_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT EventTb (eventName, date,venue, time) VALUES (@eventName, @date, @venue, @time)", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@eventName", enameTxt.Text);
                cmd.Parameters.AddWithValue("@date", main.getDateFromString(dateTimePicker1.Text));
                cmd.Parameters.AddWithValue("@venue", venueTxt.Text);
                cmd.Parameters.AddWithValue("@time", main.getDateFromString(dateTimePicker2.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New event is successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetEventRecord();
                ResetFormControls();

            }
        }

        private bool IsValid()
        {
            if (enameTxt.Text == string.Empty)
            {
                MessageBox.Show("Event name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void seaBtn_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void ResetFormControls()
        {
            eventID = 0;
            enameTxt.Clear();
            venueTxt.Clear();

            enameTxt.Focus();
        }

        private void EventGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eventID = Convert.ToInt32(EventGridView.SelectedRows[0].Cells[0].Value);
            enameTxt.Text = EventGridView.SelectedRows[0].Cells[1].Value.ToString();
            venueTxt.Text = EventGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (eventID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE EventTb SET eventName = @eventName,date = @date,venue = @venue,time = @time WHERE eventID = @eventID)", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@eventName", enameTxt.Text);
                cmd.Parameters.AddWithValue("@date", main.getDateFromString(dateTimePicker1.Text));
                cmd.Parameters.AddWithValue("@venue", venueTxt.Text);
                cmd.Parameters.AddWithValue("@time", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@eventID", this.eventID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Event details are updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetEventRecord();
                ResetFormControls();
            }

            else
            {
                MessageBox.Show("Select an event to update details", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (eventID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM EventTb WHERE eventID = @eventID)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@eventID", this.eventID);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Event details are deleted from the system", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetEventRecord();
                ResetFormControls();
            }

            else
            {
                MessageBox.Show("Select an event to delete", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void enameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

    }

}
