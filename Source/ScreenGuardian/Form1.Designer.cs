namespace ScreenLogger
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
      this.takeScreenShot_button = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.goSilent_button = new System.Windows.Forms.Button();
      this.timeInterval_textBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.timeFormat_comboBox = new System.Windows.Forms.ComboBox();
      this.pictureFormat_comboBox = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.openCaptureLocation_button = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label4 = new System.Windows.Forms.Label();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.button1 = new System.Windows.Forms.Button();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.saveFolder_textBox = new System.Windows.Forms.TextBox();
      this.captureLocationBrowse_button = new System.Windows.Forms.Button();
      this.timer2 = new System.Windows.Forms.Timer(this.components);
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      this.groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // takeScreenShot_button
      // 
      this.takeScreenShot_button.Location = new System.Drawing.Point(6, 5);
      this.takeScreenShot_button.Name = "takeScreenShot_button";
      this.takeScreenShot_button.Size = new System.Drawing.Size(226, 23);
      this.takeScreenShot_button.TabIndex = 0;
      this.takeScreenShot_button.Text = "TakeScreenShot";
      this.takeScreenShot_button.UseVisualStyleBackColor = true;
      this.takeScreenShot_button.Click += new System.EventHandler(this.takeScreenShot_button_Click);
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // goSilent_button
      // 
      this.goSilent_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.goSilent_button.Location = new System.Drawing.Point(7, 34);
      this.goSilent_button.Name = "goSilent_button";
      this.goSilent_button.Size = new System.Drawing.Size(225, 31);
      this.goSilent_button.TabIndex = 1;
      this.goSilent_button.Text = "StartLogging";
      this.goSilent_button.UseVisualStyleBackColor = true;
      this.goSilent_button.Click += new System.EventHandler(this.startLogging_button_Click);
      // 
      // timeInterval_textBox
      // 
      this.timeInterval_textBox.Location = new System.Drawing.Point(75, 80);
      this.timeInterval_textBox.Name = "timeInterval_textBox";
      this.timeInterval_textBox.Size = new System.Drawing.Size(70, 20);
      this.timeInterval_textBox.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(10, 83);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "TimeInterval";
      // 
      // timeFormat_comboBox
      // 
      this.timeFormat_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.timeFormat_comboBox.FormattingEnabled = true;
      this.timeFormat_comboBox.Items.AddRange(new object[] {
            "Millisec(s)",
            "Second(s)",
            "Minute(s)",
            "Hour(s)"});
      this.timeFormat_comboBox.Location = new System.Drawing.Point(151, 80);
      this.timeFormat_comboBox.Name = "timeFormat_comboBox";
      this.timeFormat_comboBox.Size = new System.Drawing.Size(81, 21);
      this.timeFormat_comboBox.TabIndex = 4;
      // 
      // pictureFormat_comboBox
      // 
      this.pictureFormat_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.pictureFormat_comboBox.FormattingEnabled = true;
      this.pictureFormat_comboBox.Items.AddRange(new object[] {
            "Jpeg",
            "Bmp",
            "Png",
            "Tiff",
            "Gif"});
      this.pictureFormat_comboBox.Location = new System.Drawing.Point(84, 15);
      this.pictureFormat_comboBox.Name = "pictureFormat_comboBox";
      this.pictureFormat_comboBox.Size = new System.Drawing.Size(61, 21);
      this.pictureFormat_comboBox.TabIndex = 6;
      this.pictureFormat_comboBox.SelectedIndexChanged += new System.EventHandler(this.imageFormat_comboBox_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(7, 18);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(68, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "ImageFormat";
      // 
      // openCaptureLocation_button
      // 
      this.openCaptureLocation_button.Location = new System.Drawing.Point(6, 49);
      this.openCaptureLocation_button.Name = "openCaptureLocation_button";
      this.openCaptureLocation_button.Size = new System.Drawing.Size(107, 23);
      this.openCaptureLocation_button.TabIndex = 8;
      this.openCaptureLocation_button.Text = "Open";
      this.openCaptureLocation_button.UseVisualStyleBackColor = true;
      this.openCaptureLocation_button.Click += new System.EventHandler(this.openImagesFolder_button_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 44);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(62, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "JpegQuality";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.goSilent_button);
      this.groupBox1.Controls.Add(this.takeScreenShot_button);
      this.groupBox1.Controls.Add(this.timeInterval_textBox);
      this.groupBox1.Controls.Add(this.timeFormat_comboBox);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(12, 58);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(241, 109);
      this.groupBox1.TabIndex = 11;
      this.groupBox1.TabStop = false;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.numericUpDown1);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.pictureFormat_comboBox);
      this.groupBox2.Location = new System.Drawing.Point(12, 173);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(241, 67);
      this.groupBox2.TabIndex = 12;
      this.groupBox2.TabStop = false;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(131, 45);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(52, 13);
      this.label4.TabIndex = 11;
      this.label4.Text = "(0 -> 100)";
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Location = new System.Drawing.Point(84, 42);
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
      this.numericUpDown1.TabIndex = 10;
      this.numericUpDown1.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
      this.numericUpDown1.ValueChanged += new System.EventHandler(this.imageQualityNumericUpDown_ValueChanged);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(125, 49);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(107, 23);
      this.button1.TabIndex = 13;
      this.button1.Text = "Clear";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.clearImagesFolder_button_Click);
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.saveFolder_textBox);
      this.groupBox3.Controls.Add(this.captureLocationBrowse_button);
      this.groupBox3.Controls.Add(this.button1);
      this.groupBox3.Controls.Add(this.openCaptureLocation_button);
      this.groupBox3.Location = new System.Drawing.Point(12, 246);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(241, 78);
      this.groupBox3.TabIndex = 14;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "CapturedImagesFolder";
      // 
      // saveFolder_textBox
      // 
      this.saveFolder_textBox.Location = new System.Drawing.Point(88, 23);
      this.saveFolder_textBox.Name = "saveFolder_textBox";
      this.saveFolder_textBox.ReadOnly = true;
      this.saveFolder_textBox.Size = new System.Drawing.Size(144, 20);
      this.saveFolder_textBox.TabIndex = 15;
      // 
      // captureLocationBrowse_button
      // 
      this.captureLocationBrowse_button.Location = new System.Drawing.Point(7, 23);
      this.captureLocationBrowse_button.Name = "captureLocationBrowse_button";
      this.captureLocationBrowse_button.Size = new System.Drawing.Size(75, 20);
      this.captureLocationBrowse_button.TabIndex = 14;
      this.captureLocationBrowse_button.Text = "Browse...";
      this.captureLocationBrowse_button.UseVisualStyleBackColor = true;
      this.captureLocationBrowse_button.Click += new System.EventHandler(this.imagesFolderBrowse_button_Click);
      // 
      // timer2
      // 
      this.timer2.Interval = 1;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::ScreenLogger.Properties.Resources.Untitled;
      this.pictureBox1.Location = new System.Drawing.Point(51, 4);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(155, 48);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 15;
      this.pictureBox1.TabStop = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(264, 333);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "ScreenLogger 1.0.0";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button takeScreenShot_button;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button goSilent_button;
    private System.Windows.Forms.TextBox timeInterval_textBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox timeFormat_comboBox;
    private System.Windows.Forms.ComboBox pictureFormat_comboBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button openCaptureLocation_button;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.TextBox saveFolder_textBox;
    private System.Windows.Forms.Button captureLocationBrowse_button;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.Timer timer2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

