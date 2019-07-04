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

        #region publicValue
        private int row, col, boom, notboom;
        char[,] arr = new char[12, 12]; // tính từ 1-10, 0 vs 11 dùng để làm các biên
                                      // vd
                                      // 0  0  0  0
                                      // 0  B  3  0
                                      // 0  B  B  0
                                      // 0  B  3  0
                                      // 0  0  0  0
        #endregion

        public MainForm(int row, int col, int boom)
        {
            InitializeComponent();
            this.row = row;
            txtRow.Text = row.ToString();
            this.col = col;
            txtCol.Text = col.ToString();
            this.boom = boom;
            txtBoom.Text = boom.ToString();
            this.notboom = row * col - boom;
            int sizeX = 300 + 10 + col * 70 + 50; // 300: từ 0->panel, 10 : lề từ panel -> button 1 , 70 : button size(60) + lề(10), 50 : từ panel -> footer
            int sizeY = 50 + 10 + row * 70 + 50 + 24; // 24 : menustrip
            this.Size = new Size(sizeX, sizeY);
            panelMain.Size = new Size(10 + col * 70, 10 + row * 70);
            panelMain.Location = new Point(300, 50);
            LoadBOOMArray();
            LoadBOOMScreen();
        }

        #region Event
        private void LoadBOOMArray()
        {
            // create '0' character
            for (int i=0;i<12;i++)
            {
                for (int j = 0; j < 12; j++) arr[i, j] = '0';
            }

            // create randomize boom
            Random r = new Random();
            int _b = boom;
            while (_b > 0)
            {
                int ri = r.Next(1, row + 1); // ri = between(1,row)
                int ry = r.Next(1, col + 1);
                if (arr[ri, ry] != 'B')
                {
                    arr[ri, ry] = 'B';
                    _b--;
                }
            }

            // create count boom
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if (arr[i, j] != 'B')
                    {
                        int ct = countBOOM(i, j);
                        arr[i, j] = Convert.ToChar(ct + 48);
                    }
                }
            }

            // debug xem đúng chưa
            //string s = "";
            //for (int i=1;i<=row;i++)
            //{
            //    for (int j=1;j<=col;j++)
            //    {
            //        s += arr[i, j].ToString();
            //    }
            //    s += "\n";
            //}
            //MessageBox.Show(s);
        }

        private int countBOOM(int i,int j)
        {
            int res = 0;
            for (int x = i - 1;x <= i + 1;x++)
            {
                for (int y=j-1;y<=j+1;y++)
                {
                    // đếm trong phạm vi ô vuông 3x3 xung quanh ô [i,j] có bao nhiêu boom
                    if (arr[x, y] == 'B')
                    {
                        res++;
                    }
                }
            }
            return res;
        }

        private void LoadBOOMScreen()
        {
            int Xlocal = 10, Ylocal = 10;
            for (int i = 0;i<row;i++)
            {
                for (int j=0;j<col;j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(60, 60);
                    btn.Name = "btn" + i.ToString() + j.ToString(); // btn01,btn02,btn03,...
                    btn.Text = "";
                    btn.BackColor = Color.Red;
                    btn.Location = new Point(Xlocal, Ylocal);
                    btn.Click += Btn_Click;
                    panelMain.Controls.Add(btn);
                    Xlocal += 70;
                }
                Xlocal = 10;
                Ylocal += 70;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //char c = '3';
            //MessageBox.Show("Clicked!" + (c-'0').ToString());
            var b = sender as Button;
            //MessageBox.Show(b.Name);

            if (b.Text != "") return;
            string txt = b.Name; // ex : txt01
            int arr_i = (txt[3] - '0') + 1;
            int arr_j = (txt[4] - '0') + 1;
            if (arr[arr_i,arr_j]=='B')
            {
                MessageBox.Show("BOOMMMM!");
            }
            else
            {
                b.Text = arr[arr_i, arr_j].ToString();
                b.Font = new Font("Arial", 22F, FontStyle.Bold);
                b.ForeColor = Color.Yellow;

                notboom--;
                if (notboom==0) // winner
                {
                    MessageBox.Show("Winner!");
                }
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
