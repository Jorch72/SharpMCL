﻿using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SharpMCL
{
	public partial class LauncherForm : Form
	{
		public LauncherForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			DirectoryInfo IntancesDir = new DirectoryInfo(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @".\Instances");
			foreach (var d in IntancesDir.GetDirectories())
			{
				listBox1.Items.Add(d.Name);
			}
			foreach (var d in IntancesDir.GetFiles())
			{
				listBox1.Items.Add(d.Name);
			}
		}

		private KonamiSequence sequence = new KonamiSequence();

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (sequence.IsCompletedBy(e.KeyCode))
			{
				MessageBox.Show("KONAMI!!!");
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			String InstanceName = "";
			String UserName = "";
			InstanceName = listBox1.Text;
			UserName = textBox1.Text;
			String ClientPath = @"\Instances\" + InstanceName + @"\";
			String clientdir = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + ClientPath;
			String client = InstanceName;
			String user = UserName;
			String uuid = Guid.NewGuid().ToString();
			String session = "0";
			this.Close();
			Program.start(clientdir, client, user, uuid, session);
		}

		private void GroupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void TextBox1_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}
	}
}
