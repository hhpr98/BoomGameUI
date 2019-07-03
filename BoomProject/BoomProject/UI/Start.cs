using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoomProject
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            Bitmap avt = new Bitmap(Application.StartupPath + "\\Resources\\boomImage.png");
            pbAvatar.Image = avt;
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        #region Event
        private void btnOK_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm((int)txtRow.Value, (int)txtColumn.Value, (int)txtNumBoom.Value);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
