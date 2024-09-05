using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int dashboardWidth = 1485;
            int dashboardHeight = 797;

            int centerX = (screenWidth - dashboardWidth) / 2;
            int centerY = (screenHeight - dashboardHeight) / 2;

            // Set the location of the dashboard
            this.Location = new Point(centerX, centerY);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 fm= new Form1();
            fm.Show();
            this.Hide();
        }

        private void ManageRoomsFinal_Click(object sender, EventArgs e)
        {
            ManageRooms1 obj=new ManageRooms1();
            obj.Show();
        }

        private void NewStudent_Click(object sender, EventArgs e)
        {
            NewStudent1 obj=new NewStudent1();
            obj.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
