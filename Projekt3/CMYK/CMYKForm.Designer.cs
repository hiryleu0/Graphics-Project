using System.Windows.Forms;

namespace Projekt3
{
    partial class CMYKForm
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
            this.secondTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.plotPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allCurvesCheckBox = new System.Windows.Forms.CheckBox();
            this.blackButton = new System.Windows.Forms.RadioButton();
            this.yellowButton = new System.Windows.Forms.RadioButton();
            this.magentaButton = new System.Windows.Forms.RadioButton();
            this.cyjanButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.loadCurveButton = new System.Windows.Forms.Button();
            this.allPicturesButton = new System.Windows.Forms.Button();
            this.changePictureButton = new System.Windows.Forms.Button();
            this.saveCurveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.GCRButton = new System.Windows.Forms.Button();
            this.UCRButton = new System.Windows.Forms.Button();
            this._100Button = new System.Windows.Forms.Button();
            this._0Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.savePicturesButton = new System.Windows.Forms.Button();
            this.blackWhiteButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel = new System.Windows.Forms.Panel();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.secondTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // secondTableLayoutPanel
            // 
            this.secondTableLayoutPanel.ColumnCount = 1;
            this.secondTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.secondTableLayoutPanel.Controls.Add(this.plotPictureBox, 0, 0);
            this.secondTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.secondTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondTableLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.secondTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.secondTableLayoutPanel.Name = "secondTableLayoutPanel";
            this.secondTableLayoutPanel.RowCount = 2;
            this.secondTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.secondTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.secondTableLayoutPanel.Size = new System.Drawing.Size(761, 956);
            this.secondTableLayoutPanel.TabIndex = 0;
            // 
            // plotPictureBox
            // 
            this.plotPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotPictureBox.Location = new System.Drawing.Point(4, 4);
            this.plotPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plotPictureBox.Name = "plotPictureBox";
            this.plotPictureBox.Size = new System.Drawing.Size(753, 661);
            this.plotPictureBox.TabIndex = 0;
            this.plotPictureBox.TabStop = false;
            this.plotPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plotPictureBox_MouseDown);
            this.plotPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plotPictureBox_MouseMove);
            this.plotPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plotPictureBox_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 673);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 279);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allCurvesCheckBox);
            this.groupBox1.Controls.Add(this.blackButton);
            this.groupBox1.Controls.Add(this.yellowButton);
            this.groupBox1.Controls.Add(this.magentaButton);
            this.groupBox1.Controls.Add(this.cyjanButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(255, 271);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plots";
            // 
            // allCurvesCheckBox
            // 
            this.allCurvesCheckBox.AutoSize = true;
            this.allCurvesCheckBox.Checked = true;
            this.allCurvesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allCurvesCheckBox.Location = new System.Drawing.Point(9, 135);
            this.allCurvesCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allCurvesCheckBox.Name = "allCurvesCheckBox";
            this.allCurvesCheckBox.Size = new System.Drawing.Size(128, 21);
            this.allCurvesCheckBox.TabIndex = 4;
            this.allCurvesCheckBox.Text = "Show all curves";
            this.allCurvesCheckBox.UseVisualStyleBackColor = true;
            this.allCurvesCheckBox.CheckedChanged += new System.EventHandler(this.allCurvesCheckBox_CheckedChanged);
            // 
            // blackButton
            // 
            this.blackButton.AutoSize = true;
            this.blackButton.Location = new System.Drawing.Point(9, 110);
            this.blackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(82, 21);
            this.blackButton.TabIndex = 3;
            this.blackButton.Text = "(K)Black";
            this.blackButton.UseVisualStyleBackColor = true;
            this.blackButton.CheckedChanged += new System.EventHandler(this.blackButton_CheckedChanged);
            // 
            // yellowButton
            // 
            this.yellowButton.AutoSize = true;
            this.yellowButton.Location = new System.Drawing.Point(9, 81);
            this.yellowButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(69, 21);
            this.yellowButton.TabIndex = 2;
            this.yellowButton.Text = "Yellow";
            this.yellowButton.UseVisualStyleBackColor = true;
            this.yellowButton.CheckedChanged += new System.EventHandler(this.yellowButton_CheckedChanged);
            // 
            // magentaButton
            // 
            this.magentaButton.AutoSize = true;
            this.magentaButton.Location = new System.Drawing.Point(9, 53);
            this.magentaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.magentaButton.Name = "magentaButton";
            this.magentaButton.Size = new System.Drawing.Size(84, 21);
            this.magentaButton.TabIndex = 1;
            this.magentaButton.Text = "Magenta";
            this.magentaButton.UseVisualStyleBackColor = true;
            this.magentaButton.CheckedChanged += new System.EventHandler(this.magentaButton_CheckedChanged);
            // 
            // cyjanButton
            // 
            this.cyjanButton.AutoSize = true;
            this.cyjanButton.Checked = true;
            this.cyjanButton.Location = new System.Drawing.Point(9, 25);
            this.cyjanButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cyjanButton.Name = "cyjanButton";
            this.cyjanButton.Size = new System.Drawing.Size(64, 21);
            this.cyjanButton.TabIndex = 0;
            this.cyjanButton.TabStop = true;
            this.cyjanButton.Text = "Cyjan";
            this.cyjanButton.UseVisualStyleBackColor = true;
            this.cyjanButton.CheckedChanged += new System.EventHandler(this.cyjanButton_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(267, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(482, 271);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.Controls.Add(this.loadCurveButton, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.allPicturesButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.changePictureButton, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.saveCurveButton, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(163, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(151, 263);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // loadCurveButton
            // 
            this.loadCurveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadCurveButton.Location = new System.Drawing.Point(4, 199);
            this.loadCurveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadCurveButton.Name = "loadCurveButton";
            this.loadCurveButton.Size = new System.Drawing.Size(143, 60);
            this.loadCurveButton.TabIndex = 2;
            this.loadCurveButton.Text = "Load Curve";
            this.loadCurveButton.UseVisualStyleBackColor = true;
            this.loadCurveButton.Click += new System.EventHandler(this.loadCurveButton_Click);
            // 
            // allPicturesButton
            // 
            this.allPicturesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allPicturesButton.Location = new System.Drawing.Point(4, 4);
            this.allPicturesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allPicturesButton.Name = "allPicturesButton";
            this.allPicturesButton.Size = new System.Drawing.Size(143, 57);
            this.allPicturesButton.TabIndex = 1;
            this.allPicturesButton.Text = "Show all pictures";
            this.allPicturesButton.UseVisualStyleBackColor = true;
            this.allPicturesButton.Click += new System.EventHandler(this.allPicturesButton_Click);
            // 
            // changePictureButton
            // 
            this.changePictureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changePictureButton.Location = new System.Drawing.Point(4, 69);
            this.changePictureButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.changePictureButton.Name = "changePictureButton";
            this.changePictureButton.Size = new System.Drawing.Size(143, 57);
            this.changePictureButton.TabIndex = 3;
            this.changePictureButton.Text = "Change Picture";
            this.changePictureButton.UseVisualStyleBackColor = true;
            this.changePictureButton.Click += new System.EventHandler(this.changePictureButton_Click);
            // 
            // saveCurveButton
            // 
            this.saveCurveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveCurveButton.Location = new System.Drawing.Point(4, 134);
            this.saveCurveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveCurveButton.Name = "saveCurveButton";
            this.saveCurveButton.Size = new System.Drawing.Size(143, 57);
            this.saveCurveButton.TabIndex = 4;
            this.saveCurveButton.Text = "Save Curve";
            this.saveCurveButton.UseVisualStyleBackColor = true;
            this.saveCurveButton.Click += new System.EventHandler(this.saveCurveButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.Controls.Add(this.GCRButton, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.UCRButton, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this._100Button, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this._0Button, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(151, 263);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // GCRButton
            // 
            this.GCRButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCRButton.Location = new System.Drawing.Point(4, 199);
            this.GCRButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GCRButton.Name = "GCRButton";
            this.GCRButton.Size = new System.Drawing.Size(143, 60);
            this.GCRButton.TabIndex = 3;
            this.GCRButton.Text = "GCR";
            this.GCRButton.UseVisualStyleBackColor = true;
            this.GCRButton.Click += new System.EventHandler(this.GCRButton_Click);
            // 
            // UCRButton
            // 
            this.UCRButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCRButton.Location = new System.Drawing.Point(4, 134);
            this.UCRButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UCRButton.Name = "UCRButton";
            this.UCRButton.Size = new System.Drawing.Size(143, 57);
            this.UCRButton.TabIndex = 2;
            this.UCRButton.Text = "UCR";
            this.UCRButton.UseVisualStyleBackColor = true;
            this.UCRButton.Click += new System.EventHandler(this.UCRButton_Click);
            // 
            // _100Button
            // 
            this._100Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this._100Button.Location = new System.Drawing.Point(4, 69);
            this._100Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._100Button.Name = "_100Button";
            this._100Button.Size = new System.Drawing.Size(143, 57);
            this._100Button.TabIndex = 1;
            this._100Button.Text = "100% cofnięcia";
            this._100Button.UseVisualStyleBackColor = true;
            this._100Button.Click += new System.EventHandler(this._100Button_Click);
            // 
            // _0Button
            // 
            this._0Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this._0Button.Location = new System.Drawing.Point(4, 4);
            this._0Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._0Button.Name = "_0Button";
            this._0Button.Size = new System.Drawing.Size(143, 57);
            this._0Button.TabIndex = 0;
            this._0Button.Text = "0% cofnięcia";
            this._0Button.UseVisualStyleBackColor = true;
            this._0Button.Click += new System.EventHandler(this._0Button_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.savePicturesButton, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.blackWhiteButton, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(322, 4);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(156, 263);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // savePicturesButton
            // 
            this.savePicturesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savePicturesButton.Location = new System.Drawing.Point(4, 135);
            this.savePicturesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.savePicturesButton.Name = "savePicturesButton";
            this.savePicturesButton.Size = new System.Drawing.Size(148, 124);
            this.savePicturesButton.TabIndex = 2;
            this.savePicturesButton.Text = "Save Pictures";
            this.savePicturesButton.UseVisualStyleBackColor = true;
            this.savePicturesButton.Click += new System.EventHandler(this.savePicturesButton_Click);
            // 
            // blackWhiteButton
            // 
            this.blackWhiteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blackWhiteButton.Location = new System.Drawing.Point(4, 4);
            this.blackWhiteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.blackWhiteButton.Name = "blackWhiteButton";
            this.blackWhiteButton.Size = new System.Drawing.Size(148, 123);
            this.blackWhiteButton.TabIndex = 1;
            this.blackWhiteButton.Text = "Black and White";
            this.blackWhiteButton.UseVisualStyleBackColor = true;
            this.blackWhiteButton.Click += new System.EventHandler(this.blackWhiteButton_Click);
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.AutoScroll = true;
            this.mainTableLayoutPanel.AutoSize = true;
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainTableLayoutPanel.Controls.Add(this.secondTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.panel, 1, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 1;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(1924, 964);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.AutoSize = true;
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Controls.Add(this.mainPictureBox);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(773, 4);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1147, 956);
            this.panel.TabIndex = 1;
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Location = new System.Drawing.Point(4, 4);
            this.mainPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(100, 50);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 964);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1918, 1001);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.secondTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plotPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel secondTableLayoutPanel;
        private System.Windows.Forms.PictureBox plotPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox allCurvesCheckBox;
        private System.Windows.Forms.RadioButton blackButton;
        private System.Windows.Forms.RadioButton yellowButton;
        private System.Windows.Forms.RadioButton magentaButton;
        private System.Windows.Forms.RadioButton cyjanButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button loadCurveButton;
        private System.Windows.Forms.Button allPicturesButton;
        private System.Windows.Forms.Button changePictureButton;
        private System.Windows.Forms.Button saveCurveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button GCRButton;
        private System.Windows.Forms.Button UCRButton;
        private System.Windows.Forms.Button _100Button;
        private System.Windows.Forms.Button _0Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button savePicturesButton;
        private System.Windows.Forms.Button blackWhiteButton;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Panel panel;
        public System.Windows.Forms.PictureBox mainPictureBox;
    }
}

