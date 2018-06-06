using System;
using System.Windows.Forms;

namespace Minecraft_Wii_U_Mod_Injector_Updater
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new UpdaterForm());
		}
	}
}
