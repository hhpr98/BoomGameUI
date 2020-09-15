using BoomProject.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        int win = 0, lose = 0;
        #endregion

        public MainForm(int row, int col, int boom)
        {
            InitializeComponent();
            
            // set image
            Bitmap img = new Bitmap(Application.StartupPath + "\\Resources\\ic_reset.png");
            btnReset.Image = img;
            //btnReset.BackgroundImageLayout = ImageLayout.Stretch;

            // init
            Init(row, col, boom);
            LoadBOOMArray();
            LoadBOOMScreen();
        }

        private void Init(int row, int col, int boom)
        {
            this.row = row;
            txtRow.Text = row.ToString();
            this.col = col;
            txtCol.Text = col.ToString();
            this.boom = boom;
            txtBoom.Text = boom.ToString();
            int sizeX = 300 + 10 + col * 50 + 50; // 300: từ 0->panel, 10 : lề từ panel -> button 1 , 50 : button size(50) + lề(0), 50 : từ panel -> footer
            int sizeY = 50 + 10 + row * 50 + 50 + 24; // 24 : menustrip
            this.Size = new Size(sizeX, sizeY);
            panelMain.Size = new Size(10 + col * 50 + 8, 10 + row * 50 + 8);
            panelMain.Location = new Point(280, 50);
        }

        #region Event
        private void LoadBOOMArray()
        {
            // not boom
            this.notboom = row * col - boom; // fix bug #6

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
            //for (int i = 1; i <= row; i++)
            //{
            //    for (int j = 1; j <= col; j++)
            //    {
            //        s += arr[i, j].ToString();
            //    }
            //    s += "\n";
            //}
            //MessageBox.Show(s);
        }

        private void LoadBOOMArrayContinue(GameConfig gameConfig)
        {
            row = gameConfig.row;
            col = gameConfig.col;
            boom = gameConfig.boom;
            notboom = row * col - boom; // fix bug #6
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    arr[i, j] = gameConfig.arr[i, j];
                    arrOpen[i, j] = gameConfig.arrOpen[i, j];
                }
            }
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
            for (int i = 1;i<=row;i++)
            {
                for (int j=1;j<=col;j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(50, 50);
                    btn.Name = "btn" + i.ToString() + j.ToString(); // btn11,btn12,btn13,btn21,...
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

        // Load những boom chưa mở sau khi thất bại
        private void LoadBOOMScreenDefeat()
        {
            int Xlocal = 10, Ylocal = 10;
            panelMain.Controls.Clear();
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(50, 50);
                    btn.Name = "btn" + i.ToString() + j.ToString(); // btn11,btn12,btn13,btn21,...
                    if (arrOpen[i,j]==true && arr[i,j]!='B')
                    {
                        btn.Text = arr[i,j].ToString();
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
                    if (arr[i,j]=='B')
                    {
                        btn.BackColor = Color.White;
                        Bitmap avt = new Bitmap(Application.StartupPath + "\\Resources\\Mine.png");
                        btn.Image = avt;
                    }
                    panelMain.Controls.Add(btn);
                    Xlocal += 50;
                }
                Xlocal = 10;
                Ylocal += 50;
            }
        }

        // Load chơi game tiếp
        private void LoadBOOMScreenContinue()
        {
            int Xlocal = 10, Ylocal = 10;
            panelMain.Controls.Clear();
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(50, 50);
                    btn.Name = "btn" + i.ToString() + j.ToString(); // btn11,btn12,btn13,btn21,...
                    if (arrOpen[i, j] == true && arr[i, j] != 'B')
                    {
                        notboom--; // fix bug #6
                        btn.Text = arr[i, j].ToString();
                        btn.Font = new Font("Arial", 22F, FontStyle.Bold);
                        btn.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        btn.Text = "";
                    }
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

        private void Btn_Click(object sender, EventArgs e)
        {
            //char c = '3';
            //MessageBox.Show("Clicked!" + (c-'0').ToString());
            var b = sender as Button;
            //MessageBox.Show(b.Name);

            // nếu ô này đã mở thì thôi, return
            if (b.Text != "") return;

            string txt = b.Name; // ex : txt01
            int arr_i = (txt[3] - '0'); // tọa độ i
            int arr_j = (txt[4] - '0'); // tọa độ j
            if (arr[arr_i,arr_j]=='B') // có boom
            {
                LoadBOOMScreenDefeat();
                MessageBox.Show("BOOMMMM!");
                updateAchieve("lose");
                LoadBOOMArray();
                panelMain.Controls.Clear();
                LoadBOOMScreen();
            }
            else if (arr[arr_i, arr_j] == '0') // là ô 0, thực hiện hành động mở nó và mở những ô 0 bên cạnh
            {
                //MessageBox.Show("Is 0 character!");
                noBoomAction(arr_i, arr_j); // đánh dấu nó và những ô 0 xung quanh
            }
            else // những ô còn lại: 1,2,3,4,... mở bình thường
            {
                arrOpen[arr_i, arr_j] = true; // đánh dấu đã mở ô này
                
                b.Text = arr[arr_i, arr_j].ToString();
                b.Font = new Font("Arial", 22F, FontStyle.Bold);
                b.ForeColor = Color.Yellow;

                notboom--;
                if (notboom==0) // winner
                {
                    MessageBox.Show("Winner!");
                    updateAchieve("win");
                    LoadBOOMArray();
                    panelMain.Controls.Clear();
                    LoadBOOMScreen();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            updateAchieve("reset");
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
                this.Close();
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
            var msg = "Boom game, v3.0. Date release : 02/09/2020";
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
            var btn = MessageBoxButtons.YesNoCancel;
            var img = MessageBoxIcon.Question;
            var title = "Thông báo";
            var msg = "Bạn muốn lưu lại thông tin ván đấu hiện tại?";
            var res = MessageBox.Show(msg, title, btn, img);
            if (res == DialogResult.Yes) // save
            {
                lưuVánToolStripMenuItem_Click(sender, e);
                LoadBOOMArray();
                panelMain.Controls.Clear();
                LoadBOOMScreen();
            }
            else if (res == DialogResult.No) // don't save
            {
                LoadBOOMArray();
                panelMain.Controls.Clear();
                LoadBOOMScreen();
            }
            else // Cancel
            {
                // nothing
            }    
        }

        private void chơiTiếpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Mở game";
            openFileDialog.Filter = "Boom Game File (*.boom)|*.boom|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Application.StartupPath + @"\Resources";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(openFileDialog.FileName.ToString());
                try
                {
                    string filename = openFileDialog.FileName;
                    string[] filelines = File.ReadAllLines(filename);
                    string txt = filelines[0];
                    var gameConfig = JsonConvert.DeserializeObject<GameConfig>(txt);
                    //MessageBox.Show(gameConfig.col.ToString());
                    LoadBOOMArrayContinue(gameConfig); // load lại col,row,boom, arr & arrOpen
                    Init(row, col, boom); // load lại các thông số, chiều dài panel
                    LoadBOOMScreenContinue(); // load lại những ô đã mở

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Lỗi khi mở file",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void lưuVánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gameConfig = new GameConfig();
            gameConfig.setInfor(row, col, boom, arr, arrOpen);
            var txt = JsonConvert.SerializeObject(gameConfig);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Application.StartupPath + @"\Resources";      
            saveFileDialog.Title = "Lưu ván";
            saveFileDialog.CheckFileExists = false;
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.DefaultExt = "boom";
            saveFileDialog.Filter = "Boom Game File (*.boom)|*.boom|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, txt);
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region function
        // Tự mở chính nó (ô 0) và những ô xung quang là 0 cho nhanh
        public void noBoomAction(int i,int j) 
        {
            arrOpen[i,j] = true; // đánh dấu đã mở ô này
            notboom--;
            string btnName = "btn" + i.ToString() + j.ToString();
            var b = getButton(btnName);
            b.Text = arr[i,j].ToString();
            b.Font = new Font("Arial", 22F, FontStyle.Bold);
            b.ForeColor = Color.Yellow;

            // tự động mở những ô bên cạnh là 0 (8 ô xung quanh ô chính)
            for (int x = i - 1; x <= i + 1; x++)
            {
                for (int y = j - 1; y <= j + 1; y++)
                {
                    if (x == i & y == j) continue; // ô i,j là ô của hàm chính, đã gọi r
                    if (x < 1 || y < 1 || x > row || y > col) continue;
                    // đếm trong phạm vi ô vuông 3x3 xung quanh ô [i,j] có bao nhiêu boom
                    if (arr[x, y] == '0' && arrOpen[x,y]==false) // là ô 0 chưa mở bên cạnh ô chính
                    {
                        noBoomAction(x,y);
                    }
                }
            }
        }

        // return button with name (btn11,btn12,...)
        public Button getButton(string btnName)
        {
            foreach (Control control in panelMain.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    if (control.Name == btnName)
                    {
                        var btn = control as Button;
                        return btn;
                    }    
                }    
            }
            return new Button();
        }

        // update status achieve
        public void updateAchieve(string status)
        {
            switch (status)
            {
                case "win":
                    win++;
                    txtWin.Text = win.ToString();
                    return;
                case "lose":
                    lose++;
                    txtLose.Text = lose.ToString();
                    return;
                case "reset":
                    win = 0;
                    lose = 0;
                    txtWin.Text = "0";
                    txtLose.Text = "0";
                    return;
                default:
                    return;
            }    
        }

        #endregion
    }
}
