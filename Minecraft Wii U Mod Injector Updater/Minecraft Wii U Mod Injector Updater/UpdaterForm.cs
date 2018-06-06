using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minecraft_Wii_U_Mod_Injector_Updater.Properties;

namespace Minecraft_Wii_U_Mod_Injector_Updater
{
	public partial class UpdaterForm : Form
	{
		public UpdaterForm()
		{
			this.InitializeComponent();
		}

		private async void UpdaterForm_Load(object sender, EventArgs e)
		{
			for (int i = 5; i > 0; i--)
			{
				this.updaterLabel.Location = new Point(82, 250);
				this.updaterLabel.Text = string.Format("Update starting in {0}", i.ToString());
				await Task.Delay(1000);
				if (i == 1)
				{
					this.StartUpdate();
				}
			}
		}

		private async void StartUpdate()
		{
			try
			{
				bool InjectorisOpen = Process.GetProcessesByName("Minecraft Wii U Mod Injector.exe").FirstOrDefault((Process p) => p.MainModule.FileName.StartsWith(Application.StartupPath)) != null;
				bool flag = InjectorisOpen;
				if (flag)
				{
					this.updaterLabel.Text = "Unable to update! :( (Already running)";
					this.updaterLabel.Location = new Point(23, 250);
					await Task.Delay(2000);
					Application.Exit();
				}
				else
				{
					this.DownloadFile("http://slothwiiplaza.bplaced.net/minecraftwiiu/Minecraft%20Wii%20U%20Mod%20Injector.exe", Application.StartupPath + "/Minecraft Wii U Mod Injector.exe");
					this.updaterLabel.Location = new Point(45, 250);
					this.updaterLabel.Text = "Your injector is being updated!";
				}
			}
			catch (Exception error)
			{
				MessageBox.Show(error.ToString());
			}
		}

		public void DownloadFile(string urlAddress, string location)
		{
			using (this.webClient = new WebClient())
			{
				this.webClient.DownloadFileCompleted += this.Completed;
				this.webClient.DownloadProgressChanged += this.ProgressChanged;
				Uri address = urlAddress.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ? new Uri(urlAddress) : new Uri("http://" + urlAddress);
				try
				{
					this.webClient.DownloadFileAsync(address, location);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			this.progressBar.Value = e.ProgressPercentage;
			bool flag = this.progressLabel.Text == "100 %";
			if (flag)
			{
				this.progressLabel.Text = "<3";
			}
			else
			{
				this.progressLabel.Text = e.ProgressPercentage.ToString() + " %";
			}
		}

		private void Completed(object sender, AsyncCompletedEventArgs e)
		{
			bool cancelled = e.Cancelled;
			if (cancelled)
			{
				MessageBox.Show("Download has been cancelled/corrupted :(");
			}
			else
			{
				Process.Start(Application.StartupPath + "/Minecraft Wii U Mod Injector.exe");
				base.Close();
			}
		}

		private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://paypal.me/SlothWiiPlaza");
		}

		private WebClient webClient;
	}
}
