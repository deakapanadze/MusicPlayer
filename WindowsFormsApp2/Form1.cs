using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		String[] paths, files;

		private void btnSelectSongs_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = true;
			if(openFileDialog.ShowDialog() == DialogResult.OK)
			{
				paths = openFileDialog.FileNames;
				files = openFileDialog.SafeFileNames;
				for (int i = 0; i < files.Length; i++)
				{
					ListBoxSongs.Items.Add(files[i]);
				}
			}
		}

		private void ListBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
		{
			axWindowsMediaPlayer1.URL = paths[ListBoxSongs.SelectedIndex];
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
