namespace PRACT1 {
    partial class main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxXn = new System.Windows.Forms.TextBox();
            this.textBoxtXk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.arrayStrip = new System.Windows.Forms.MenuStrip();
            this.масивиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одновимірніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.двовимірніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.arrayStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xn";
            // 
            // textBoxXn
            // 
            this.textBoxXn.Location = new System.Drawing.Point(30, 23);
            this.textBoxXn.Name = "textBoxXn";
            this.textBoxXn.Size = new System.Drawing.Size(29, 20);
            this.textBoxXn.TabIndex = 2;
            this.textBoxXn.Text = "1,7";
            // 
            // textBoxtXk
            // 
            this.textBoxtXk.Location = new System.Drawing.Point(85, 23);
            this.textBoxtXk.Name = "textBoxtXk";
            this.textBoxtXk.Size = new System.Drawing.Size(29, 20);
            this.textBoxtXk.TabIndex = 4;
            this.textBoxtXk.Text = "4,9";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(65, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Xk";
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(140, 23);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(29, 20);
            this.textBoxH.TabIndex = 6;
            this.textBoxH.Text = "0,5";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(120, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "h";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(198, 23);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(29, 20);
            this.textBoxA.TabIndex = 8;
            this.textBoxA.Text = "3";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(175, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "a";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Count";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.x, this.y });
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 363);
            this.dataGridView1.TabIndex = 10;
            // 
            // x
            // 
            this.x.HeaderText = "x";
            this.x.Name = "x";
            this.x.ReadOnly = true;
            this.x.Width = 150;
            // 
            // y
            // 
            this.y.HeaderText = "y";
            this.y.Name = "y";
            this.y.ReadOnly = true;
            this.y.Width = 150;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(361, 75);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(427, 363);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(330, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // arrayStrip
            // 
            this.arrayStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.масивиToolStripMenuItem });
            this.arrayStrip.Location = new System.Drawing.Point(0, 0);
            this.arrayStrip.Name = "arrayStrip";
            this.arrayStrip.Size = new System.Drawing.Size(800, 24);
            this.arrayStrip.TabIndex = 13;
            this.arrayStrip.Text = "menuStrip1";
            // 
            // масивиToolStripMenuItem
            // 
            this.масивиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.одновимірніToolStripMenuItem, this.двовимірніToolStripMenuItem });
            this.масивиToolStripMenuItem.Name = "масивиToolStripMenuItem";
            this.масивиToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.масивиToolStripMenuItem.Text = "Масиви";
            // 
            // одновимірніToolStripMenuItem
            // 
            this.одновимірніToolStripMenuItem.Name = "одновимірніToolStripMenuItem";
            this.одновимірніToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.одновимірніToolStripMenuItem.Text = "Одновимірні";
            this.одновимірніToolStripMenuItem.Click += new System.EventHandler(this.singleArrayToolStripMenuItem_Click);
            // 
            // двовимірніToolStripMenuItem
            // 
            this.двовимірніToolStripMenuItem.Name = "двовимірніToolStripMenuItem";
            this.двовимірніToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.двовимірніToolStripMenuItem.Text = "Двовимірні";
            this.двовимірніToolStripMenuItem.Click += new System.EventHandler(this.doubleArrayToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxtXk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxXn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arrayStrip);
            this.MainMenuStrip = this.arrayStrip;
            this.Name = "main";
            this.Text = "PRACT1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.arrayStrip.ResumeLayout(false);
            this.arrayStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem одновимірніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem двовимірніToolStripMenuItem;
        private System.Windows.Forms.MenuStrip arrayStrip;
        private System.Windows.Forms.ToolStripMenuItem масивиToolStripMenuItem;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.TextBox textBoxXn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxtXk;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}