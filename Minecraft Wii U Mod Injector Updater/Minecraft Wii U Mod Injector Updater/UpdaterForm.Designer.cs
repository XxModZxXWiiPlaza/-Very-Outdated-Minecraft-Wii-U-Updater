namespace Minecraft_Wii_U_Mod_Injector_Updater
{
	public partial class UpdaterForm : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.updaterLabel = new global::System.Windows.Forms.Label();
			this.progressBar = new global::System.Windows.Forms.ProgressBar();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.progressLabel = new global::System.Windows.Forms.Label();
			this.donateLabel = new global::System.Windows.Forms.LinkLabel();
			base.SuspendLayout();
			this.updaterLabel.AutoSize = true;
			this.updaterLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.updaterLabel.Font = new global::System.Drawing.Font("Segoe UI", 12.25f);
			this.updaterLabel.ForeColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.updaterLabel.Location = new global::System.Drawing.Point(45, 250);
			this.updaterLabel.Name = "updaterLabel";
			this.updaterLabel.Size = new global::System.Drawing.Size(171, 23);
			this.updaterLabel.TabIndex = 0;
			this.updaterLabel.Text = "Update starting in {i};";
			this.progressBar.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.progressBar.ForeColor = global::System.Drawing.Color.Crimson;
			this.progressBar.Location = new global::System.Drawing.Point(12, 207);
			this.progressBar.MarqueeAnimationSpeed = 60;
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new global::System.Drawing.Size(310, 17);
			this.progressBar.Step = 1;
			this.progressBar.TabIndex = 1;
			this.panel1.BackColor = global::System.Drawing.Color.Transparent;
			this.panel1.BackgroundImage = global::Minecraft_Wii_U_Mod_Injector_Updater.Properties.Resources.MinecraftModInjectorLogo1;
			this.panel1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.panel1.Location = new global::System.Drawing.Point(68, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(199, 164);
			this.panel1.TabIndex = 2;
			this.progressLabel.AutoSize = true;
			this.progressLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.progressLabel.Font = new global::System.Drawing.Font("Segoe UI", 12.25f);
			this.progressLabel.ForeColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.progressLabel.Location = new global::System.Drawing.Point(151, 227);
			this.progressLabel.Name = "progressLabel";
			this.progressLabel.Size = new global::System.Drawing.Size(33, 23);
			this.progressLabel.TabIndex = 3;
			this.progressLabel.Text = "0%";
			this.donateLabel.ActiveLinkColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.donateLabel.AutoSize = true;
			this.donateLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.donateLabel.LinkColor = global::System.Drawing.Color.Crimson;
			this.donateLabel.Location = new global::System.Drawing.Point(9, 305);
			this.donateLabel.Name = "donateLabel";
			this.donateLabel.Size = new global::System.Drawing.Size(43, 13);
			this.donateLabel.TabIndex = 4;
			this.donateLabel.TabStop = true;
			this.donateLabel.Text = "donate!";
			this.donateLabel.VisitedLinkColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.donateLabel.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Minecraft_Wii_U_Mod_Injector_Updater.Properties.Resources.FloatingSwords;
			base.ClientSize = new global::System.Drawing.Size(334, 327);
			base.Controls.Add(this.donateLabel);
			base.Controls.Add(this.progressLabel);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.progressBar);
			base.Controls.Add(this.updaterLabel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "UpdaterForm";
			this.Text = "Minecraft Wii U Mod Injector Updater";
			base.Load += new global::System.EventHandler(this.UpdaterForm_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components = null;

		private global::System.Windows.Forms.Label updaterLabel;

		private global::System.Windows.Forms.ProgressBar progressBar;

		private global::System.Windows.Forms.Panel panel1;

		private global::System.Windows.Forms.Label progressLabel;

		private global::System.Windows.Forms.LinkLabel donateLabel;
	}
}
