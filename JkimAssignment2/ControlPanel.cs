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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JkimAssignment2
{    // this is for q puzzle
    // Junbeom Kim Sep 2020
    public partial class ControlPanel : Form
    {
        //initialize panel
        public ControlPanel()
        {
            InitializeComponent();
        }
        // make button for design
        private void btnDesign_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
        //make button for exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayForm play = new PlayForm();
            play.Show();
        }
    }
}
