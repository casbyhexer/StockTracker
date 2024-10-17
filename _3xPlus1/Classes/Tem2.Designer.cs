namespace _3xPlus1.Classes
{
    partial class Tem2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnResetZoom = new System.Windows.Forms.Button();
            this.rBtnSpine = new System.Windows.Forms.RadioButton();
            this.rBtnColumn = new System.Windows.Forms.RadioButton();
            this.rBtnLine = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblListSizeNum = new System.Windows.Forms.Label();
            this.lblListSize = new System.Windows.Forms.Label();
            this.lblCurrentChart = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.btnRun1 = new System.Windows.Forms.Button();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Stock_Tracker = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun2 = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Stock_Tracker.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Stock_Tracker);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1245, 734);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.Change_Tab);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnResetZoom);
            this.tabPage1.Controls.Add(this.rBtnSpine);
            this.tabPage1.Controls.Add(this.rBtnColumn);
            this.tabPage1.Controls.Add(this.rBtnLine);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tabPage1.Size = new System.Drawing.Size(1237, 695);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "_3X+1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnResetZoom
            // 
            this.btnResetZoom.Location = new System.Drawing.Point(1080, 54);
            this.btnResetZoom.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnResetZoom.Name = "btnResetZoom";
            this.btnResetZoom.Size = new System.Drawing.Size(105, 27);
            this.btnResetZoom.TabIndex = 0;
            this.btnResetZoom.Text = "Reset Zoom";
            this.btnResetZoom.UseVisualStyleBackColor = true;
            this.btnResetZoom.Click += new System.EventHandler(this.btnResetZoom_Click);
            // 
            // rBtnSpine
            // 
            this.rBtnSpine.AutoSize = true;
            this.rBtnSpine.BackColor = System.Drawing.Color.Transparent;
            this.rBtnSpine.Location = new System.Drawing.Point(1095, 286);
            this.rBtnSpine.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rBtnSpine.Name = "rBtnSpine";
            this.rBtnSpine.Size = new System.Drawing.Size(93, 29);
            this.rBtnSpine.TabIndex = 4;
            this.rBtnSpine.TabStop = true;
            this.rBtnSpine.Text = "Spine";
            this.rBtnSpine.UseVisualStyleBackColor = false;
            this.rBtnSpine.CheckedChanged += new System.EventHandler(this.rBtnSpine_CheckedChanged);
            // 
            // rBtnColumn
            // 
            this.rBtnColumn.AutoSize = true;
            this.rBtnColumn.BackColor = System.Drawing.Color.Transparent;
            this.rBtnColumn.Location = new System.Drawing.Point(1095, 257);
            this.rBtnColumn.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rBtnColumn.Name = "rBtnColumn";
            this.rBtnColumn.Size = new System.Drawing.Size(117, 29);
            this.rBtnColumn.TabIndex = 3;
            this.rBtnColumn.TabStop = true;
            this.rBtnColumn.Text = "Column";
            this.rBtnColumn.UseVisualStyleBackColor = false;
            this.rBtnColumn.CheckedChanged += new System.EventHandler(this.rBtnColumn_CheckedChanged);
            // 
            // rBtnLine
            // 
            this.rBtnLine.AutoSize = true;
            this.rBtnLine.BackColor = System.Drawing.Color.Transparent;
            this.rBtnLine.Location = new System.Drawing.Point(1095, 227);
            this.rBtnLine.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rBtnLine.Name = "rBtnLine";
            this.rBtnLine.Size = new System.Drawing.Size(77, 29);
            this.rBtnLine.TabIndex = 2;
            this.rBtnLine.TabStop = true;
            this.rBtnLine.Text = "Line";
            this.rBtnLine.UseVisualStyleBackColor = false;
            this.rBtnLine.CheckedChanged += new System.EventHandler(this.rBtnLine_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblListSizeNum);
            this.panel1.Controls.Add(this.lblListSize);
            this.panel1.Controls.Add(this.lblCurrentChart);
            this.panel1.Controls.Add(this.txtInput);
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Controls.Add(this.btnRun1);
            this.panel1.Controls.Add(this.btnClear1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(6, 529);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 163);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(678, 163);
            this.textBox1.TabIndex = 8;
            // 
            // lblListSizeNum
            // 
            this.lblListSizeNum.AutoSize = true;
            this.lblListSizeNum.Location = new System.Drawing.Point(795, 56);
            this.lblListSizeNum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblListSizeNum.Name = "lblListSizeNum";
            this.lblListSizeNum.Size = new System.Drawing.Size(0, 25);
            this.lblListSizeNum.TabIndex = 7;
            // 
            // lblListSize
            // 
            this.lblListSize.AutoSize = true;
            this.lblListSize.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListSize.Location = new System.Drawing.Point(750, 35);
            this.lblListSize.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblListSize.Name = "lblListSize";
            this.lblListSize.Size = new System.Drawing.Size(67, 19);
            this.lblListSize.TabIndex = 6;
            this.lblListSize.Text = "List Size:";
            // 
            // lblCurrentChart
            // 
            this.lblCurrentChart.AutoSize = true;
            this.lblCurrentChart.Font = new System.Drawing.Font("Century Gothic", 12.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentChart.Location = new System.Drawing.Point(919, 3);
            this.lblCurrentChart.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCurrentChart.Name = "lblCurrentChart";
            this.lblCurrentChart.Size = new System.Drawing.Size(73, 29);
            this.lblCurrentChart.TabIndex = 5;
            this.lblCurrentChart.Text = "3X+1";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(799, 57);
            this.txtInput.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(342, 33);
            this.txtInput.TabIndex = 4;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(750, 58);
            this.lblX.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(32, 25);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X:";
            // 
            // btnRun1
            // 
            this.btnRun1.Location = new System.Drawing.Point(799, 96);
            this.btnRun1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnRun1.Name = "btnRun1";
            this.btnRun1.Size = new System.Drawing.Size(149, 39);
            this.btnRun1.TabIndex = 2;
            this.btnRun1.Text = "Run ";
            this.btnRun1.UseVisualStyleBackColor = true;
            this.btnRun1.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClear1
            // 
            this.btnClear1.Location = new System.Drawing.Point(992, 96);
            this.btnClear1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(149, 37);
            this.btnClear1.TabIndex = 1;
            this.btnClear1.Text = "Clear Data";
            this.btnClear1.UseVisualStyleBackColor = true;
            this.btnClear1.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightSalmon;
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            this.chart1.BackSecondaryColor = System.Drawing.Color.Maroon;
            this.chart1.BorderlineColor = System.Drawing.Color.Red;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 4;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(5, 3);
            this.chart1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "_3X+1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1227, 526);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Stock_Tracker
            // 
            this.Stock_Tracker.Controls.Add(this.panel3);
            this.Stock_Tracker.Location = new System.Drawing.Point(4, 35);
            this.Stock_Tracker.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Stock_Tracker.Name = "Stock_Tracker";
            this.Stock_Tracker.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Stock_Tracker.Size = new System.Drawing.Size(1237, 703);
            this.Stock_Tracker.TabIndex = 1;
            this.Stock_Tracker.Text = "Stock_Tracker";
            this.Stock_Tracker.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.numericUpDown3);
            this.panel3.Controls.Add(this.numericUpDown2);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnRun2);
            this.panel3.Controls.Add(this.btnClear2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(6, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1226, 697);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(891, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "MA Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(765, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total Hours:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(1021, 77);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 33);
            this.numericUpDown3.TabIndex = 11;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(895, 77);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 33);
            this.numericUpDown2.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(769, 77);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 33);
            this.numericUpDown1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkSalmon;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(678, 697);
            this.textBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(795, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 7;
            // 
            // btnRun2
            // 
            this.btnRun2.Location = new System.Drawing.Point(799, 113);
            this.btnRun2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnRun2.Name = "btnRun2";
            this.btnRun2.Size = new System.Drawing.Size(149, 39);
            this.btnRun2.TabIndex = 2;
            this.btnRun2.Text = "Run ";
            this.btnRun2.UseVisualStyleBackColor = true;
            this.btnRun2.Click += new System.EventHandler(this.btnRun2_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(992, 113);
            this.btnClear2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(149, 37);
            this.btnClear2.TabIndex = 1;
            this.btnClear2.Text = "Clear Data";
            this.btnClear2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(872, 144);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(883, 197);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 20);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(883, 236);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(103, 20);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(220, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 4;
            // 
            // Tem2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1245, 734);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Tem2";
            this.Text = "Tem2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Stock_Tracker.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Stock_Tracker;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRun1;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblListSize;
        private System.Windows.Forms.RadioButton rBtnColumn;
        private System.Windows.Forms.RadioButton rBtnLine;
        private System.Windows.Forms.RadioButton rBtnSpine;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblListSizeNum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnResetZoom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRun2;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblCurrentChart;
    }
}