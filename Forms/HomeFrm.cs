using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGV_Clone.Forms
{
    public partial class HomeFrm : Form
    {
        public HomeFrm()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void Login_Click(object sender, EventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            loginFrm.Show();
        }
        private void Updating()
        {
            MessageBox.Show("Chức năng đang được nâng cấp!","Thông báo");
        }

        private void MovieShowingMenu_Click(object sender, EventArgs e)
        {
            Updating();
        }

        private void MovieUpcomingMenu_Click(object sender, EventArgs e)
        {
            Updating();
        }

        private void CinemaMenu_Click(object sender, EventArgs e)
        {
            Updating();
        }

        private void Cinema3DMenu_Click(object sender, EventArgs e)
        {
            Updating();
        }

        private void SpecialCinemaMenu_Click(object sender, EventArgs e)
        {
            Updating();
        }

        
    }
}
