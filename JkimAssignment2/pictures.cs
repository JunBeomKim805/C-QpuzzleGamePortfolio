using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JkimAssignment2
{
    //make class to save pictures
    public class pictures : PictureBox
    {
        private int row = 0;
        private int col = 0;
        private int type = 0;
        public int Row { get => row; set => row = value; }
        public int Col { get => col; set => col = value; }
        public int Type { get => type; set => type = value; }
        //make construtors to get values
        public pictures(int row=0,int col=0,int type=0)
        {
            Row = row;
            Col = col;
            Type = type;
            this.Width = 50;
            this.Height = 50;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
                if (type == 0)
                {
                    this.Image = JkimAssignment2.Properties.Resources.None;
                }
                if (type == 1)
                {
                this.Image = JkimAssignment2.Properties.Resources.Wall;
                }
                if (type == 2)
                {
                this.Image = JkimAssignment2.Properties.Resources.reddoor;
                }
                if (type == 3)
                {
                this.Image = JkimAssignment2.Properties.Resources.greendoor;
                }
                if (type == 4)
                {
                this.Image = JkimAssignment2.Properties.Resources.redbox;
                }
                if (type == 5)
                {
                this.Image = JkimAssignment2.Properties.Resources.greenbox;
                }
            
        }


    }
}
