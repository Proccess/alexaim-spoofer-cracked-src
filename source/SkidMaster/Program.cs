using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Diagnostics;
using System.Net;
using System.IO;

namespace Cracked
{
    class Program
    {
		public static string RandomString(int length)
		{
			Random random = new Random();
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", length)
							   select s[random.Next(s.Length)]).ToArray<char>());
		}
		public static void Main(string[] args)
        {
			Console.Title = "AlexAim HWID Spoofer - Cracked By Process#7122";
			MessageBox.Show("AlexAim HWID Spoofer - Cracked By Process#7122");
			Console.WriteLine("Loading Files...");
			string str = "https://alexisaim.com/dfsdfalsdfsdfkee234137689fdsjfahdsfiewu/qwer2341324ewqrwerfdffer24/";
			WebClient webClient = new WebClient();
			webClient.Proxy = null;
			string str2 = Program.RandomString(10);
			string text = Program.RandomString(10);
			string text2 = Program.RandomString(10);
			string text3 = Program.RandomString(10);
			string text4 = Program.RandomString(10);
			try
			{
				webClient.DownloadFile(str + "RUN%20THIS.bat", Path.GetTempPath() + "\\" + str2 + ".bat");
				webClient.DownloadFile(str + "config.sys", Path.GetTempPath() + "\\" + text + ".sys");
				webClient.DownloadFile(str + "driverLoader.exe", Path.GetTempPath() + "\\" + text2 + ".exe");
				webClient.DownloadFile(str + "driverSpoofer.sys", Path.GetTempPath() + "\\" + text3 + ".sys");
				webClient.DownloadFile(str + "driverTracer.exe", Path.GetTempPath() + "\\" + text4 + ".exe");
			}
			catch
			{
				MessageBox.Show("Error while downloading. Please clear your TEMP-Folder!", "Spoofer");
			}
			string text5 = File.ReadAllText(Path.GetTempPath() + "\\" + str2 + ".bat");
			File.WriteAllText(Path.GetTempPath() + "\\" + str2 + ".bat", text5.Replace("driverLoader.exe", text2 + ".exe").Replace("config.sys", text + ".sys").Replace("driverSpoofer.sys", text3 + ".sys").Replace("driverTracer.exe", text4 + ".exe"));
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Normal,
					FileName = Path.GetTempPath() + "\\" + str2 + ".bat",
					Verb = "runas"
				}
			}.Start();
			Console.WriteLine("Spoofing done! Press any key to exit...");
			Console.ForegroundColor = ConsoleColor.White;
			Console.Read();
			File.Delete(Path.GetTempPath() + "\\" + text4 + ".exe");
			Environment.Exit(0);


			Console.ReadLine();
		}
    }
}
