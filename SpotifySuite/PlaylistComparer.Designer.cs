namespace SpotifySuite
{
    partial class PlaylistComparer
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
            this.token = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fplaylist = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GetToken = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.splaylist = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.difSongs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // token
            // 
            this.token.Location = new System.Drawing.Point(65, 10);
            this.token.Name = "token";
            this.token.Size = new System.Drawing.Size(159, 20);
            this.token.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Token:";
            // 
            // fplaylist
            // 
            this.fplaylist.Location = new System.Drawing.Point(65, 37);
            this.fplaylist.Name = "fplaylist";
            this.fplaylist.Size = new System.Drawing.Size(159, 20);
            this.fplaylist.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Playlist 1:";
            // 
            // GetToken
            // 
            this.GetToken.Location = new System.Drawing.Point(230, 10);
            this.GetToken.Name = "GetToken";
            this.GetToken.Size = new System.Drawing.Size(75, 23);
            this.GetToken.TabIndex = 4;
            this.GetToken.Text = "Get";
            this.GetToken.UseVisualStyleBackColor = true;
            this.GetToken.Click += new System.EventHandler(this.GetToken_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Analyse Playlist";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Playlist 2:";
            // 
            // splaylist
            // 
            this.splaylist.Location = new System.Drawing.Point(65, 63);
            this.splaylist.Name = "splaylist";
            this.splaylist.Size = new System.Drawing.Size(159, 20);
            this.splaylist.TabIndex = 7;
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.Menu;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Location = new System.Drawing.Point(3, 127);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(629, 355);
            this.output.TabIndex = 8;
            this.output.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Amount of different songs";
            // 
            // difSongs
            // 
            this.difSongs.AutoSize = true;
            this.difSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difSongs.Location = new System.Drawing.Point(492, 18);
            this.difSongs.Name = "difSongs";
            this.difSongs.Size = new System.Drawing.Size(140, 73);
            this.difSongs.TabIndex = 11;
            this.difSongs.Text = "000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 39);
            this.label5.TabIndex = 12;
            this.label5.Text = "This tool compares spotify playlists, enter both \r\nplaylists and your api token, " +
    "to see the songs that\r\nare different in each playlist.";
            // 
            // PlaylistComparer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.difSongs);
            this.Controls.Add(this.output);
            this.Controls.Add(this.splaylist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GetToken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fplaylist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.token);
            this.Name = "PlaylistComparer";
            this.Size = new System.Drawing.Size(635, 485);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox token;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fplaylist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetToken;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox splaylist;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label difSongs;
        private System.Windows.Forms.Label label5;
    }
}
