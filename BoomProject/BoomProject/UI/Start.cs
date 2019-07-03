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
            int row = (int)txtRow.Value;
            int col = (int)txtColumn.Value;
            int boom = (int)txtNumBoom.Value;
            int maxboom = row * col - 2;
            if (boom>maxboom)
            {
                MessageBox.Show(String.Format("Số boom không thể vượt tối đa. Tối đa : {0}", maxboom), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MainForm frm = new MainForm(row,col ,boom);
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
