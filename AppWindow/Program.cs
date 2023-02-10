using System.Diagnostics;
using System.Runtime.InteropServices;

internal class Program
{
	[DllImport("user32.dll")]
	public static extern IntPtr FindWindow(string className);
	[DllImport("user32.dll")]
	
	public static extern int SendMessage(IntPtr ptr, uint code, string dop1, string dop2);

	static void Main(string[] args)
	{
		Process[] processes = Process.GetProcesses();
		Process mywindow = new Process();

		foreach (Process process in processes)
		{
			if (process.ProcessName == "AppWindow")
			{
				mywindow = process;
				Console.WriteLine(process.Id);
				Console.WriteLine(process.ProcessName);
				Console.WriteLine(process.MainWindowTitle);

			}


		}
			SendMessage(mywindow.MainWindowHandle, 0x0010, "", "Я твой новый заголовок");
		
	}
}
