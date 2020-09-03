using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomProject.Model
{
    class GameConfig
    {
        public int row { get; set; }
        public int col { get; set; }
        public int boom { get; set; }
        public char[,] arr {get; set; }
        public bool[,] arrOpen { get; set; }

        public void setInfor(int _row,int _col,int _boom, char[,] _arr, bool[,] _arrOpen)
        {
            this.row = _row;
            this.col = _col;
            this.boom = _boom;
            this.arr = new char[12, 12];
            this.arrOpen = new bool[12, 12];
            for (int i=0;i<12;i++)
            {
                for (int j=0;j<12;j++)
                {
                    arr[i, j] = _arr[i, j];
                    arrOpen[i, j] = _arrOpen[i, j];
                }    
            }    
        }
    }
}
