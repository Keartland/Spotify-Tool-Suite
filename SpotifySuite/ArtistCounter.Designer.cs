namespace SpotifySuite
{
    partial class ArtistCounter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.GetToken = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.token = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playlist = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // GetToken
            // 
            this.GetToken.Location = new System.Drawing.Point(230, 10);
            this.GetToken.Name = "GetToken";
            this.GetToken.Size = new System.Drawing.Size(75, 23);
            this.GetToken.TabIndex = 7;
            this.GetToken.Text = "Get";
            this.GetToken.UseVisualStyleBackColor = true;
            this.GetToken.Click += new System.EventHandler(this.GetToken_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Token:";
            // 
            // token
            // 
            this.token.Location = new System.Drawing.Point(65, 10);
            this.token.Name = "token";
            this.token.Size = new System.Drawing.Size(159, 20);
            this.token.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Playlist:";
            // 
            // playlist
            // 
            this.playlist.Location = new System.Drawing.Point(65, 36);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(159, 20);
            this.playlist.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Count Artist Songs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.Control;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Location = new System.Drawing.Point(3, 93);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(232, 389);
            this.output.TabIndex = 11;
            this.output.TabStop = false;
            this.output.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "This tool looks at a playlist and counts how many songs by each \r\nartist.";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Menu;
            chartArea3.BackColor = System.Drawing.SystemColors.Menu;
            chartArea3.BackSecondaryColor = System.Drawing.SystemColors.Menu;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.SystemColors.Menu;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            legend3.TitleAlignment = System.Drawing.StringAlignment.Far;
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(170, 93);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.LabelBackColor = System.Drawing.Color.Transparent;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 4;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(462, 389);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "Top 10 split";
            title3.Visible = false;
            this.chart1.Titles.Add(title3);
            // 
            // ArtistCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.output);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playlist);
            this.Controls.Add(this.GetToken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.token);
            this.Name = "ArtistCounter";
            this.Size = new System.Drawing.Size(635, 485);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox token;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox playlist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
