﻿using System;
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
        bool[,] arrOpen = new bool[12, 12]; // đánh dấu mảng arr đã mở những ô nào
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
            int sizeX = 300 + 10 + col * 50 + 50; // 300: từ 0->panel, 10 : lề từ panel -> button 1 , 50 : button size(50) + lề(0), 50 : từ panel -> footer
            int sizeY = 50 + 10 + row * 50 + 50 + 24; // 24 : menustrip
            this.Size = new Size(sizeX, sizeY);
            panelMain.Size = new Size(10 + col * 50 + 5, 10 + row * 50 + 5);
            panelMain.Location = new Point(280, 50);
            LoadBOOMArray();
            LoadBOOMScreen();
        }

        #region Event
        private void LoadBOOMArray()
        {
            // create '0' character
            for (int i=0;i<12;i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    arr[i, j] = '0';
                    arrOpen[i, j] = false; // đánh dấu chưa mở
                }
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
                    btn.Size = new Size(50, 50);
                    btn.Name = "btn" + i.ToString() + j.ToString(); // btn01,btn02,btn03,...
                    btn.Text = "";
                    btn.BackColor = Color.Red;
                    btn.Location = new Point(Xlocal, Ylocal);
                    btn.Click += Btn_Click;
                    panelMain.Controls.Add(btn);
                    Xlocal += 50;
                }
                Xlocal = 10;
                Ylocal += 50;
            }
        }

        private void LoadBOOMScreenDefeat()
        {
            int Xlocal = 10, Ylocal = 10;
            panelMain.Controls.Clear();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(50, 50);
                    btn.Name = "btn" + i.ToString() + j.ToString(); // btn01,btn02,btn03,...
                    if (arrOpen[i+1,j+1]==true && arr[i+1,j+1]!='B')
                    {
                        btn.Text = arr[i+1,j+1].ToString();
                        btn.Font = new Font("Arial", 22F, FontStyle.Bold);
                        btn.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        btn.Text = "";
                    }
                    btn.BackColor = Color.Red;
                    btn.Location = new Point(Xlocal, Ylocal);
                    //btn.Click += Btn_Click;
                    if (arr[i+1,j+1]=='B')
                    {
                        btn.BackColor = Color.White;
                        Bitmap avt = new Bitmap(Application.StartupPath + "\\Resources\\Mine.png");
                        btn.Image = avt;
                    }
                    panelMain.Controls.Add(btn);
                    Xlocal += 55;
                }
                Xlocal = 10;
                Ylocal += 55;
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
            arrOpen[arr_i, arr_j] = true; // đánh dấu đã mở ô này
            if (arr[arr_i,arr_j]=='B')
            {
                LoadBOOMScreenDefeat();
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
            var btn = MessageBoxButtons.OKCancel;
            var img = MessageBoxIcon.Question;
            var title = "Thông báo";
            var msg = "Bạn muốn lưu lại thông tin ván đấu hiện tại?";
            var res = MessageBox.Show(msg, title, btn, img);
            if (res == DialogResult.OK) // save
            {
                lưuVánToolStripMenuItem_Click(sender, e);
            }
            else
            {
                this.Close();
            }
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var btn = MessageBoxButtons.OK;
            var img = MessageBoxIcon.Information;
            var title = "Giới thiệu";
            var msg = "Boom game, v2.1. Date release : 02/09/2020";
            MessageBox.Show(msg, title, btn, img);
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var btn = MessageBoxButtons.OK;
            var img = MessageBoxIcon.Information;
            var title = "Tác giả";
            var msg = "Nguyễn Hữu Hòa, Khoa CNTT,\nTrường đại học KHTN - ĐHQGTPHCM";
            MessageBox.Show(msg, title, btn, img);
        }

        private void cáchChơiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var btn = MessageBoxButtons.OK;
            var img = MessageBoxIcon.Information;
            var title = "Cách chơi";
            var msg = "1. Cấu hình game, cài đặt kích thước, số boom\n2. Click chọn những ô không có boom\n3. Nếu có boom, end game\nChức năng gắng cờ dùng để đánh dấu boom khá hữu dụng đó bạn :))\nCố gắng gỡ hết boom bạn nhé. Good luck";
            MessageBox.Show(msg, title, btn, img);
        }

        private void vánMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var btn = MessageBoxButtons.OKCancel;
            var img = MessageBoxIcon.Question;
            var title = "Thông báo";
            var msg = "Bạn muốn lưu lại thông tin ván đấu hiện tại?";
            var res = MessageBox.Show(msg, title, btn, img);
            if (res == DialogResult.OK) // save
            {
                lưuVánToolStripMenuItem_Click(sender, e);
            }
            else
            {
                LoadBOOMArray();
                panelMain.Controls.Clear();
                LoadBOOMScreen();
            }
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
