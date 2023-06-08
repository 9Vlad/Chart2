namespace WindowsFormsApp6
{
    partial class frmDiagrams
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCreateMasGist = new System.Windows.Forms.Button();
            this.dgvMasGist = new System.Windows.Forms.DataGridView();
            this.txtMasGist = new System.Windows.Forms.TextBox();
            this.txtMinYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btCreateMasRound = new System.Windows.Forms.Button();
            this.dgvMasRound = new System.Windows.Forms.DataGridView();
            this.txtMinAge = new System.Windows.Forms.TextBox();
            this.txtMasRound = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartDiagrams = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btCreateGist = new System.Windows.Forms.Button();
            this.btCreateRound = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasGist)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagrams)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCreateMasGist);
            this.groupBox1.Controls.Add(this.dgvMasGist);
            this.groupBox1.Controls.Add(this.txtMasGist);
            this.groupBox1.Controls.Add(this.txtMinYear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(621, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные для гистограммы";
            // 
            // btCreateMasGist
            // 
            this.btCreateMasGist.Location = new System.Drawing.Point(389, 29);
            this.btCreateMasGist.Name = "btCreateMasGist";
            this.btCreateMasGist.Size = new System.Drawing.Size(172, 68);
            this.btCreateMasGist.TabIndex = 4;
            this.btCreateMasGist.Text = "Сгенерировать пустой массив";
            this.btCreateMasGist.UseVisualStyleBackColor = true;
            this.btCreateMasGist.Click += new System.EventHandler(this.btCreateMasGist_Click);
            // 
            // dgvMasGist
            // 
            this.dgvMasGist.AllowUserToOrderColumns = true;
            this.dgvMasGist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasGist.Location = new System.Drawing.Point(11, 108);
            this.dgvMasGist.Name = "dgvMasGist";
            this.dgvMasGist.RowHeadersWidth = 51;
            this.dgvMasGist.RowTemplate.Height = 24;
            this.dgvMasGist.Size = new System.Drawing.Size(550, 122);
            this.dgvMasGist.TabIndex = 1;
            // 
            // txtMasGist
            // 
            this.txtMasGist.Location = new System.Drawing.Point(259, 72);
            this.txtMasGist.Name = "txtMasGist";
            this.txtMasGist.Size = new System.Drawing.Size(124, 30);
            this.txtMasGist.TabIndex = 3;
            // 
            // txtMinYear
            // 
            this.txtMinYear.Location = new System.Drawing.Point(259, 34);
            this.txtMinYear.Name = "txtMinYear";
            this.txtMinYear.Size = new System.Drawing.Size(124, 30);
            this.txtMinYear.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите количество лет:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите начальный год:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btCreateMasRound);
            this.groupBox2.Controls.Add(this.dgvMasRound);
            this.groupBox2.Controls.Add(this.txtMinAge);
            this.groupBox2.Controls.Add(this.txtMasRound);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(621, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 342);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные для круговой диаграммы";
            // 
            // btCreateMasRound
            // 
            this.btCreateMasRound.Location = new System.Drawing.Point(101, 151);
            this.btCreateMasRound.Name = "btCreateMasRound";
            this.btCreateMasRound.Size = new System.Drawing.Size(363, 37);
            this.btCreateMasRound.TabIndex = 5;
            this.btCreateMasRound.Text = "Сгенерировать пустой массив";
            this.btCreateMasRound.UseVisualStyleBackColor = true;
            this.btCreateMasRound.Click += new System.EventHandler(this.btCreateMasRound_Click);
            // 
            // dgvMasRound
            // 
            this.dgvMasRound.AllowUserToOrderColumns = true;
            this.dgvMasRound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasRound.Location = new System.Drawing.Point(6, 194);
            this.dgvMasRound.Name = "dgvMasRound";
            this.dgvMasRound.RowHeadersWidth = 51;
            this.dgvMasRound.RowTemplate.Height = 24;
            this.dgvMasRound.Size = new System.Drawing.Size(547, 142);
            this.dgvMasRound.TabIndex = 4;
            // 
            // txtMinAge
            // 
            this.txtMinAge.Location = new System.Drawing.Point(349, 106);
            this.txtMinAge.Name = "txtMinAge";
            this.txtMinAge.Size = new System.Drawing.Size(115, 30);
            this.txtMinAge.TabIndex = 3;
            // 
            // txtMasRound
            // 
            this.txtMasRound.Location = new System.Drawing.Point(349, 57);
            this.txtMasRound.Name = "txtMasRound";
            this.txtMasRound.Size = new System.Drawing.Size(115, 30);
            this.txtMasRound.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Введите минимальный возраст:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 64);
            this.label3.TabIndex = 0;
            this.label3.Text = "Введите количество возрастных категорий:";
            // 
            // chartDiagrams
            // 
            this.chartDiagrams.BackColor = System.Drawing.Color.PeachPuff;
            this.chartDiagrams.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.chartDiagrams.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.chartDiagrams.ChartAreas.Add(chartArea1);
            this.chartDiagrams.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            legend2.Name = "Legend2";
            legend2.Position.Auto = false;
            legend2.Position.Height = 19.26229F;
            legend2.Position.Width = 29F;
            legend2.Position.X = 70F;
            legend2.Position.Y = 52F;
            legend2.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.chartDiagrams.Legends.Add(legend1);
            this.chartDiagrams.Legends.Add(legend2);
            this.chartDiagrams.Location = new System.Drawing.Point(12, 12);
            this.chartDiagrams.Name = "chartDiagrams";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Количество учеников";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea2";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Sector";
            this.chartDiagrams.Series.Add(series1);
            this.chartDiagrams.Series.Add(series2);
            this.chartDiagrams.Size = new System.Drawing.Size(568, 622);
            this.chartDiagrams.TabIndex = 2;
            this.chartDiagrams.Text = "chart1";
            // 
            // btCreateGist
            // 
            this.btCreateGist.Location = new System.Drawing.Point(12, 640);
            this.btCreateGist.Name = "btCreateGist";
            this.btCreateGist.Size = new System.Drawing.Size(272, 62);
            this.btCreateGist.TabIndex = 3;
            this.btCreateGist.Text = "Построить гистограмму";
            this.btCreateGist.UseVisualStyleBackColor = true;
            this.btCreateGist.Click += new System.EventHandler(this.btCreateGist_Click);
            // 
            // btCreateRound
            // 
            this.btCreateRound.Location = new System.Drawing.Point(290, 640);
            this.btCreateRound.Name = "btCreateRound";
            this.btCreateRound.Size = new System.Drawing.Size(301, 62);
            this.btCreateRound.TabIndex = 4;
            this.btCreateRound.Text = "Построить секторную диаграмму";
            this.btCreateRound.UseVisualStyleBackColor = true;
            this.btCreateRound.Click += new System.EventHandler(this.btCreateRound_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(803, 634);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(250, 62);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // frmDiagrams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCreateRound);
            this.Controls.Add(this.btCreateGist);
            this.Controls.Add(this.chartDiagrams);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDiagrams";
            this.Text = "Диаграммы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasGist)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagrams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMasGist;
        private System.Windows.Forms.TextBox txtMinYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCreateMasGist;
        private System.Windows.Forms.DataGridView dgvMasGist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btCreateMasRound;
        private System.Windows.Forms.DataGridView dgvMasRound;
        private System.Windows.Forms.TextBox txtMinAge;
        private System.Windows.Forms.TextBox txtMasRound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagrams;
        private System.Windows.Forms.Button btCreateGist;
        private System.Windows.Forms.Button btCreateRound;
        private System.Windows.Forms.Button btExit;
    }
}

