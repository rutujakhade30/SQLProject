using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace HostelManagement
{
    public partial class ManageRooms1 : Form
    {
        fumction fn = new fumction();
        String query;
        public ManageRooms1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void ManageRooms1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            labelRoomExist.Visible = false;
            labelRoom.Visible = false;
            query = "select * from rooms1";
            DataSet ds = fn.getData(query);

            
            dataGridView2.DataSource = ds.Tables[0];

            
            dataGridView2.ForeColor = Color.Black; 
            dataGridView2.BackgroundColor = Color.White; 
            dataGridView2.DefaultCellStyle.Font = new Font("Arial", 10); 
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            query = "select *from rooms1 where roomNo=" + txtRoomNo1.Text + "";
            DataSet ds=fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                String status;
                if (checkBox1.Checked)
                {
                    status = "Yes";
                }
                else
                {
                    status = "No";
                }
                labelRoomExist.Visible = false;
                query = "insert into rooms1 (roomNo,roomStatus) values (" + txtRoomNo1.Text + ",'" + status + "')";
                fn.setData(query, "Room Added");
                ManageRooms1_Load(this, null);
            }
            else
            {
                labelRoomExist.Text = "Room Already Exist";
                labelRoomExist.Visible=true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select *from rooms1 where roomNo=" + txtRoomNo2.Text + "";
            DataSet ds= fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                labelRoom.Text = "No Room Exist";
                labelRoom.Visible=true;
                checkBox2.Checked = false;
            }
            else
            {
                labelRoom.Text = "Room Found";
                labelRoom.Visible=true;
                if (ds.Tables[0].Rows[0][1].ToString() == "Yes")
                {
                    checkBox2.Checked=true;
                }
                else
                {
                    checkBox2.Checked = false;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String status;
            if (checkBox2.Checked)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            query= "update rooms1 set roomStatus ='" + status + "'where roomNo="+txtRoomNo2.Text+"";
            fn.setData(query, "Details Updated");
            ManageRooms1_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(labelRoom.Text=="Room Found")
            {
                query = "delete from rooms1 where roomNo=" + txtRoomNo2.Text + "";
                fn.setData(query, "Room Details Deleted");
                ManageRooms1_Load(this, null);
            }
            else {
                MessageBox.Show("Trying to delete which doesn't Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
