using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class Events : subWindows
    {
        MainClass main = MainClass.getInstance();
        private String btnStatus = "view";
        private int eid = -1;
        schoolDBDataContext obj = new schoolDBDataContext();
        
        
        
        public Events()
        {
            InitializeComponent();
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm:ss";
        }

        private void Event_Load(object sender, EventArgs e)
        {
            MainClass.setCurrentForm(new Events());
            MainClass.mdi.topic.Text = "Event";
            loadEvent();
            privillegeCheck();

           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            if (btnStatus == "add")
            {
                btnStatus = "view";

                MainClass.disable(panel5);
            }
            else
            {
                btnStatus = "add";
                MainClass.enable(panel5);

            }
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            if (btnStatus == "edit")
            {
                btnStatus = "view";

                MainClass.disable(panel5);
            }
            else
            {
                btnStatus = "edit";

                MainClass.enable(panel5);
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (eid > 0)
            {
                btnStatus = "view";


                DialogResult dr = MessageBox.Show("Do you want to delete " + enameTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.event_delete(eid);
                    MainClass.showMsg(enameTxt.Text + "Deleted Successfully", "Success", "success");
                    MainClass.disable_reset(panel5);
                    loadEvent();
                }
                else { }
            }
            else
            {
                MainClass.showMsg("Select a record first ", "error", "error");
            }
        }

        public override void ViewBtn_Click(object sender, EventArgs e)
        {
            btnStatus = "view";

            loadEvent();
            MainClass.disable_reset(panel5);

        }

        public override void SearchBtn_Click(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel5);
            var dataSet = obj.event_search(searchTxt.Text);
            eventIDGV.DataPropertyName = "eventID";
            eventNameGV.DataPropertyName = "eventName";
            dateGV.DataPropertyName = "date";
            venueGV.DataPropertyName = "venue";
            timeGV.DataPropertyName = "time";
            eventGridView.DataSource = dataSet;
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel5);
            var dataSet = obj.event_search(searchTxt.Text);
            eventIDGV.DataPropertyName = "eventID";
            eventNameGV.DataPropertyName = "eventName";
            dateGV.DataPropertyName = "date";
            venueGV.DataPropertyName = "venue";
            timeGV.DataPropertyName = "time";
            eventGridView.DataSource = dataSet;
        }



        public override void adSearch_Click(object sender, EventArgs e)
        {

        }

        private void ename_Click(object sender, EventArgs e)
        {

        }

        private void etime_Click(object sender, EventArgs e)
        {

        }

        private void evenue_Click(object sender, EventArgs e)
        {

        }

        private void edate_Click(object sender, EventArgs e)
        {

        }






        public void loadEvent()
        {
            MainClass.disable_reset(panel5);
            var dataSet = obj.event_getEvent();
            eventIDGV.DataPropertyName = "eventID";
            eventNameGV.DataPropertyName = "eventName";
            dateGV.DataPropertyName = "date";
            venueGV.DataPropertyName = "venue";
            timeGV.DataPropertyName = "time";
            eventGridView.DataSource = dataSet;
        }

        public int fieldCheck()
        {
            int status = 0;
            if (enameTxt.Text == "")
            {
                MainClass.showMsg("Event name cannot be empty", "Stop", "error");
            }
            else if (evenueTxt.Text == "")
            {
                MainClass.showMsg("Venue cannot be empty", "Stop", "error");
            }
            else
                status = 1;
            return status;
        }

        private void eventGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void acceptBtn_Click_1(object sender, EventArgs e)
        {
            
            if (fieldCheck() == 1)
            {
                if (btnStatus == "add")
                {
                    Events ev = new Events();

                    if (enameTxt.Text != "")
                    {

                        String timeString = dateTimePicker2.Text;
                        TimeSpan timeValue = TimeSpan.Parse(timeString);
                        //DateTime date = DateTime.ParseExact(timeString, "h:mm:ss tt", CultureInfo.InvariantCulture);
                        obj.event_insert(enameTxt.Text, MainClass.getDateFromString(dateTimePicker1.Text), evenueTxt.Text,timeValue);
                        obj.SubmitChanges();
                        MainClass.showMsg(enameTxt.Text + " added successfully", "Success", "success");
                    }

                    else
                    {
                        MainClass.showMsg(enameTxt.Text + dateTimePicker1 + evenueTxt + dateTimePicker2 + "complete the all the fields", "error", "error");
                    }

                }

                else if (btnStatus == "edit")
                {
                    Events ev = new Events();

                    if (enameTxt.Text != "")

                 {
                        String timeString = dateTimePicker2.Text;
                        TimeSpan timeValue = TimeSpan.Parse(timeString);

                        obj.event_update(enameTxt.Text, MainClass.getDateFromString(dateTimePicker1.Text),evenueTxt.Text,timeValue,Convert.ToInt32(eIdTxt.Text));

                        MainClass.showMsg(enameTxt.Text + " updated successfully", "Success", "success");
                    }

                    else
                    {
                        MainClass.showMsg(enameTxt.Text + dateTimePicker1 + evenueTxt + dateTimePicker2 + eIdTxt + "complete the all the fields", "error", "error");
                    }
                }

                MainClass.disable_reset(panel5);
                loadEvent();
            }
        }

        private void eventGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = eventGridView.Rows[e.RowIndex];
                eid = Convert.ToInt32(row.Cells["eventIDGV"].Value.ToString());

            }


            }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime myVacation1 = new DateTime(2019, 4, 28);

            monthCalendar1.AddBoldedDate(myVacation1);
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            MainClass.showWindow(new Home(), this, MDI.ActiveForm);
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
           // MainClass.showWindow(new EventReports(), this, MDI.ActiveForm);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
