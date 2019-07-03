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
            this.col = col;
            this.boom = boom;
        }
    }
}
