namespace JkimAssignment2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.txtColums = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNone = new System.Windows.Forms.Button();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pbxWall = new System.Windows.Forms.PictureBox();
            this.pbxRedDoor = new System.Windows.Forms.PictureBox();
            this.pbxGreenDoor = new System.Windows.Forms.PictureBox();
            this.pbxRedBox = new System.Windows.Forms.PictureBox();
            this.pbxGreenBox = new System.Windows.Forms.PictureBox();
            this.pbxNone = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRedDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGreenDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGreenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNone)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(64, 31);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(82, 25);
            this.txtRow.TabIndex = 1;
            // 
            // txtColums
            // 
            this.txtColums.Location = new System.Drawing.Point(227, 31);
            this.txtColums.Name = "txtColums";
            this.txtColums.Size = new System.Drawing.Size(82, 25);
            this.txtColums.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rows:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Colums:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(336, 20);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(137, 43);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 15F);
            this.label3.Location = new System.Drawing.Point(29, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "ToolBox";
            // 
            // btnNone
            // 
            this.btnNone.Location = new System.Drawing.Point(12, 110);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(143, 57);
            this.btnNone.TabIndex = 7;
            this.btnNone.Text = "None";
            this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNone.UseVisualStyleBackColor = true;
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.Location = new System.Drawing.Point(12, 425);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Size = new System.Drawing.Size(143, 57);
            this.btnGreenBox.TabIndex = 9;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenBox.UseVisualStyleBackColor = true;
            // 
            // btnRedBox
            // 
            this.btnRedBox.Location = new System.Drawing.Point(12, 362);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Size = new System.Drawing.Size(143, 57);
            this.btnRedBox.TabIndex = 11;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedBox.UseVisualStyleBackColor = true;
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.Location = new System.Drawing.Point(12, 299);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(143, 57);
            this.btnGreenDoor.TabIndex = 13;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenDoor.UseVisualStyleBackColor = true;
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.Location = new System.Drawing.Point(12, 236);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Size = new System.Drawing.Size(143, 57);
            this.btnRedDoor.TabIndex = 15;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedDoor.UseVisualStyleBackColor = true;
            // 
            // btnWall
            // 
            this.btnWall.Location = new System.Drawing.Point(12, 173);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(143, 57);
            this.btnWall.TabIndex = 17;
            this.btnWall.Text = "Wall";
            this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "None.png");
            this.imageList.Images.SetKeyName(1, "Wall.jpg");
            this.imageList.Images.SetKeyName(2, "reddoor.jpg");
            this.imageList.Images.SetKeyName(3, "greendoor.jpg");
            this.imageList.Images.SetKeyName(4, "redbox.jpg");
            this.imageList.Images.SetKeyName(5, "greenbox.jpg");
            // 
            // pbxWall
            // 
            this.pbxWall.Image = global::JkimAssignment2.Properties.Resources.Wall;
            this.pbxWall.Location = new System.Drawing.Point(15, 180);
            this.pbxWall.Name = "pbxWall";
            this.pbxWall.Size = new System.Drawing.Size(57, 42);
            this.pbxWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxWall.TabIndex = 18;
            this.pbxWall.TabStop = false;
            // 
            // pbxRedDoor
            // 
            this.pbxRedDoor.Image = global::JkimAssignment2.Properties.Resources.reddoor2;
            this.pbxRedDoor.Location = new System.Drawing.Point(15, 243);
            this.pbxRedDoor.Name = "pbxRedDoor";
            this.pbxRedDoor.Size = new System.Drawing.Size(57, 42);
            this.pbxRedDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRedDoor.TabIndex = 16;
            this.pbxRedDoor.TabStop = false;
            // 
            // pbxGreenDoor
            // 
            this.pbxGreenDoor.Image = global::JkimAssignment2.Properties.Resources.greendoor;
            this.pbxGreenDoor.Location = new System.Drawing.Point(15, 306);
            this.pbxGreenDoor.Name = "pbxGreenDoor";
            this.pbxGreenDoor.Size = new System.Drawing.Size(57, 42);
            this.pbxGreenDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGreenDoor.TabIndex = 14;
            this.pbxGreenDoor.TabStop = false;
            // 
            // pbxRedBox
            // 
            this.pbxRedBox.Image = global::JkimAssignment2.Properties.Resources.redbox;
            this.pbxRedBox.Location = new System.Drawing.Point(15, 369);
            this.pbxRedBox.Name = "pbxRedBox";
            this.pbxRedBox.Size = new System.Drawing.Size(57, 42);
            this.pbxRedBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRedBox.TabIndex = 12;
            this.pbxRedBox.TabStop = false;
            // 
            // pbxGreenBox
            // 
            this.pbxGreenBox.Image = global::JkimAssignment2.Properties.Resources.greenbox;
            this.pbxGreenBox.Location = new System.Drawing.Point(15, 432);
            this.pbxGreenBox.Name = "pbxGreenBox";
            this.pbxGreenBox.Size = new System.Drawing.Size(57, 42);
            this.pbxGreenBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGreenBox.TabIndex = 10;
            this.pbxGreenBox.TabStop = false;
            // 
            // pbxNone
            // 
            this.pbxNone.Image = global::JkimAssignment2.Properties.Resources.None;
            this.pbxNone.Location = new System.Drawing.Point(15, 117);
            this.pbxNone.Name = "pbxNone";
            this.pbxNone.Size = new System.Drawing.Size(57, 42);
            this.pbxNone.TabIndex = 8;
            this.pbxNone.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 686);
            this.Controls.Add(this.pbxWall);
            this.Controls.Add(this.btnWall);
            this.Controls.Add(this.pbxRedDoor);
            this.Controls.Add(this.btnRedDoor);
            this.Controls.Add(this.pbxGreenDoor);
            this.Controls.Add(this.btnGreenDoor);
            this.Controls.Add(this.pbxRedBox);
            this.Controls.Add(this.btnRedBox);
            this.Controls.Add(this.pbxGreenBox);
            this.Controls.Add(this.btnGreenBox);
            this.Controls.Add(this.pbxNone);
            this.Controls.Add(this.btnNone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtColums);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Design Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRedDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGreenDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGreenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.TextBox txtColums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.PictureBox pbxNone;
        private System.Windows.Forms.PictureBox pbxGreenBox;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.PictureBox pbxRedBox;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.PictureBox pbxGreenDoor;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.PictureBox pbxRedDoor;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.PictureBox pbxWall;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

