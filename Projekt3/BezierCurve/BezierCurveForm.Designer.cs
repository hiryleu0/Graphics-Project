namespace Projekt3.BezierCurve
{
    partial class BezierCurveForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.movingRadioButton = new System.Windows.Forms.RadioButton();
            this.rotationRadioButton = new System.Windows.Forms.RadioButton();
            this.rotatingGroupBox = new System.Windows.Forms.GroupBox();
            this.filterRadioButton = new System.Windows.Forms.RadioButton();
            this.naiveRadioButton = new System.Windows.Forms.RadioButton();
            this.grayColorsCheckbox = new System.Windows.Forms.CheckBox();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.smallPictureBox = new System.Windows.Forms.PictureBox();
            this.savePolylineButton = new System.Windows.Forms.Button();
            this.loadCurveButton = new System.Windows.Forms.Button();
            this.visiblePolylineCheckbox = new System.Windows.Forms.CheckBox();
            this.generateCurveButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.rotatingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smallPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.44156F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.55844F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1155, 687);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(216, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(936, 681);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.stopButton);
            this.groupBox.Controls.Add(this.startButton);
            this.groupBox.Controls.Add(this.groupBox2);
            this.groupBox.Controls.Add(this.rotatingGroupBox);
            this.groupBox.Controls.Add(this.grayColorsCheckbox);
            this.groupBox.Controls.Add(this.loadImageButton);
            this.groupBox.Controls.Add(this.smallPictureBox);
            this.groupBox.Controls.Add(this.savePolylineButton);
            this.groupBox.Controls.Add(this.loadCurveButton);
            this.groupBox.Controls.Add(this.visiblePolylineCheckbox);
            this.groupBox.Controls.Add(this.generateCurveButton);
            this.groupBox.Controls.Add(this.numericUpDown1);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(3, 3);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(207, 681);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Settings";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(111, 516);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 12;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(14, 516);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.movingRadioButton);
            this.groupBox2.Controls.Add(this.rotationRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(9, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Animation";
            // 
            // movingRadioButton
            // 
            this.movingRadioButton.AutoSize = true;
            this.movingRadioButton.Location = new System.Drawing.Point(6, 51);
            this.movingRadioButton.Name = "movingRadioButton";
            this.movingRadioButton.Size = new System.Drawing.Size(117, 17);
            this.movingRadioButton.TabIndex = 16;
            this.movingRadioButton.TabStop = true;
            this.movingRadioButton.Text = "Moving n the curve";
            this.movingRadioButton.UseVisualStyleBackColor = true;
            // 
            // rotationRadioButton
            // 
            this.rotationRadioButton.AutoSize = true;
            this.rotationRadioButton.Location = new System.Drawing.Point(6, 28);
            this.rotationRadioButton.Name = "rotationRadioButton";
            this.rotationRadioButton.Size = new System.Drawing.Size(65, 17);
            this.rotationRadioButton.TabIndex = 15;
            this.rotationRadioButton.TabStop = true;
            this.rotationRadioButton.Text = "Rotation";
            this.rotationRadioButton.UseVisualStyleBackColor = true;
            // 
            // rotatingGroupBox
            // 
            this.rotatingGroupBox.Controls.Add(this.filterRadioButton);
            this.rotatingGroupBox.Controls.Add(this.naiveRadioButton);
            this.rotatingGroupBox.Location = new System.Drawing.Point(9, 270);
            this.rotatingGroupBox.Name = "rotatingGroupBox";
            this.rotatingGroupBox.Size = new System.Drawing.Size(182, 100);
            this.rotatingGroupBox.TabIndex = 9;
            this.rotatingGroupBox.TabStop = false;
            this.rotatingGroupBox.Text = "Rotating";
            // 
            // filterRadioButton
            // 
            this.filterRadioButton.AutoSize = true;
            this.filterRadioButton.Location = new System.Drawing.Point(6, 57);
            this.filterRadioButton.Name = "filterRadioButton";
            this.filterRadioButton.Size = new System.Drawing.Size(83, 17);
            this.filterRadioButton.TabIndex = 14;
            this.filterRadioButton.TabStop = true;
            this.filterRadioButton.Text = "With filtering";
            this.filterRadioButton.UseVisualStyleBackColor = true;
            // 
            // naiveRadioButton
            // 
            this.naiveRadioButton.AutoSize = true;
            this.naiveRadioButton.Location = new System.Drawing.Point(6, 34);
            this.naiveRadioButton.Name = "naiveRadioButton";
            this.naiveRadioButton.Size = new System.Drawing.Size(53, 17);
            this.naiveRadioButton.TabIndex = 13;
            this.naiveRadioButton.TabStop = true;
            this.naiveRadioButton.Text = "Naive";
            this.naiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // grayColorsCheckbox
            // 
            this.grayColorsCheckbox.AutoSize = true;
            this.grayColorsCheckbox.Location = new System.Drawing.Point(111, 232);
            this.grayColorsCheckbox.Name = "grayColorsCheckbox";
            this.grayColorsCheckbox.Size = new System.Drawing.Size(79, 17);
            this.grayColorsCheckbox.TabIndex = 8;
            this.grayColorsCheckbox.Text = "Gray colors";
            this.grayColorsCheckbox.UseVisualStyleBackColor = true;
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(116, 184);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(75, 23);
            this.loadImageButton.TabIndex = 7;
            this.loadImageButton.Text = "button4";
            this.loadImageButton.UseVisualStyleBackColor = true;
            // 
            // smallPictureBox
            // 
            this.smallPictureBox.Location = new System.Drawing.Point(12, 184);
            this.smallPictureBox.Name = "smallPictureBox";
            this.smallPictureBox.Size = new System.Drawing.Size(77, 65);
            this.smallPictureBox.TabIndex = 6;
            this.smallPictureBox.TabStop = false;
            // 
            // savePolylineButton
            // 
            this.savePolylineButton.Location = new System.Drawing.Point(105, 114);
            this.savePolylineButton.Name = "savePolylineButton";
            this.savePolylineButton.Size = new System.Drawing.Size(101, 23);
            this.savePolylineButton.TabIndex = 5;
            this.savePolylineButton.Text = "Save the polyline";
            this.savePolylineButton.UseVisualStyleBackColor = true;
            // 
            // loadCurveButton
            // 
            this.loadCurveButton.Location = new System.Drawing.Point(2, 114);
            this.loadCurveButton.Name = "loadCurveButton";
            this.loadCurveButton.Size = new System.Drawing.Size(101, 23);
            this.loadCurveButton.TabIndex = 4;
            this.loadCurveButton.Text = "Load a polyline";
            this.loadCurveButton.UseVisualStyleBackColor = true;
            // 
            // visiblePolylineCheckbox
            // 
            this.visiblePolylineCheckbox.AutoSize = true;
            this.visiblePolylineCheckbox.Location = new System.Drawing.Point(9, 73);
            this.visiblePolylineCheckbox.Name = "visiblePolylineCheckbox";
            this.visiblePolylineCheckbox.Size = new System.Drawing.Size(94, 17);
            this.visiblePolylineCheckbox.TabIndex = 3;
            this.visiblePolylineCheckbox.Text = "Visible polyline";
            this.visiblePolylineCheckbox.UseVisualStyleBackColor = true;
            this.visiblePolylineCheckbox.CheckedChanged += new System.EventHandler(this.visiblePolylineCheckbox_CheckedChanged);
            // 
            // generateCurveButton
            // 
            this.generateCurveButton.Location = new System.Drawing.Point(116, 69);
            this.generateCurveButton.Name = "generateCurveButton";
            this.generateCurveButton.Size = new System.Drawing.Size(75, 23);
            this.generateCurveButton.TabIndex = 2;
            this.generateCurveButton.Text = "Generate";
            this.generateCurveButton.UseVisualStyleBackColor = true;
            this.generateCurveButton.Click += new System.EventHandler(this.generateCurveButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(105, 32);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(86, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of points:";
            // 
            // BezierCurveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1154, 675);
            this.Name = "BezierCurveForm";
            this.Text = "Bezier Curve";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.rotatingGroupBox.ResumeLayout(false);
            this.rotatingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smallPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button savePolylineButton;
        private System.Windows.Forms.Button loadCurveButton;
        private System.Windows.Forms.CheckBox visiblePolylineCheckbox;
        private System.Windows.Forms.Button generateCurveButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton movingRadioButton;
        private System.Windows.Forms.RadioButton rotationRadioButton;
        private System.Windows.Forms.GroupBox rotatingGroupBox;
        private System.Windows.Forms.RadioButton filterRadioButton;
        private System.Windows.Forms.RadioButton naiveRadioButton;
        private System.Windows.Forms.CheckBox grayColorsCheckbox;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.PictureBox smallPictureBox;
    }
}