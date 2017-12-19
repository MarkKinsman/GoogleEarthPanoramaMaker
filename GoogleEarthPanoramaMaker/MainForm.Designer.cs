namespace GoogleEarthPanoramaMaker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bttn_Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Lat = new System.Windows.Forms.TextBox();
            this.txt_Long = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nmc_Alt = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nmc_FOV = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nmc_WaitSec2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_RenderFPS = new System.Windows.Forms.ComboBox();
            this.txt_firstImageName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bttn_folderBrowser = new System.Windows.Forms.Button();
            this.bttn_deleteImages = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.ts_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.KMLCreator = new System.Windows.Forms.TabPage();
            this.imageReducer = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.nmc_Overlap = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nmc_WaitSec = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_Alt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_FOV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_WaitSec2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.KMLCreator.SuspendLayout();
            this.imageReducer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_Overlap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_WaitSec)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttn_Submit
            // 
            this.bttn_Submit.Location = new System.Drawing.Point(6, 140);
            this.bttn_Submit.Name = "bttn_Submit";
            this.bttn_Submit.Size = new System.Drawing.Size(267, 23);
            this.bttn_Submit.TabIndex = 0;
            this.bttn_Submit.Text = "Create KML";
            this.bttn_Submit.UseVisualStyleBackColor = true;
            this.bttn_Submit.Click += new System.EventHandler(this.bttn_Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Latitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Longitude";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(82, 5);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(206, 20);
            this.txt_Name.TabIndex = 8;
            // 
            // txt_Lat
            // 
            this.txt_Lat.Location = new System.Drawing.Point(82, 31);
            this.txt_Lat.Name = "txt_Lat";
            this.txt_Lat.Size = new System.Drawing.Size(70, 20);
            this.txt_Lat.TabIndex = 9;
            // 
            // txt_Long
            // 
            this.txt_Long.Location = new System.Drawing.Point(218, 31);
            this.txt_Long.Name = "txt_Long";
            this.txt_Long.Size = new System.Drawing.Size(70, 20);
            this.txt_Long.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Altitude";
            // 
            // nmc_Alt
            // 
            this.nmc_Alt.Location = new System.Drawing.Point(82, 57);
            this.nmc_Alt.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmc_Alt.Name = "nmc_Alt";
            this.nmc_Alt.Size = new System.Drawing.Size(70, 20);
            this.nmc_Alt.TabIndex = 12;
            this.nmc_Alt.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "FOV";
            // 
            // nmc_FOV
            // 
            this.nmc_FOV.Location = new System.Drawing.Point(218, 57);
            this.nmc_FOV.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nmc_FOV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmc_FOV.Name = "nmc_FOV";
            this.nmc_FOV.Size = new System.Drawing.Size(70, 20);
            this.nmc_FOV.TabIndex = 14;
            this.nmc_FOV.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Render FPS";
            // 
            // nmc_WaitSec2
            // 
            this.nmc_WaitSec2.DecimalPlaces = 1;
            this.nmc_WaitSec2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmc_WaitSec2.Location = new System.Drawing.Point(79, 32);
            this.nmc_WaitSec2.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nmc_WaitSec2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmc_WaitSec2.Name = "nmc_WaitSec2";
            this.nmc_WaitSec2.Size = new System.Drawing.Size(67, 20);
            this.nmc_WaitSec2.TabIndex = 19;
            this.nmc_WaitSec2.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Wait Seconds";
            // 
            // cmb_RenderFPS
            // 
            this.cmb_RenderFPS.DisplayMember = "10";
            this.cmb_RenderFPS.FormattingEnabled = true;
            this.cmb_RenderFPS.Items.AddRange(new object[] {
            "10",
            "20",
            "25",
            "30",
            "50",
            "60"});
            this.cmb_RenderFPS.Location = new System.Drawing.Point(79, 58);
            this.cmb_RenderFPS.Name = "cmb_RenderFPS";
            this.cmb_RenderFPS.Size = new System.Drawing.Size(68, 21);
            this.cmb_RenderFPS.TabIndex = 20;
            // 
            // txt_firstImageName
            // 
            this.txt_firstImageName.Location = new System.Drawing.Point(79, 6);
            this.txt_firstImageName.Name = "txt_firstImageName";
            this.txt_firstImageName.Size = new System.Drawing.Size(165, 20);
            this.txt_firstImageName.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label10.Location = new System.Drawing.Point(5, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "First Image";
            // 
            // bttn_folderBrowser
            // 
            this.bttn_folderBrowser.Location = new System.Drawing.Point(248, 5);
            this.bttn_folderBrowser.Name = "bttn_folderBrowser";
            this.bttn_folderBrowser.Size = new System.Drawing.Size(28, 20);
            this.bttn_folderBrowser.TabIndex = 23;
            this.bttn_folderBrowser.Text = "...";
            this.bttn_folderBrowser.UseVisualStyleBackColor = true;
            this.bttn_folderBrowser.Click += new System.EventHandler(this.bttn_openDialog_Click);
            // 
            // bttn_deleteImages
            // 
            this.bttn_deleteImages.Location = new System.Drawing.Point(8, 111);
            this.bttn_deleteImages.Name = "bttn_deleteImages";
            this.bttn_deleteImages.Size = new System.Drawing.Size(269, 23);
            this.bttn_deleteImages.TabIndex = 24;
            this.bttn_deleteImages.Text = "Delete Extra Images";
            this.bttn_deleteImages.UseVisualStyleBackColor = true;
            this.bttn_deleteImages.Click += new System.EventHandler(this.bttn_deleteImages_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.ts_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 204);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(9, 0, 1, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(304, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(133, 16);
            // 
            // ts_Status
            // 
            this.ts_Status.Name = "ts_Status";
            this.ts_Status.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.KMLCreator);
            this.tabControl1.Controls.Add(this.imageReducer);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(304, 202);
            this.tabControl1.TabIndex = 26;
            // 
            // KMLCreator
            // 
            this.KMLCreator.Controls.Add(this.groupBox1);
            this.KMLCreator.Controls.Add(this.label1);
            this.KMLCreator.Controls.Add(this.txt_Name);
            this.KMLCreator.Controls.Add(this.label2);
            this.KMLCreator.Controls.Add(this.txt_Lat);
            this.KMLCreator.Controls.Add(this.label3);
            this.KMLCreator.Controls.Add(this.txt_Long);
            this.KMLCreator.Controls.Add(this.bttn_Submit);
            this.KMLCreator.Controls.Add(this.nmc_FOV);
            this.KMLCreator.Controls.Add(this.nmc_Alt);
            this.KMLCreator.Controls.Add(this.label7);
            this.KMLCreator.Controls.Add(this.label6);
            this.KMLCreator.Location = new System.Drawing.Point(4, 22);
            this.KMLCreator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KMLCreator.Name = "KMLCreator";
            this.KMLCreator.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KMLCreator.Size = new System.Drawing.Size(296, 176);
            this.KMLCreator.TabIndex = 0;
            this.KMLCreator.Text = "KML Creator";
            this.KMLCreator.UseVisualStyleBackColor = true;
            // 
            // imageReducer
            // 
            this.imageReducer.Controls.Add(this.txt_firstImageName);
            this.imageReducer.Controls.Add(this.bttn_folderBrowser);
            this.imageReducer.Controls.Add(this.bttn_deleteImages);
            this.imageReducer.Controls.Add(this.label10);
            this.imageReducer.Controls.Add(this.cmb_RenderFPS);
            this.imageReducer.Controls.Add(this.nmc_WaitSec2);
            this.imageReducer.Controls.Add(this.label8);
            this.imageReducer.Controls.Add(this.label9);
            this.imageReducer.Location = new System.Drawing.Point(4, 22);
            this.imageReducer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageReducer.Name = "imageReducer";
            this.imageReducer.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageReducer.Size = new System.Drawing.Size(296, 176);
            this.imageReducer.TabIndex = 1;
            this.imageReducer.Text = "Image Reducer";
            this.imageReducer.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Overlap %";
            // 
            // nmc_Overlap
            // 
            this.nmc_Overlap.Location = new System.Drawing.Point(210, 20);
            this.nmc_Overlap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmc_Overlap.Name = "nmc_Overlap";
            this.nmc_Overlap.Size = new System.Drawing.Size(60, 20);
            this.nmc_Overlap.TabIndex = 16;
            this.nmc_Overlap.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Wait Seconds";
            // 
            // nmc_WaitSec
            // 
            this.nmc_WaitSec.DecimalPlaces = 1;
            this.nmc_WaitSec.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmc_WaitSec.Location = new System.Drawing.Point(84, 20);
            this.nmc_WaitSec.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmc_WaitSec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmc_WaitSec.Name = "nmc_WaitSec";
            this.nmc_WaitSec.Size = new System.Drawing.Size(60, 20);
            this.nmc_WaitSec.TabIndex = 18;
            this.nmc_WaitSec.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nmc_WaitSec);
            this.groupBox1.Controls.Add(this.nmc_Overlap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(8, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 51);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Advanced Settings";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 226);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PanoCreator";
            ((System.ComponentModel.ISupportInitialize)(this.nmc_Alt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_FOV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_WaitSec2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.KMLCreator.ResumeLayout(false);
            this.KMLCreator.PerformLayout();
            this.imageReducer.ResumeLayout(false);
            this.imageReducer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_Overlap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_WaitSec)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Lat;
        private System.Windows.Forms.TextBox txt_Long;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmc_Alt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmc_FOV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmc_WaitSec2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_RenderFPS;
        private System.Windows.Forms.TextBox txt_firstImageName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bttn_folderBrowser;
        private System.Windows.Forms.Button bttn_deleteImages;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel ts_Status;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage KMLCreator;
        private System.Windows.Forms.TabPage imageReducer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown nmc_Overlap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmc_WaitSec;
        private System.Windows.Forms.Label label5;
    }
}

