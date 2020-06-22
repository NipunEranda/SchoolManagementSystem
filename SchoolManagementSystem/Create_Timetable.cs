using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace SchoolManagementSystem
{
    public partial class Create_Timetable : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TM7VHQ4;Initial Catalog=sms;Integrated Security=True");
        public Create_Timetable()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            ArrayList Timetable = new ArrayList(8);

            TimetableSlot t1 = new TimetableSlot();
            t1.monday = M1.SelectedItem.ToString();
            t1.tuesday = T1.SelectedItem.ToString();
            t1.wednesday = W1.SelectedItem.ToString();
            t1.thursday = TS1.SelectedItem.ToString();
            t1.friday = F1.SelectedItem.ToString();
            t1.timeslot = "7.45 - 8.25";

            Timetable.Add(t1);

            TimetableSlot t2 = new TimetableSlot();
            t2.monday = M2.SelectedItem.ToString();
            t2.tuesday = T2.SelectedItem.ToString();
            t2.wednesday = W2.SelectedItem.ToString();
            t2.thursday = TS2.SelectedItem.ToString();
            t2.friday = F2.SelectedItem.ToString();
            t2.timeslot = "8.25 - 9.05";

            Timetable.Add(t2);
            //MessageBox.Show( t1.monday + " " + t1.tuesday + " " + t1.wednesday + " " + t1.thursday + " " + t1.friday );


            TimetableSlot t3 = new TimetableSlot();
            t3.monday = M3.SelectedItem.ToString();
            t3.tuesday = T3.SelectedItem.ToString();
            t3.wednesday = W3.SelectedItem.ToString();
            t3.thursday = TS3.SelectedItem.ToString();
            t3.friday = F3.SelectedItem.ToString();
            t3.timeslot = "9.05 - 9.45";

            Timetable.Add(t3);


            TimetableSlot t4 = new TimetableSlot();
            t4.monday = M4.SelectedItem.ToString();
            t4.tuesday = T4.SelectedItem.ToString();
            t4.wednesday = W4.SelectedItem.ToString();
            t4.thursday = TS4.SelectedItem.ToString();
            t4.friday = F4.SelectedItem.ToString();
            t4.timeslot = "9.45 - 10.25";

            Timetable.Add(t4);


            TimetableSlot t5 = new TimetableSlot();
            t5.monday = "";
            t5.tuesday = "";
            t5.wednesday = "";
            t5.thursday = "";
            t5.friday = "";
            t5.timeslot = "10.25 - 10.45";

            Timetable.Add(t5);


            TimetableSlot t6 = new TimetableSlot();
            t6.monday = M5.SelectedItem.ToString();
            t6.tuesday = T5.SelectedItem.ToString();
            t6.wednesday = W5.SelectedItem.ToString();
            t6.thursday = TS5.SelectedItem.ToString();
            t6.friday = F5.SelectedItem.ToString();
            t6.timeslot = "10.45 - 11.25";

            Timetable.Add(t6);


            TimetableSlot t7 = new TimetableSlot();
            t7.monday = M6.SelectedItem.ToString();
            t7.tuesday = T6.SelectedItem.ToString();
            t7.wednesday = W6.SelectedItem.ToString();
            t7.thursday = TS6.SelectedItem.ToString();
            t7.friday = F6.SelectedItem.ToString();
            t7.timeslot = "11.25 - 12.00";

            Timetable.Add(t7);


            TimetableSlot t8 = new TimetableSlot();
            t8.monday = M7.SelectedItem.ToString();
            t8.tuesday = T7.SelectedItem.ToString();
            t8.wednesday = W7.SelectedItem.ToString();
            t8.thursday = TS7.SelectedItem.ToString();
            t8.friday = F7.SelectedItem.ToString();
            t8.timeslot = "12.00 - 12.45";

            Timetable.Add(t8);


            TimetableSlot t9 = new TimetableSlot();
            t9.monday = M8.SelectedItem.ToString();
            t9.tuesday = T8.SelectedItem.ToString();
            t9.wednesday = W8.SelectedItem.ToString();
            t9.thursday = TS8.SelectedItem.ToString();
            t9.friday = F8.SelectedItem.ToString();
            t9.timeslot = "12.45 - 1.20";

            Timetable.Add(t9);

            if (checkAllNone(Timetable))
            {
                MessageBox.Show("At least one column must be filled to submit..");
            }
            else if (grade.SelectedIndex == -1)
            {
                MessageBox.Show("Grade Should be filled");
            }
            else if (classID.SelectedIndex == -1)
            {
                MessageBox.Show("Class Should be filled");
            }
            else
            {

                String classX = classID.SelectedItem.ToString();
                int gradeX = Int32.Parse(grade.SelectedItem.ToString());

                con.Open();
                SqlCommand cmdx = con.CreateCommand();
                cmdx.CommandType = CommandType.Text;
                cmdx.CommandText = "select Count(*) from dbo.TTable where ClassID = '" + classX + "' and Grade = " + gradeX;
                Int32 count = (Int32)cmdx.ExecuteScalar();
                con.Close();

                if (count > 0)
                {
                    MessageBox.Show(gradeX + " - " + classX + " Timetable is already in the system.");
                }
                else
                {
                    int rowcount = 0;
                    foreach (TimetableSlot slot in Timetable)
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "Insert into  dbo.TTable (TimeSlot , Monday , Tuesday , Wednesday , Thursday , Friday , ClassID , Grade ) values (@time, @mon, @tue, @wed, @thu, @fri, @classID, @grade); ";
                        cmd.Parameters.AddWithValue("@time", slot.timeslot);
                        cmd.Parameters.AddWithValue("@mon", slot.monday);
                        cmd.Parameters.AddWithValue("@tue", slot.tuesday);
                        cmd.Parameters.AddWithValue("@wed", slot.wednesday);
                        cmd.Parameters.AddWithValue("@thu", slot.thursday);
                        cmd.Parameters.AddWithValue("@fri", slot.friday);
                        cmd.Parameters.AddWithValue("@classID", classX);
                        cmd.Parameters.AddWithValue("@grade", gradeX);
                        rowcount += cmd.ExecuteNonQuery();
                        con.Close();
                    }
                  
                    if(rowcount == 9)
                    {
                        MessageBox.Show("Time table has been successfully created");
                    }

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timetable openForm = new Timetable();
            openForm.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Create_Timetable openForm = new Create_Timetable();
            openForm.Show();
            Visible = false;
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox42_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox41_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public Boolean checkAllNone(ArrayList array)
        {
            int count = 0;
            foreach (TimetableSlot slot in array)
            {

                if (slot.monday.Equals("None") && slot.tuesday.Equals("None")
                    && slot.wednesday.Equals("None") && slot.thursday.Equals("None") && slot.friday.Equals("None"))
                {
                    count += 1;
                }
            }
            if (count == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
