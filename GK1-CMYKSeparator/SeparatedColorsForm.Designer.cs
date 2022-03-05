
namespace GK1_P3_komoszynskil
{
    partial class SeparatedColorsForm
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
            this.magentaPictureBox = new System.Windows.Forms.PictureBox();
            this.blackPictureBox = new System.Windows.Forms.PictureBox();
            this.cyanPictureBox = new System.Windows.Forms.PictureBox();
            this.yellowPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magentaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.magentaPictureBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.blackPictureBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cyanPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.yellowPictureBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // magentaPictureBox
            // 
            this.magentaPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.magentaPictureBox.Location = new System.Drawing.Point(403, 3);
            this.magentaPictureBox.Name = "magentaPictureBox";
            this.magentaPictureBox.Size = new System.Drawing.Size(394, 219);
            this.magentaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.magentaPictureBox.TabIndex = 0;
            this.magentaPictureBox.TabStop = false;
            // 
            // blackPictureBox
            // 
            this.blackPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blackPictureBox.Location = new System.Drawing.Point(403, 228);
            this.blackPictureBox.Name = "blackPictureBox";
            this.blackPictureBox.Size = new System.Drawing.Size(394, 219);
            this.blackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blackPictureBox.TabIndex = 1;
            this.blackPictureBox.TabStop = false;
            // 
            // cyanPictureBox
            // 
            this.cyanPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cyanPictureBox.Location = new System.Drawing.Point(3, 3);
            this.cyanPictureBox.Name = "cyanPictureBox";
            this.cyanPictureBox.Size = new System.Drawing.Size(394, 219);
            this.cyanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cyanPictureBox.TabIndex = 2;
            this.cyanPictureBox.TabStop = false;
            // 
            // yellowPictureBox
            // 
            this.yellowPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yellowPictureBox.Location = new System.Drawing.Point(3, 228);
            this.yellowPictureBox.Name = "yellowPictureBox";
            this.yellowPictureBox.Size = new System.Drawing.Size(394, 219);
            this.yellowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yellowPictureBox.TabIndex = 3;
            this.yellowPictureBox.TabStop = false;
            // 
            // SeparatedColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SeparatedColorsForm";
            this.Text = "Separated Colors";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.magentaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox magentaPictureBox;
        private System.Windows.Forms.PictureBox blackPictureBox;
        private System.Windows.Forms.PictureBox cyanPictureBox;
        private System.Windows.Forms.PictureBox yellowPictureBox;
    }
}