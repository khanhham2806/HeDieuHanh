
namespace PictureShowApp
{
    partial class Form1
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
            System.Windows.Forms.Button btSet;
            System.Windows.Forms.Button btShow;
            System.Windows.Forms.Button btClear;
            System.Windows.Forms.Button btClose;
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cb1 = new System.Windows.Forms.CheckBox();
            btSet = new System.Windows.Forms.Button();
            btShow = new System.Windows.Forms.Button();
            btClear = new System.Windows.Forms.Button();
            btClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSet
            // 
            btSet.AutoSize = true;
            btSet.Dock = System.Windows.Forms.DockStyle.Fill;
            btSet.Location = new System.Drawing.Point(3, 3);
            btSet.Name = "btSet";
            btSet.Size = new System.Drawing.Size(100, 25);
            btSet.TabIndex = 0;
            btSet.Text = "Set Background";
            btSet.UseVisualStyleBackColor = true;
            btSet.Click += new System.EventHandler(this.btSet_Click_1);
            // 
            // btShow
            // 
            btShow.AutoSize = true;
            btShow.Dock = System.Windows.Forms.DockStyle.Fill;
            btShow.Location = new System.Drawing.Point(109, 3);
            btShow.Name = "btShow";
            btShow.Size = new System.Drawing.Size(108, 25);
            btShow.TabIndex = 1;
            btShow.Text = "Show The Picture";
            btShow.UseVisualStyleBackColor = true;
            btShow.Click += new System.EventHandler(this.btShow_Click_1);
            // 
            // btClear
            // 
            btClear.AutoSize = true;
            btClear.Dock = System.Windows.Forms.DockStyle.Fill;
            btClear.Location = new System.Drawing.Point(223, 3);
            btClear.Name = "btClear";
            btClear.Size = new System.Drawing.Size(75, 25);
            btClear.TabIndex = 3;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += new System.EventHandler(this.btClear_Click_1);
            // 
            // btClose
            // 
            btClose.AutoSize = true;
            btClose.Dock = System.Windows.Forms.DockStyle.Fill;
            btClose.Location = new System.Drawing.Point(304, 3);
            btClose.Name = "btClose";
            btClose.Size = new System.Drawing.Size(75, 25);
            btClose.TabIndex = 4;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += new System.EventHandler(this.btClose_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;";
            this.openFileDialog1.Title = "Select The Picture";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 15);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.17166F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.82834F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.81637F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.183633F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 501);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(728, 454);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(btSet);
            this.flowLayoutPanel1.Controls.Add(btShow);
            this.flowLayoutPanel1.Controls.Add(btClear);
            this.flowLayoutPanel1.Controls.Add(btClose);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(84, 463);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(647, 35);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb1.Location = new System.Drawing.Point(3, 463);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(75, 35);
            this.cb1.TabIndex = 3;
            this.cb1.Text = "stretch";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "PictureShowApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btSet;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.CheckBox cb1;
    }
}

