namespace Projekt3
{
    partial class AllPicturesForm
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
            this.blackPictureBox = new System.Windows.Forms.PictureBox();
            this.yellowPictureBox = new System.Windows.Forms.PictureBox();
            this.magentaPictureBox = new System.Windows.Forms.PictureBox();
            this.cyjanPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magentaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyjanPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.blackPictureBox, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.yellowPictureBox, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.magentaPictureBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.cyjanPictureBox, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1067, 554);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // blackPictureBox
            // 
            this.blackPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blackPictureBox.Location = new System.Drawing.Point(537, 281);
            this.blackPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.blackPictureBox.Name = "blackPictureBox";
            this.blackPictureBox.Size = new System.Drawing.Size(526, 269);
            this.blackPictureBox.TabIndex = 3;
            this.blackPictureBox.TabStop = false;
            // 
            // yellowPictureBox
            // 
            this.yellowPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yellowPictureBox.Location = new System.Drawing.Point(4, 281);
            this.yellowPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yellowPictureBox.Name = "yellowPictureBox";
            this.yellowPictureBox.Size = new System.Drawing.Size(525, 269);
            this.yellowPictureBox.TabIndex = 2;
            this.yellowPictureBox.TabStop = false;
            // 
            // magentaPictureBox
            // 
            this.magentaPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.magentaPictureBox.Location = new System.Drawing.Point(537, 4);
            this.magentaPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.magentaPictureBox.Name = "magentaPictureBox";
            this.magentaPictureBox.Size = new System.Drawing.Size(526, 269);
            this.magentaPictureBox.TabIndex = 1;
            this.magentaPictureBox.TabStop = false;
            // 
            // cyjanPictureBox
            // 
            this.cyjanPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cyjanPictureBox.Location = new System.Drawing.Point(4, 4);
            this.cyjanPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cyjanPictureBox.Name = "cyjanPictureBox";
            this.cyjanPictureBox.Size = new System.Drawing.Size(525, 269);
            this.cyjanPictureBox.TabIndex = 0;
            this.cyjanPictureBox.TabStop = false;
            // 
            // AllPicturesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "AllPicturesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllPicturesForm";
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.blackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magentaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyjanPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox blackPictureBox;
        private System.Windows.Forms.PictureBox yellowPictureBox;
        private System.Windows.Forms.PictureBox magentaPictureBox;
        private System.Windows.Forms.PictureBox cyjanPictureBox;
    }
}