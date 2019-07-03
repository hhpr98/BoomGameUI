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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int row, col, boom;

        public MainForm(int row,int col,int boom)
        {
            InitializeComponent();
            this.row = row;
            txtRow.Text = row.ToString();
            this.col = col;
            txtCol.Text = col.ToString();
            this.boom = boom;
            txtBoom.Text = boom.ToString();
            int sizeX = 300 + 10 + row * 70 + 50; // 300: từ 0->panel, 10 : lề từ panel -> button 1 , 70 : button size(60) + lề(10), 50 : từ panel -> footer
            int sizeY = 50 + 10 + col * 70 + 50 + 24; // 24 : menustrip
            this.Size = new Size(sizeX,sizeY);
            panelMain.Size = new Size(10 + row * 70, 10 + col * 70);
            panelMain.Location = new Point(300, 50);

            LoadBOOM();
        }

        #region Event
        private void LoadBOOM()
        {
            int Xlocal = 10, Ylocal = 10;
            for (int i = 0;i<col;i++)
            {
                for (int j=0;j<row;j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(60, 60);
                    btn.BackColor = Color.Red;
                    btn.Location = new Point(Xlocal, Ylocal);
                    panelMain.Controls.Add(btn);
                    Xlocal += 70;
                }
                Xlocal = 10;
                Ylocal += 70;
            }
        }
        #endregion

        #region MenuEvent
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cấuHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cáchChơiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vánMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void chơiTiếpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lưuVánToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
