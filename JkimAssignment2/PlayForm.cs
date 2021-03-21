/*My name is Junbeom Kim
 * My student number is 8644548
 * Revision:
 * purpose is to make q puzzle.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JkimAssignment2
{
    // this is for q puzzle
    // Junbeom Kim Dec 2020
    public partial class PlayForm : Form
    {
        pictures picture = new pictures();
        List<pictures> loadImage = new List<pictures>();
        Image none = JkimAssignment2.Properties.Resources.None;
        Image rb = JkimAssignment2.Properties.Resources.redbox;
        Image rd = JkimAssignment2.Properties.Resources.reddoor;
        Image gb = JkimAssignment2.Properties.Resources.greenbox;
        Image gd = JkimAssignment2.Properties.Resources.greendoor;
        Image wall = JkimAssignment2.Properties.Resources.Wall;
        int top = 88;
        int left = 180;
        int width = 50;
        int height = 50;
        int wgap = 10;
        int hgap = 10;
        int rowWidth;
        int colHeight;
        int a = 0;
        // Initialize form
        public PlayForm()
        {
            InitializeComponent();
        }
        //close it
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // make stripmenu for loading item
        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadImage.Clear();
            panelResult.Controls.Clear();
            txtMoves.Text = "0";
            txtBoxes.Text = "0";
            a = 0;
            OpenFileDialog openFile = new OpenFileDialog();
                if (openFile.ShowDialog() == DialogResult.OK)
                {

                    if (Path.GetExtension(openFile.FileName) == ".rtf")
                    {
                        txtResult.LoadFile(openFile.FileName, RichTextBoxStreamType.RichText);
                    }
                    if (Path.GetExtension(openFile.FileName) == ".txt")
                    {
                        txtResult.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
                    }
                rowWidth = Convert.ToInt32(txtResult.Lines[0]);
                colHeight = Convert.ToInt32(txtResult.Lines[1]);

                int[,] load = new int[rowWidth, colHeight];
                int[] type = new int[rowWidth * colHeight];
                int x = left;
                int y = top;
                int count = 0;


                for (int i = 0; i < rowWidth * colHeight; i++)
                {
                    type[i] = Convert.ToInt32(txtResult.Lines[4 + (3 * i)]);
                }
                txtResult.Clear();
                for (int i = 0; i < rowWidth; i++)
                {
                    for (int j = 0; j < colHeight; j++)
                    {

                        picture = new pictures(i, j,type[count]);
                        panelResult.Controls.Add(picture);
                        loadImage.Add(picture);
                        count++;

                        picture.Left = x;
                        picture.Top = y;

                        x += width + hgap;
                        picture.Click += imageClick;
                    }
                    x = left;
                    y += height + wgap;
                }
                getType();
                if (getType() != null)
                    txtBoxes.Text = getType().ToString();

            }

        }
        //make click method to check image
        private void imageClick(object sender, EventArgs e)
        {
            picture = (pictures)sender;
            SetFocus();
        }
        // make method for get tile to compare last tile
        private pictures getTile(int row,int col)
        {
            foreach (var item in loadImage)
            {
                if (row == item.Row && col == item.Col)
                    return item;
            }
            return null;
        }
        // make method to get type to count remain boxes
        private int getType()
        {
            int count = 0;
            foreach (var item in loadImage)
            {
                if (item.Type == 4 || item.Type == 5)
                    count++;
             }
            return count;
        }
        // make method count number;
        private int getNumber()
        {
            a++;
            return a;
        }
        //make method count number;
        private int loseNumber()
        {
            a--;
            return a;
        }
        //make method to make click function
        private void SetFocus()
        {
            foreach (pictures item in panelResult.Controls)
                item.BorderStyle = BorderStyle.None;


            if (picture.Type == 4 || picture.Type == 5)
                picture.BorderStyle = BorderStyle.Fixed3D;
            else
                MessageBox.Show("you can choose only box");
        }
        //make up button
        private void btnUp_Click(object sender, EventArgs e)
        {

            if (picture.Type != 4 && picture.Type != 5)
                MessageBox.Show("choose it first");
            else
            {
                int row = picture.Row;
                int col = picture.Col;
                int type = picture.Type;
                txtMoves.Text = getNumber().ToString();
                if (type == 4)
                {

                    if (getTile(row - 1, col).Type == 3)
                    {
                        txtMoves.Text = loseNumber().ToString();
                        MessageBox.Show("Cant go up");

                    }
                }
                if (type == 5)
                {

                    if (getTile(row - 1, col).Type == 2)
                    {
                        txtMoves.Text = loseNumber().ToString();
                        MessageBox.Show("Cant go up");


                    }
                }

                if (getTile(row - 1, col).Type == 1 || getTile(row - 1, col).Type == 4 || getTile(row - 1, col).Type == 5)
                {
                    txtMoves.Text = loseNumber().ToString();
                    MessageBox.Show("Cant go up");
                }
                    while (getTile(row - 1, col).Type == 0)
                    {
                        row--;
                    if (row == 0)
                        break;
                    }



                picture.Image = none;
                picture.Type = 0;

                picture = getTile(row, col);
                picture.Type = type;
                for (int i = 0; i < 6; i++)
                {
                    if (type == 4)
                        picture.Image = rb;
                    if (type == 5)
                        picture.Image = gb;
                };
                if (type == 4)
                {
                    if (getTile(row - 1, col).Type == 2)
                    {
                        picture.Image = none;
                        picture.Type = 0;
                    }

                }
                if (type == 5)
                {
                    if (getTile(row - 1, col).Type == 3)
                    {
                        picture.Image = none;
                        picture.Type = 0;
                    }
                }

                int a = 0;
                foreach (var item in loadImage)
                {
                    if (item.Type == 4 || item.Type == 5)
                        a = 1;
                }
                if (getType() != null)
                    txtBoxes.Text = getType().ToString();
                if (a == 0)
                {
                    MessageBox.Show("Congrats!");
                    panelResult.Controls.Clear();
                }
            }
        }
        //make down button
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (picture.Type != 4 && picture.Type != 5)
                MessageBox.Show("choose it first");
            else
            {
                int row = picture.Row;
                int col = picture.Col;
                int type = picture.Type;
                txtMoves.Text = getNumber().ToString();

                if (type == 4)
                {

                    if (getTile(row + 1, col).Type == 3)
                    {
                        txtMoves.Text = loseNumber().ToString();
                        MessageBox.Show("Cant go down");


                    }
                }
                if (type == 5)
                {
                    if (getTile(row + 1, col).Type == 2)
                    {
                        txtMoves.Text = loseNumber().ToString();
                        MessageBox.Show("Cant go down");


                    }
                }
                if (getTile(row + 1, col).Type == 1 || getTile(row + 1, col).Type == 4 || getTile(row + 1, col).Type == 5)
                {
                    txtMoves.Text = loseNumber().ToString();
                    MessageBox.Show("Cant go down");
                }

                while (getTile(row + 1, col).Type == 0)
                {
                    row++;
                }
                picture.Image = none;
                picture.Type = 0;

                picture = getTile(row, col);
                picture.Type = type;
                for (int i = 0; i < 6; i++)
                {
                    if (type == 4)
                        picture.Image = rb;
                    if (type == 5)
                        picture.Image = gb;
                };
                if (type == 4)
                {
                    if (getTile(row + 1, col).Type == 2)
                    {
                        picture.Image = none;
                        picture.Type = 0;
                    }
                }
                if (type == 5)
                {
                    if (getTile(row + 1, col).Type == 3)
                    {
                        picture.Image = none;
                        picture.Type = 0;
                    }
                }
                int a = 0;
                foreach (var item in loadImage)
                {
                    if (item.Type == 4 || item.Type == 5)
                        a = 1;
                }
                if (getType() != null)
                    txtBoxes.Text = getType().ToString();
                if (a == 0)
                {
                    MessageBox.Show("Congrats!");
                    panelResult.Controls.Clear();
                }
            }
        }
        // make right button
        private void btnRight_Click(object sender, EventArgs e)
        {
            if (picture.Type != 4 && picture.Type != 5)
                MessageBox.Show("choose it first");
            else
            {
                int row = picture.Row;
                int col = picture.Col;
                int type = picture.Type;
                txtMoves.Text = getNumber().ToString();

                if (type == 4)
                {
                    if (getTile(row, col + 1).Type == 3)
                    {
                        txtMoves.Text = loseNumber().ToString();
                        MessageBox.Show("Cant go right");

                    }
                }
                if (type == 5)
                {
                    if (getTile(row, col + 1).Type == 2)
                    {
                        txtMoves.Text = loseNumber().ToString();
                        MessageBox.Show("Cant go right");


                    }
                }
                if (getTile(row, col + 1).Type == 1 || getTile(row, col + 1).Type == 4 || getTile(row, col + 1).Type == 5)
                {
                    txtMoves.Text = loseNumber().ToString();
                    MessageBox.Show("Cant go right");
                }

                while (getTile(row, col + 1).Type == 0)
                {
                    col++;
                }

                picture.Image = none;
                picture.Type = 0;

                picture = getTile(row, col);
                picture.Type = type;
                for (int i = 0; i < 6; i++)
                {
                    if (type == 4)
                        picture.Image = rb;
                    if (type == 5)
                        picture.Image = gb;
                };
                if (type == 4)
                {
                    if (getTile(row, col + 1).Type == 2)
                    {
                        picture.Image = none;
                        picture.Type = 0;
                    }

                }
                if (type == 5)
                {
                    if (getTile(row, col + 1).Type == 3)
                    {
                        picture.Image = none;
                        picture.Type = 0;
                    }
                }
                int a = 0;
                foreach (var item in loadImage)
                {
                    if (item.Type == 4 || item.Type == 5)
                        a = 1;
                }
                if (getType() != null)
                    txtBoxes.Text = getType().ToString();
                if (a == 0)
                {
                    MessageBox.Show("Congrats!");
                    panelResult.Controls.Clear();
                }
            }
        }
        //make leftbutton
        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (picture.Type != 4 && picture.Type != 5)
                MessageBox.Show("choose it first");
            else
            {
                int row = picture.Row;
                int col = picture.Col;
                int type = picture.Type;
                txtMoves.Text = getNumber().ToString();

                if (type == 4)
                {

                    if (getTile(row, col - 1).Type == 3)
                    {
                        txtMoves.Text = loseNumber().ToString();
                        MessageBox.Show("Cant go left");

                    }
                }
                if (type == 5)
                {

                    if (getTile(row, col - 1).Type == 2)
                    {
                        txtMoves.Text = loseNumber().ToString();
                        MessageBox.Show("Cant go left");

                    }
                }
                if (getTile(row, col - 1).Type == 1 || getTile(row, col - 1).Type == 4 || getTile(row, col - 1).Type == 5)
                {
                    txtMoves.Text = loseNumber().ToString();
                    MessageBox.Show("Cant go left");

                }

                while (getTile(row, col - 1).Type == 0)
                {
                    col--;

                }

                picture.Image = none;
                picture.Type = 0;

                picture = getTile(row, col);
                picture.Type = type;
                for (int i = 0; i < 6; i++)
                {
                    if (type == 4)
                        picture.Image = rb;
                    if (type == 5)
                        picture.Image = gb;
                };
                if (type == 4)
                {
                    if (getTile(row, col - 1).Type == 2)
                    {
                        picture.Image = none;
                        picture.Type = 0;
                    }

                }
                if (type == 5)
                {
                    if (getTile(row, col - 1).Type == 3)
                    {
                        picture.Image = none;
                        picture.Type = 0;
                    }

                }
                int a = 0;
                foreach (var item in loadImage)
                {
                    if (item.Type == 4 || item.Type == 5)
                        a = 1;
                }
                if (getType() != null)
                    txtBoxes.Text = getType().ToString();
                if (a == 0)
                {
                    MessageBox.Show("Congrats!");
                    panelResult.Controls.Clear();
                }
            }
        }


    }
}
