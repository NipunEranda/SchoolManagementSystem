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
using System.Data;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Grid;
using System.Drawing;

using Syncfusion.Pdf.Graphics;

namespace SchoolManagementSystem
{
    public partial class Timetable : Form
    {
        int Grade = 0;
        public static string SendClass = "";
        public static string SendGrade = "";
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TM7VHQ4;Initial Catalog=sms;Integrated Security=True");
        public Timetable()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Create_Timetable openForm = new Create_Timetable();
            openForm.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GradeSelector.SelectedItem == null || ClassSelector.SelectedItem == null)
            {
                SendGrade = "1";
                SendClass = "A";
            }
            else
            {
                SendGrade = GradeSelector.SelectedItem.ToString();
                SendClass = ClassSelector.SelectedItem.ToString();
            }
                New_Update openForm = new New_Update();
                openForm.Show();
                Visible = false;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String ClassID;
            if (GradeSelector.SelectedIndex == -1 || ClassSelector.SelectedIndex == -1)
            {
                Grade = 1;
                ClassID = "A";
            }
            else
            {
                Grade = Int32.Parse(GradeSelector.SelectedItem.ToString());
                ClassID = ClassSelector.SelectedItem.ToString();
            }

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select TimeSlot , Monday , Tuesday , Wednesday , Thursday , Friday from dbo.TTable where ClassID = '" + ClassID + "' AND Grade = " + Grade;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();

            if (dt.Rows.Count > 0)
            {

                //Create a new PDF document
                PdfDocument doc = new PdfDocument();

                //Add a page
                PdfPage page = doc.Pages.Add();

                //Create a PdfGrid
                PdfGrid pdfGrid = new PdfGrid();

                PdfPageTemplateElement header =  AddHeader(doc);


                //Create a DataTable
                DataTable dataTable = dt;

                //Assign data source
                pdfGrid.DataSource = dataTable;

                //Initialize grid style.
                PdfGridStyle gridStyle = new PdfGridStyle();

                //Add cell padding.
                gridStyle.CellPadding = new PdfPaddings(5, 5, 5, 5);

                //Apply style to grid.
                pdfGrid.Style = gridStyle;

                //Draw grid to the page of PDF document
                pdfGrid.Draw(page, new PointF(10, 10));
              

                //Save the document
                String outputName = "Timetable" + Guid.NewGuid().ToString("N") + ".pdf";
                doc.Save(outputName);

                //Close the document
                doc.Close(true);

                System.Diagnostics.Process.Start(outputName);
            }
            else
            {
                MessageBox.Show("There is no timetable to display as a pdf");
            }
        }

        private void Timetable_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select TimeSlot , Monday , Tuesday , Wednesday , Thursday , Friday from dbo.TTable where ClassID = 'A' AND Grade = 1";
            cmd.ExecuteNonQuery();
         
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
          
            Ttable.DataSource = dt;
            con.Close();
            Ttable.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
           
            GradeSelector.SelectedItem = "1";
            ClassSelector.SelectedItem = "A";

            TimeTableLabel.Text =  "1 - A Time Table";


        }

        private void GradeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ClassSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private static PdfPageTemplateElement AddHeader(PdfDocument doc)
        {
            RectangleF bounds = new RectangleF(0, 0, doc.Pages[0].GetClientSize().Width, 50);
            //Create a page template for header
            PdfPageTemplateElement header = new PdfPageTemplateElement(bounds);
            //Draw the rectangle in header
            header.Graphics.DrawRectangle(PdfPens.DarkBlue, bounds);
            //Draw the image in header
          
            return header;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (GradeSelector.SelectedIndex == -1 || ClassSelector.SelectedIndex == -1)
            {
                MessageBox.Show("Class and Grade should be selected before delete ");
            }
            else
            {

                Grade = Int32.Parse(GradeSelector.SelectedItem.ToString());
                String ClassID = ClassSelector.SelectedItem.ToString();

                String message_text = "Are you sure you want to delete "+ Grade + " - " + ClassID + " timetable ?";
                DialogResult dialogResult = MessageBox.Show( message_text , "Delete Timetable", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM dbo.TTable WHERE ClassID = '" + ClassID + "' AND Grade = " + Grade;
                    int id = cmd.ExecuteNonQuery();
                    con.Close();
                    if( id > 0)
                    {
                        MessageBox.Show( "" + Grade + " - " + ClassID + " Timetable Deleted");
                        Ttable.DataSource = null;
                        Ttable.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                  
                }

               


            }
        }

        private void Ttable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String ClassID = "";
            
            if (GradeSelector.SelectedIndex == -1 || ClassSelector.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both class and grade");
            }
            else {

                Grade = Int32.Parse(GradeSelector.SelectedItem.ToString());
                ClassID = ClassSelector.SelectedItem.ToString();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select TimeSlot , Monday , Tuesday , Wednesday , Thursday , Friday from dbo.TTable where ClassID = '" + ClassID + "' AND Grade = " + Grade;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                Ttable.DataSource = dt;
                con.Close();

                TimeTableLabel.Text = Grade + " - " + ClassID + " Time Table";
            
             }
        }
    }
}
