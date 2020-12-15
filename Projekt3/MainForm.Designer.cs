namespace Projekt3
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CMYKButton = new System.Windows.Forms.Button();
            this.HSVButton = new System.Windows.Forms.Button();
            this.bezierButton = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.flowLayoutPanel);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(800, 450);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Application";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.CMYKButton);
            this.flowLayoutPanel.Controls.Add(this.HSVButton);
            this.flowLayoutPanel.Controls.Add(this.bezierButton);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel.Size = new System.Drawing.Size(794, 431);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // CMYKButton
            // 
            this.CMYKButton.Location = new System.Drawing.Point(30, 30);
            this.CMYKButton.Margin = new System.Windows.Forms.Padding(10);
            this.CMYKButton.Name = "CMYKButton";
            this.CMYKButton.Size = new System.Drawing.Size(87, 80);
            this.CMYKButton.TabIndex = 0;
            this.CMYKButton.Text = "CMYK";
            this.CMYKButton.UseVisualStyleBackColor = true;
            this.CMYKButton.Click += new System.EventHandler(this.CMYKButton_Click);
            // 
            // HSVButton
            // 
            this.HSVButton.Location = new System.Drawing.Point(137, 30);
            this.HSVButton.Margin = new System.Windows.Forms.Padding(10);
            this.HSVButton.Name = "HSVButton";
            this.HSVButton.Size = new System.Drawing.Size(87, 80);
            this.HSVButton.TabIndex = 1;
            this.HSVButton.Text = "HSV, LAB, YCbCr";
            this.HSVButton.UseVisualStyleBackColor = true;
            this.HSVButton.Click += new System.EventHandler(this.HSVButton_Click);
            // 
            // bezierButton
            // 
            this.bezierButton.Location = new System.Drawing.Point(244, 30);
            this.bezierButton.Margin = new System.Windows.Forms.Padding(10);
            this.bezierButton.Name = "bezierButton";
            this.bezierButton.Size = new System.Drawing.Size(87, 80);
            this.bezierButton.TabIndex = 2;
            this.bezierButton.Text = "Moving on Bezier\'s curve";
            this.bezierButton.UseVisualStyleBackColor = true;
            this.bezierButton.Click += new System.EventHandler(this.bezierButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox.ResumeLayout(false);
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button CMYKButton;
        private System.Windows.Forms.Button HSVButton;
        private System.Windows.Forms.Button bezierButton;
    }
}