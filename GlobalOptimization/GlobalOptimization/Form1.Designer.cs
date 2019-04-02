namespace GlobalOptimization
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.plot_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.points_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.alpha_textBox = new System.Windows.Forms.TextBox();
            this.betta_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gamma_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.delta_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.range_left_textBox = new System.Windows.Forms.TextBox();
            this.range_right_textBox = new System.Windows.Forms.TextBox();
            this.trivial_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.strongin_radioButton = new System.Windows.Forms.RadioButton();
            this.piyavsky_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.plot_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.method_param_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accuracy_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iterations_textBox = new System.Windows.Forms.TextBox();
            this.run_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.result_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plot_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.points_chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // plot_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.plot_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.plot_chart.Legends.Add(legend1);
            this.plot_chart.Location = new System.Drawing.Point(448, 12);
            this.plot_chart.Name = "plot_chart";
            this.plot_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "function ";
            this.plot_chart.Series.Add(series1);
            this.plot_chart.Size = new System.Drawing.Size(641, 454);
            this.plot_chart.TabIndex = 0;
            this.plot_chart.Text = "chart1";
            // 
            // points_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.points_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.points_chart.Legends.Add(legend2);
            this.points_chart.Location = new System.Drawing.Point(448, 472);
            this.points_chart.Name = "points_chart";
            this.points_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "trivial";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.Name = "Pitavsky";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Legend = "Legend1";
            series4.Name = "Strongin";
            this.points_chart.Series.Add(series2);
            this.points_chart.Series.Add(series3);
            this.points_chart.Series.Add(series4);
            this.points_chart.Size = new System.Drawing.Size(641, 177);
            this.points_chart.TabIndex = 1;
            this.points_chart.Text = "chart2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "α =";
            // 
            // alpha_textBox
            // 
            this.alpha_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alpha_textBox.Location = new System.Drawing.Point(91, 33);
            this.alpha_textBox.Name = "alpha_textBox";
            this.alpha_textBox.Size = new System.Drawing.Size(100, 29);
            this.alpha_textBox.TabIndex = 8;
            this.alpha_textBox.Text = "2";
            // 
            // betta_textBox
            // 
            this.betta_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.betta_textBox.Location = new System.Drawing.Point(91, 68);
            this.betta_textBox.Name = "betta_textBox";
            this.betta_textBox.Size = new System.Drawing.Size(100, 29);
            this.betta_textBox.TabIndex = 10;
            this.betta_textBox.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(44, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "β =";
            // 
            // gamma_textBox
            // 
            this.gamma_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamma_textBox.Location = new System.Drawing.Point(91, 103);
            this.gamma_textBox.Name = "gamma_textBox";
            this.gamma_textBox.Size = new System.Drawing.Size(100, 29);
            this.gamma_textBox.TabIndex = 12;
            this.gamma_textBox.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(44, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "γ =";
            // 
            // delta_textBox
            // 
            this.delta_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delta_textBox.Location = new System.Drawing.Point(91, 138);
            this.delta_textBox.Name = "delta_textBox";
            this.delta_textBox.Size = new System.Drawing.Size(100, 29);
            this.delta_textBox.TabIndex = 14;
            this.delta_textBox.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(44, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "δ =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(44, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "x∈ [";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(199, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = ",";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(326, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "]";
            // 
            // range_left_textBox
            // 
            this.range_left_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.range_left_textBox.Location = new System.Drawing.Point(91, 173);
            this.range_left_textBox.Name = "range_left_textBox";
            this.range_left_textBox.Size = new System.Drawing.Size(100, 29);
            this.range_left_textBox.TabIndex = 18;
            this.range_left_textBox.Text = "0";
            // 
            // range_right_textBox
            // 
            this.range_right_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.range_right_textBox.Location = new System.Drawing.Point(220, 173);
            this.range_right_textBox.Name = "range_right_textBox";
            this.range_right_textBox.Size = new System.Drawing.Size(100, 29);
            this.range_right_textBox.TabIndex = 19;
            this.range_right_textBox.Text = "10";
            // 
            // trivial_radioButton
            // 
            this.trivial_radioButton.AutoSize = true;
            this.trivial_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trivial_radioButton.Location = new System.Drawing.Point(48, 28);
            this.trivial_radioButton.Name = "trivial_radioButton";
            this.trivial_radioButton.Size = new System.Drawing.Size(188, 28);
            this.trivial_radioButton.TabIndex = 20;
            this.trivial_radioButton.Text = "Brute force method";
            this.trivial_radioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.strongin_radioButton);
            this.groupBox1.Controls.Add(this.piyavsky_radioButton);
            this.groupBox1.Controls.Add(this.trivial_radioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 137);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithm:";
            // 
            // strongin_radioButton
            // 
            this.strongin_radioButton.AutoSize = true;
            this.strongin_radioButton.Checked = true;
            this.strongin_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strongin_radioButton.Location = new System.Drawing.Point(48, 96);
            this.strongin_radioButton.Name = "strongin_radioButton";
            this.strongin_radioButton.Size = new System.Drawing.Size(167, 28);
            this.strongin_radioButton.TabIndex = 22;
            this.strongin_radioButton.TabStop = true;
            this.strongin_radioButton.Text = "Strongin method";
            this.strongin_radioButton.UseVisualStyleBackColor = true;
            // 
            // piyavsky_radioButton
            // 
            this.piyavsky_radioButton.AutoSize = true;
            this.piyavsky_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.piyavsky_radioButton.Location = new System.Drawing.Point(48, 62);
            this.piyavsky_radioButton.Name = "piyavsky_radioButton";
            this.piyavsky_radioButton.Size = new System.Drawing.Size(168, 28);
            this.piyavsky_radioButton.TabIndex = 21;
            this.piyavsky_radioButton.Text = "Piyavsky method";
            this.piyavsky_radioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.plot_button);
            this.groupBox2.Controls.Add(this.gamma_textBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.range_right_textBox);
            this.groupBox2.Controls.Add(this.alpha_textBox);
            this.groupBox2.Controls.Add(this.range_left_textBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.betta_textBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.delta_textBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 250);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Function: α*sin(β*x)+γ*cos(δ*x)";
            // 
            // plot_button
            // 
            this.plot_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plot_button.Location = new System.Drawing.Point(48, 208);
            this.plot_button.Name = "plot_button";
            this.plot_button.Size = new System.Drawing.Size(112, 33);
            this.plot_button.TabIndex = 28;
            this.plot_button.Text = "Plot";
            this.plot_button.UseVisualStyleBackColor = true;
            this.plot_button.Click += new System.EventHandler(this.plot_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.method_param_textBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.accuracy_textBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.iterations_textBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.groupBox3.Location = new System.Drawing.Point(12, 411);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 141);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameters:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(44, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "r =";
            // 
            // method_param_textBox
            // 
            this.method_param_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.method_param_textBox.Location = new System.Drawing.Point(82, 103);
            this.method_param_textBox.Name = "method_param_textBox";
            this.method_param_textBox.Size = new System.Drawing.Size(100, 29);
            this.method_param_textBox.TabIndex = 18;
            this.method_param_textBox.Text = "1.25";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "accuracy:";
            // 
            // accuracy_textBox
            // 
            this.accuracy_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accuracy_textBox.Location = new System.Drawing.Point(141, 68);
            this.accuracy_textBox.Name = "accuracy_textBox";
            this.accuracy_textBox.Size = new System.Drawing.Size(100, 29);
            this.accuracy_textBox.TabIndex = 16;
            this.accuracy_textBox.Text = "0.001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "number of iterations:";
            // 
            // iterations_textBox
            // 
            this.iterations_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iterations_textBox.Location = new System.Drawing.Point(230, 31);
            this.iterations_textBox.Name = "iterations_textBox";
            this.iterations_textBox.Size = new System.Drawing.Size(100, 29);
            this.iterations_textBox.TabIndex = 14;
            this.iterations_textBox.Text = "10000";
            // 
            // run_button
            // 
            this.run_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.run_button.Location = new System.Drawing.Point(12, 558);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(112, 33);
            this.run_button.TabIndex = 24;
            this.run_button.Text = "Run";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(130, 558);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(112, 33);
            this.cancel_button.TabIndex = 25;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(8, 594);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "Result:";
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_label.Location = new System.Drawing.Point(88, 594);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(142, 24);
            this.result_label.TabIndex = 27;
            this.result_label.Text = "...some_result...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 661);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.run_button);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.points_chart);
            this.Controls.Add(this.plot_chart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Global Optimization";
            ((System.ComponentModel.ISupportInitialize)(this.plot_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.points_chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart plot_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart points_chart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox alpha_textBox;
        private System.Windows.Forms.TextBox betta_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox gamma_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox delta_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox range_left_textBox;
        private System.Windows.Forms.TextBox range_right_textBox;
        private System.Windows.Forms.RadioButton trivial_radioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton strongin_radioButton;
        private System.Windows.Forms.RadioButton piyavsky_radioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox method_param_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accuracy_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iterations_textBox;
        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.Button plot_button;

    }
}

