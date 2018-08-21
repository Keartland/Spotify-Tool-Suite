namespace SpotifySuite
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.artistCounter = new System.Windows.Forms.Button();
            this.playlistComparer = new System.Windows.Forms.Button();
            this.startScreen1 = new SpotifySuite.StartScreen();
            this.playlistComparer1 = new SpotifySuite.PlaylistComparer();
            this.dragControl1 = new SpotifySuite.DragControl();
            this.artistCounter1 = new SpotifySuite.ArtistCounter();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.close);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VCR OSD Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Spotify Suite";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.close.Location = new System.Drawing.Point(740, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(63, 50);
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.artistCounter);
            this.panel1.Controls.Add(this.playlistComparer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 485);
            this.panel1.TabIndex = 1;
            // 
            // artistCounter
            // 
            this.artistCounter.FlatAppearance.BorderSize = 0;
            this.artistCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artistCounter.Font = new System.Drawing.Font("VCR OSD Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistCounter.Location = new System.Drawing.Point(0, 64);
            this.artistCounter.Name = "artistCounter";
            this.artistCounter.Size = new System.Drawing.Size(168, 65);
            this.artistCounter.TabIndex = 1;
            this.artistCounter.TabStop = false;
            this.artistCounter.Text = "Artist Counter";
            this.artistCounter.UseVisualStyleBackColor = true;
            this.artistCounter.Click += new System.EventHandler(this.artistCounter_Click);
            // 
            // playlistComparer
            // 
            this.playlistComparer.FlatAppearance.BorderSize = 0;
            this.playlistComparer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playlistComparer.Font = new System.Drawing.Font("VCR OSD Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistComparer.Location = new System.Drawing.Point(0, 0);
            this.playlistComparer.Name = "playlistComparer";
            this.playlistComparer.Size = new System.Drawing.Size(168, 65);
            this.playlistComparer.TabIndex = 0;
            this.playlistComparer.TabStop = false;
            this.playlistComparer.Text = "Playlist Comparer";
            this.playlistComparer.UseVisualStyleBackColor = true;
            this.playlistComparer.Click += new System.EventHandler(this.playlistComparer_Click);
            // 
            // startScreen1
            // 
            this.startScreen1.Location = new System.Drawing.Point(165, 50);
            this.startScreen1.Name = "startScreen1";
            this.startScreen1.Size = new System.Drawing.Size(635, 485);
            this.startScreen1.TabIndex = 2;
            // 
            // playlistComparer1
            // 
            this.playlistComparer1.Location = new System.Drawing.Point(165, 50);
            this.playlistComparer1.Name = "playlistComparer1";
            this.playlistComparer1.Size = new System.Drawing.Size(635, 485);
            this.playlistComparer1.TabIndex = 3;
            // 
            // dragControl1
            // 
            this.dragControl1.selectControl = this.panelHeader;
            // 
            // artistCounter1
            // 
            this.artistCounter1.Location = new System.Drawing.Point(165, 50);
            this.artistCounter1.Name = "artistCounter1";
            this.artistCounter1.Size = new System.Drawing.Size(635, 485);
            this.artistCounter1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.startScreen1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.playlistComparer1);
            this.Controls.Add(this.artistCounter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Spotify Suite";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private DragControl dragControl1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button playlistComparer;
        private System.Windows.Forms.Button artistCounter;
        private System.Windows.Forms.Label label1;
        private StartScreen startScreen1;
        private PlaylistComparer playlistComparer1;
        private ArtistCounter artistCounter1;
    }
}

