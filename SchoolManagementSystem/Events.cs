using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Events : subWindows
    {
        MainClass main = MainClass.getInstance();
        private String btnStatus = "view";
        private int eid;
        schoolDBDataContext obj = new schoolDBDataContext();
        public Events()
        {
            InitializeComponent();
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
                MainClass.enable_reset(panel5);

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
            if (enameTxt.Text != "")
            {
                btnStatus = "view";


                DialogResult dr = MessageBox.Show("Do you want to delete " + enameTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.event_delete(eid);
                    MainClass.showMsg(enameTxt.Text + "Deleted successfully", "Success", "success");
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
            eventGridView.DataSource = dataSet;
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel5);
            var dataSet = obj.event_search(searchTxt.Text);
            eventIDGV.DataPropertyName = "eventID";
            eventNameGV.DataPropertyName = "eventName";
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
            edateGv.DataPropertyName = "date";
            evenueGV.DataPropertyName = "venue";
            etimeGV.DataPropertyName = "time";
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




    }
}
