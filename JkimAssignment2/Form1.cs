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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JkimAssignment2
{
    // this is for q puzzle
    // Junbeom Kim Sep 2020
    public partial class Form1 : Form
    {
        Regex number = new Regex(@"^\d+$");
        Image none = JkimAssignment2.Properties.Resources.None;
        Image rb = JkimAssignment2.Properties.Resources.redbox;
        Image rd = JkimAssignment2.Properties.Resources.reddoor;
        Image gb = JkimAssignment2.Properties.Resources.greenbox;
        Image gd = JkimAssignment2.Properties.Resources.greendoor;
        Image wall = JkimAssignment2.Properties.Resources.Wall;
        int row;
        int colums;
        int top = 88;
        int left = 180;
        int width = 50;
        int height = 50;
        int wgap = 10;
        int hgap = 10;
        int type = 0;
        pictures picture = new pictures();
        List<pictures> savePictures = new List<pictures>();
        //initialize form
        public Form1()
        {
            InitializeComponent();
        }
        // make button to generate
        private void btnGenerate_Click(object sender, EventArgs e)
        {

            if (!number.IsMatch(txtRow.Text) || !number.IsMatch(txtColums.Text))
                MessageBox.Show("rows and colums must be integer");
            else
            {
                row = int.Parse(txtRow.Text);
                colums = int.Parse(txtColums.Text);
                int x = left;
                int y = top;

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        picture = new pictures(i, j);
                        picture.Image = JkimAssignment2.Properties.Resources.None;
                        picture.Left = x;
                        picture.Top = y;

                        this.Controls.Add(picture);
                        savePictures.Add(picture);

                        x += width + hgap;
                        picture.Click += imageClick;


                    }
                    x = left;
                    y += height + wgap;
                }
            }
        }
        // make button to click image
        private void imageClick(object sender, EventArgs e)
        {
            pictures select = (pictures)sender;
            if (btnWall.Focused)
            {
                select.Image = wall;
                Save(savePictures, select.Row, select.Col, SaveType(wall));
            }
            if (btnRedBox.Focused)
            {
                select.Image = rb;
                Save(savePictures, select.Row, select.Col, SaveType(rb));
            }
            if (btnRedDoor.Focused)
            {
                select.Image = rd;
                Save(savePictures, select.Row, select.Col, SaveType(rd));
            }
            if (btnGreenBox.Focused)
            {
                select.Image = gb;
                Save(savePictures, select.Row, select.Col, SaveType(gb));
            }
            if (btnGreenDoor.Focused)
            {
                select.Image = gd;
                Save(savePictures, select.Row, select.Col, SaveType(gd));
            }
            if (btnNone.Focused)
            {
                select.Image = none;
                Save(savePictures, select.Row, select.Col, SaveType(none));
            }

        }
        void Save(List<pictures> picture, int row, int column, int type)
        {
            foreach (var item in picture)
            {
                if (row == item.Row && column == item.Col)
                {
                    item.Type = type;
                }
            }
        }
        int SaveType(Image img)
        {
            int type = 0;
            if (img == wall)
                type = 1;
            if (img == rd)
                type = 2;
            if (img == gd)
                type = 3;
            if (img == rb)
                type = 4;
            if (img == gb)
                type = 5;
            return type;
        }
        // make button to save file

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int dr = 0;
            int box = 0;
            int w = 0;
            foreach (var item in savePictures)
            {
                int select = SaveType(item.Image);
                if(select == 1)
                    w++;
                if (select == 2 || select == 3)
                    dr++;
                if (select == 4 || select == 5)
                    box++; ;
            }
            SaveFileDialog saveFile = new SaveFileDialog();
            //route to save file
            saveFile.InitialDirectory = @"Desktop\";
            //type of file
            saveFile.Filter = "Text files(*.txt)|*.txt|All files(*,*)|*.*";
            saveFile.DefaultExt = "txt";
            saveFile.AddExtension = true; 
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                //take route from savefile.filename
                FileStream fileStream = new FileStream(saveFile.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(txtRow.Text);
                streamWriter.WriteLine(txtColums.Text);
                foreach(var save in savePictures)
                {
                    streamWriter.WriteLine(save.Row);
                    streamWriter.WriteLine(save.Col);
                    streamWriter.WriteLine(save.Type);
                }
                streamWriter.Close();

                string result = $"File saved +\nTotal number of walls: {w.ToString()}\nTotal number of door: {dr.ToString()}\nTotal number of boxs: {box.ToString()} ";
                MessageBox.Show(result);
            }
           


        }
        // close form
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // load form
    }
}
