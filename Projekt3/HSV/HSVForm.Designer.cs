using System.Windows.Forms;

namespace Projekt3.HSV
{
    partial class HSVForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cameraButton = new System.Windows.Forms.Button();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.seprateChannelsButton = new System.Windows.Forms.Button();
            this.savePropertiesButton = new System.Windows.Forms.Button();
            this.saveOutputButton = new System.Windows.Forms.Button();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.grayScaleButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gammaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.whiteYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.whiteXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.blueYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.blueXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.greenYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.greenXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.redYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.redXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gammaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redXNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.Controls.Add(this.pictureBox1, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.pictureBox2, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.pictureBox3, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.groupBox2, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1155, 687);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 380);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 304);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(395, 380);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(375, 304);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(776, 380);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(376, 304);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(395, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 34);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(776, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 34);
            this.label3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 34);
            this.label1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cameraButton);
            this.groupBox1.Controls.Add(this.filterComboBox);
            this.groupBox1.Controls.Add(this.seprateChannelsButton);
            this.groupBox1.Controls.Add(this.savePropertiesButton);
            this.groupBox1.Controls.Add(this.saveOutputButton);
            this.groupBox1.Controls.Add(this.loadImageButton);
            this.groupBox1.Controls.Add(this.grayScaleButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(395, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 337);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // cameraButton
            // 
            this.cameraButton.Location = new System.Drawing.Point(7, 301);
            this.cameraButton.Margin = new System.Windows.Forms.Padding(10);
            this.cameraButton.Name = "cameraButton";
            this.cameraButton.Size = new System.Drawing.Size(123, 23);
            this.cameraButton.TabIndex = 6;
            this.cameraButton.Text = "From Camera";
            this.cameraButton.UseVisualStyleBackColor = true;
            this.cameraButton.Click += new System.EventHandler(this.cameraButton_Click);
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(7, 172);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(121, 21);
            this.filterComboBox.TabIndex = 5;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // seprateChannelsButton
            // 
            this.seprateChannelsButton.Location = new System.Drawing.Point(6, 135);
            this.seprateChannelsButton.Margin = new System.Windows.Forms.Padding(10);
            this.seprateChannelsButton.Name = "seprateChannelsButton";
            this.seprateChannelsButton.Size = new System.Drawing.Size(123, 23);
            this.seprateChannelsButton.TabIndex = 4;
            this.seprateChannelsButton.Text = "Separate Channels";
            this.seprateChannelsButton.UseVisualStyleBackColor = true;
            this.seprateChannelsButton.Click += new System.EventHandler(this.seprateChannelsButton_Click);
            // 
            // savePropertiesButton
            // 
            this.savePropertiesButton.Enabled = false;
            this.savePropertiesButton.Location = new System.Drawing.Point(6, 106);
            this.savePropertiesButton.Margin = new System.Windows.Forms.Padding(10);
            this.savePropertiesButton.Name = "savePropertiesButton";
            this.savePropertiesButton.Size = new System.Drawing.Size(123, 23);
            this.savePropertiesButton.TabIndex = 3;
            this.savePropertiesButton.Text = "Save Properties";
            this.savePropertiesButton.UseVisualStyleBackColor = true;
            // 
            // saveOutputButton
            // 
            this.saveOutputButton.Location = new System.Drawing.Point(6, 77);
            this.saveOutputButton.Margin = new System.Windows.Forms.Padding(10);
            this.saveOutputButton.Name = "saveOutputButton";
            this.saveOutputButton.Size = new System.Drawing.Size(123, 23);
            this.saveOutputButton.TabIndex = 2;
            this.saveOutputButton.Text = "Save Output";
            this.saveOutputButton.UseVisualStyleBackColor = true;
            this.saveOutputButton.Click += new System.EventHandler(this.saveOutputButton_Click);
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(6, 48);
            this.loadImageButton.Margin = new System.Windows.Forms.Padding(10);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(123, 23);
            this.loadImageButton.TabIndex = 1;
            this.loadImageButton.Text = "Load Image";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // grayScaleButton
            // 
            this.grayScaleButton.Location = new System.Drawing.Point(6, 19);
            this.grayScaleButton.Margin = new System.Windows.Forms.Padding(10);
            this.grayScaleButton.Name = "grayScaleButton";
            this.grayScaleButton.Size = new System.Drawing.Size(123, 23);
            this.grayScaleButton.TabIndex = 0;
            this.grayScaleButton.Text = "To Gray Scale";
            this.grayScaleButton.UseVisualStyleBackColor = true;
            this.grayScaleButton.Click += new System.EventHandler(this.grayScaleButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gammaNumericUpDown);
            this.groupBox2.Controls.Add(this.whiteYNumericUpDown);
            this.groupBox2.Controls.Add(this.whiteXNumericUpDown);
            this.groupBox2.Controls.Add(this.blueYNumericUpDown);
            this.groupBox2.Controls.Add(this.blueXNumericUpDown);
            this.groupBox2.Controls.Add(this.greenYNumericUpDown);
            this.groupBox2.Controls.Add(this.greenXNumericUpDown);
            this.groupBox2.Controls.Add(this.redYNumericUpDown);
            this.groupBox2.Controls.Add(this.redXNumericUpDown);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(776, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 337);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Properties";
            // 
            // gammaNumericUpDown
            // 
            this.gammaNumericUpDown.DecimalPlaces = 3;
            this.gammaNumericUpDown.Enabled = false;
            this.gammaNumericUpDown.Location = new System.Drawing.Point(239, 281);
            this.gammaNumericUpDown.Name = "gammaNumericUpDown";
            this.gammaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.gammaNumericUpDown.TabIndex = 26;
            // 
            // whiteYNumericUpDown
            // 
            this.whiteYNumericUpDown.DecimalPlaces = 8;
            this.whiteYNumericUpDown.Enabled = false;
            this.whiteYNumericUpDown.Location = new System.Drawing.Point(239, 245);
            this.whiteYNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.whiteYNumericUpDown.Name = "whiteYNumericUpDown";
            this.whiteYNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.whiteYNumericUpDown.TabIndex = 25;
            this.whiteYNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // whiteXNumericUpDown
            // 
            this.whiteXNumericUpDown.DecimalPlaces = 8;
            this.whiteXNumericUpDown.Enabled = false;
            this.whiteXNumericUpDown.Location = new System.Drawing.Point(113, 245);
            this.whiteXNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.whiteXNumericUpDown.Name = "whiteXNumericUpDown";
            this.whiteXNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.whiteXNumericUpDown.TabIndex = 24;
            this.whiteXNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // blueYNumericUpDown
            // 
            this.blueYNumericUpDown.DecimalPlaces = 8;
            this.blueYNumericUpDown.Enabled = false;
            this.blueYNumericUpDown.Location = new System.Drawing.Point(239, 210);
            this.blueYNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.blueYNumericUpDown.Name = "blueYNumericUpDown";
            this.blueYNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.blueYNumericUpDown.TabIndex = 23;
            this.blueYNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // blueXNumericUpDown
            // 
            this.blueXNumericUpDown.DecimalPlaces = 8;
            this.blueXNumericUpDown.Enabled = false;
            this.blueXNumericUpDown.Location = new System.Drawing.Point(113, 210);
            this.blueXNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.blueXNumericUpDown.Name = "blueXNumericUpDown";
            this.blueXNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.blueXNumericUpDown.TabIndex = 22;
            this.blueXNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // greenYNumericUpDown
            // 
            this.greenYNumericUpDown.DecimalPlaces = 8;
            this.greenYNumericUpDown.Enabled = false;
            this.greenYNumericUpDown.Location = new System.Drawing.Point(239, 173);
            this.greenYNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.greenYNumericUpDown.Name = "greenYNumericUpDown";
            this.greenYNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.greenYNumericUpDown.TabIndex = 21;
            this.greenYNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // greenXNumericUpDown
            // 
            this.greenXNumericUpDown.DecimalPlaces = 8;
            this.greenXNumericUpDown.Enabled = false;
            this.greenXNumericUpDown.Location = new System.Drawing.Point(113, 173);
            this.greenXNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.greenXNumericUpDown.Name = "greenXNumericUpDown";
            this.greenXNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.greenXNumericUpDown.TabIndex = 20;
            this.greenXNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // redYNumericUpDown
            // 
            this.redYNumericUpDown.DecimalPlaces = 8;
            this.redYNumericUpDown.Enabled = false;
            this.redYNumericUpDown.Location = new System.Drawing.Point(239, 140);
            this.redYNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.redYNumericUpDown.Name = "redYNumericUpDown";
            this.redYNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.redYNumericUpDown.TabIndex = 19;
            this.redYNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // redXNumericUpDown
            // 
            this.redXNumericUpDown.DecimalPlaces = 8;
            this.redXNumericUpDown.Enabled = false;
            this.redXNumericUpDown.Location = new System.Drawing.Point(113, 140);
            this.redXNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.redXNumericUpDown.Name = "redXNumericUpDown";
            this.redXNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.redXNumericUpDown.TabIndex = 18;
            this.redXNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(183, 283);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Gamma";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(110, 110);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "x";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(236, 111);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 110);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Chromaticity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Red primary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Green primary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Blue primary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 247);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "White point";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Predefined iluminant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Predefined color profile";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(169, 56);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.mainPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 337);
            this.panel1.TabIndex = 9;
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Location = new System.Drawing.Point(3, 3);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(100, 50);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            // 
            // HSVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1154, 674);
            this.Name = "HSVForm";
            this.Text = "HSVForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.HSVForm_SizeChanged);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gammaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redXNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Button seprateChannelsButton;
        private System.Windows.Forms.Button savePropertiesButton;
        private System.Windows.Forms.Button saveOutputButton;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.Button grayScaleButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox mainPictureBox;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label14;
        private Label label13;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private NumericUpDown gammaNumericUpDown;
        private NumericUpDown whiteYNumericUpDown;
        private NumericUpDown whiteXNumericUpDown;
        private NumericUpDown blueYNumericUpDown;
        private NumericUpDown blueXNumericUpDown;
        private NumericUpDown greenYNumericUpDown;
        private NumericUpDown greenXNumericUpDown;
        private NumericUpDown redYNumericUpDown;
        private NumericUpDown redXNumericUpDown;
        private Button cameraButton;
    }
}