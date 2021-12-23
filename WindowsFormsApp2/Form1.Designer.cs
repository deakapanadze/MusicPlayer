namespace WindowsFormsApp2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.ListBoxSongs = new System.Windows.Forms.ListBox();
			this.btnSelectSongs = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Orange;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(887, 64);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Music Player App";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Fuchsia;
			this.pictureBox1.Location = new System.Drawing.Point(815, 21);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(46, 28);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// ListBoxSongs
			// 
			this.ListBoxSongs.FormattingEnabled = true;
			this.ListBoxSongs.Location = new System.Drawing.Point(651, 70);
			this.ListBoxSongs.Name = "ListBoxSongs";
			this.ListBoxSongs.Size = new System.Drawing.Size(224, 290);
			this.ListBoxSongs.TabIndex = 1;
			this.ListBoxSongs.SelectedIndexChanged += new System.EventHandler(this.ListBoxSongs_SelectedIndexChanged);
			// 
			// btnSelectSongs
			// 
			this.btnSelectSongs.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSelectSongs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnSelectSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSelectSongs.Location = new System.Drawing.Point(651, 393);
			this.btnSelectSongs.Name = "btnSelectSongs";
			this.btnSelectSongs.Size = new System.Drawing.Size(224, 51);
			this.btnSelectSongs.TabIndex = 2;
			this.btnSelectSongs.Text = "Select Songs";
			this.btnSelectSongs.UseVisualStyleBackColor = false;
			this.btnSelectSongs.Click += new System.EventHandler(this.btnSelectSongs_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.label2.Location = new System.Drawing.Point(353, 460);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Developed By Dea Kapanadze";
			// 
			// axWindowsMediaPlayer1
			// 
			this.axWindowsMediaPlayer1.Enabled = true;
			this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 70);
			this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
			this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
			this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(622, 374);
			this.axWindowsMediaPlayer1.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(887, 482);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.axWindowsMediaPlayer1);
			this.Controls.Add(this.btnSelectSongs);
			this.Controls.Add(this.ListBoxSongs);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox ListBoxSongs;
		private System.Windows.Forms.Button btnSelectSongs;
		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
		private System.Windows.Forms.Label label2;
	}
}

