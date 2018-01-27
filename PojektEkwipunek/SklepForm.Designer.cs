namespace ProjektEkwipunek
{
    partial class SklepForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ListaPrzedmiotowGrid = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ZalozButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPrzedmiotowGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaPrzedmiotowGrid
            // 
            this.ListaPrzedmiotowGrid.AllowUserToAddRows = false;
            this.ListaPrzedmiotowGrid.AllowUserToDeleteRows = false;
            this.ListaPrzedmiotowGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaPrzedmiotowGrid.Location = new System.Drawing.Point(12, 12);
            this.ListaPrzedmiotowGrid.Name = "ListaPrzedmiotowGrid";
            this.ListaPrzedmiotowGrid.ReadOnly = true;
            this.ListaPrzedmiotowGrid.RowTemplate.Height = 28;
            this.ListaPrzedmiotowGrid.Size = new System.Drawing.Size(1001, 205);
            this.ListaPrzedmiotowGrid.TabIndex = 0;
            this.ListaPrzedmiotowGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaPrzedmiotowGrid_RowEnter);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(33, 235);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(388, 419);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // ZalozButton
            // 
            this.ZalozButton.Location = new System.Drawing.Point(829, 235);
            this.ZalozButton.Name = "ZalozButton";
            this.ZalozButton.Size = new System.Drawing.Size(184, 57);
            this.ZalozButton.TabIndex = 2;
            this.ZalozButton.Text = "Zaloz";
            this.ZalozButton.UseVisualStyleBackColor = true;
            this.ZalozButton.Click += new System.EventHandler(this.ZalozButton_Click);
            // 
            // SklepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 666);
            this.Controls.Add(this.ZalozButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ListaPrzedmiotowGrid);
            this.Name = "SklepForm";
            this.Text = "SklepForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SklepForm_FormClosed);
            this.Load += new System.EventHandler(this.SklepForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaPrzedmiotowGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaPrzedmiotowGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button ZalozButton;
    }
}