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
namespace SchoolManagementSystem
{
    public partial class New_Update : Form
    {
        String TimeSlot = null;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TM7VHQ4;Initial Catalog=sms;Integrated Security=True");
        public New_Update()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Timetable openForm = new Timetable();
            openForm.Show();
            Visible = false;
        }

        private void Ttable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void New_Update_Load(object sender, EventArgs e)
        {
            TableName.Text = "Grade " + Timetable.SendGrade + " - " +  Timetable.SendClass + " Time Table";
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select TimeSlot , Monday , Tuesday , Wednesday , Thursday , Friday from dbo.TTable where ClassID = '" + Timetable.SendClass + "' AND Grade = " + Timetable.SendGrade;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            TtableUpdate.DataSource = dt;
            con.Close();
        }

        private void TtableUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = TtableUpdate.Rows[indexRow];
            D1.Text = row.Cells[1].Value.ToString();
            D2.Text = row.Cells[2].Value.ToString();
              D3.Text = row.Cells[3].Value.ToString();
              D4.Text = row.Cells[4].Value.ToString();
            D5.Text = row.Cells[5].Value.ToString();
             TimeSlot = row.Cells[0].Value.ToString();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE dbo.TTable SET Monday = '"+ D1.Text +"',Tuesday = '"+ D2.Text+"',Wednesday = '"+D3.Text+"', Thursday = '"+D4.Text+"',Friday = '"+D5.Text+"' WHERE ClassID = '"+ Timetable.SendClass + "' AND Grade = "+ Int32.Parse(Timetable.SendGrade) + " AND TimeSlot = '" + TimeSlot + "'" ;
            cmd.ExecuteNonQuery();
            con.Close();

           Timetable openForm = new Timetable();
            openForm.Show();
            Visible = false;
        }
    }
}
