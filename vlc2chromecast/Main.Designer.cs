namespace vlc2chromecast
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            labelStatus = new Label();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            txtBoxPathToVideoLan = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            labelIpToChromeCast = new Label();
            txtBoxIpAdress = new TextBox();
            labelDragAndDrop = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(229, 234, 254);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Resources.logo3;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1020, 61);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1020, 61);
            panel1.TabIndex = 3;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.ForeColor = Color.DarkGreen;
            labelStatus.Location = new Point(3, 9);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(258, 15);
            labelStatus.TabIndex = 3;
            labelStatus.Text = "Trying to start Videolan and send to chromecast";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 61);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(labelStatus);
            splitContainer1.Panel2.Controls.Add(labelDragAndDrop);
            splitContainer1.Size = new Size(1020, 599);
            splitContainer1.SplitterDistance = 76;
            splitContainer1.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBoxPathToVideoLan);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(labelIpToChromeCast);
            groupBox1.Controls.Add(txtBoxIpAdress);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1020, 76);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            // 
            // txtBoxPathToVideoLan
            // 
            txtBoxPathToVideoLan.Location = new Point(117, 42);
            txtBoxPathToVideoLan.Name = "txtBoxPathToVideoLan";
            txtBoxPathToVideoLan.Size = new Size(226, 23);
            txtBoxPathToVideoLan.TabIndex = 4;
            txtBoxPathToVideoLan.Click += txtBoxPathToVideoLan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 45);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 3;
            label1.Text = "path to videolan";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(368, 42);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // labelIpToChromeCast
            // 
            labelIpToChromeCast.AutoSize = true;
            labelIpToChromeCast.Location = new Point(15, 19);
            labelIpToChromeCast.Name = "labelIpToChromeCast";
            labelIpToChromeCast.Size = new Size(96, 15);
            labelIpToChromeCast.TabIndex = 1;
            labelIpToChromeCast.Text = "ip to chromecast";
            // 
            // txtBoxIpAdress
            // 
            txtBoxIpAdress.Location = new Point(117, 16);
            txtBoxIpAdress.Name = "txtBoxIpAdress";
            txtBoxIpAdress.Size = new Size(226, 23);
            txtBoxIpAdress.TabIndex = 0;
            // 
            // labelDragAndDrop
            // 
            labelDragAndDrop.Dock = DockStyle.Fill;
            labelDragAndDrop.Enabled = false;
            labelDragAndDrop.Font = new Font("Segoe UI", 23F);
            labelDragAndDrop.Location = new Point(0, 0);
            labelDragAndDrop.Name = "labelDragAndDrop";
            labelDragAndDrop.Size = new Size(1020, 519);
            labelDragAndDrop.TabIndex = 4;
            labelDragAndDrop.Text = "Drag file here";
            labelDragAndDrop.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 660);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "Main";
            Text = "vlc2chromecast";
            FormClosing += Main_FormClosing;
            Load += Form1_Load;
            DragDrop += Main_DragDrop;
            DragEnter += Main_DragEnter;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label labelStatus;
        private SplitContainer splitContainer1;
        private Label labelIpToChromeCast;
        private TextBox txtBoxIpAdress;
        private GroupBox groupBox1;
        private Button btnSave;
        private TextBox txtBoxPathToVideoLan;
        private Label label1;
        private Label labelDragAndDrop;
    }
}
