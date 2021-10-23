using System;
using System.Net;
using System.Threading;

namespace HeckerApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Initialization();


			Intro();
			DisplayText(" ?");
			
			
		}


		static void Initialization()
		{
			Console.WindowHeight = Console.LargestWindowHeight /2;
			Console.WindowWidth = Console.LargestWindowWidth /2;
			Console.CursorVisible = false;

		}

		static void Intro()
		{
			for (int i = 0; i < 2; i++)
			{
				Console.Beep();
			}

			Console.Beep(3000, 500);

			Console.ForegroundColor = ConsoleColor.DarkGreen;

			Loading(1000);
			Console.Clear();

			Console.WriteLine("Acces : ok");
			Console.Beep(2000, 500);
			Thread.Sleep(800);
			Console.WriteLine("Ip adress : " + Dns.GetHostName());

			Thread.Sleep(800);
			Console.Beep(2500, 500);
			string strHostName = Dns.GetHostName();
			IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

			Console.ForegroundColor = ConsoleColor.Red;
			int nIP = 0;
			foreach (IPAddress ipaddress in iphostentry.AddressList)
			{
				Console.WriteLine("IP #" + ++nIP + ": " + ipaddress.ToString());

				Console.ForegroundColor = ConsoleColor.DarkGreen;
				Thread.Sleep(200);
			}
			Thread.Sleep(500);
			Console.WriteLine("-----------------------------------------------------------------------");
			Thread.Sleep(100);
			Console.WriteLine("Starting");
			Thread.Sleep(300);
			Console.WriteLine("ok");

			Console.Beep(3000, 500);

			Console.Clear();
		}

		public static void DisplayText(string text)
		{
			foreach (char c in text)
			{
				int d = 60;

				Console.Write(c);

				if (c == ' ')
				{
					d = 200;

				}
				else if (c == '.' || c == '?' || c == '!')
				{
					d = 600;
				}


				Thread.Sleep(d);

			}


		}

		public static void Loading(int duration)
		{
			int numP = 0;

			for (int i = 0; i < duration; i += 6)
			{
				Clear();

				Console.SetCursorPosition(0, 0);
				Console.Write("Loading");

				if (numP == 300)
				{
					numP = 0;
				}
				else
				{
					numP += 6;
				}

				if (numP == 0)
				{
					Console.Write("   ");
				}
				else if (numP < 100)
				{
					Console.Write(".  ");
				}
				else if (numP < 200)
				{
					Console.Write(".. ");
				}
				else if (numP < 300)
				{
					Console.Write("...");
				}

				Thread.Sleep(6);
			}

		}

		public static void Clear()
		{
			Console.SetCursorPosition(0, 0);
			for (int i = 0; i < 27; i++)
			{
				Console.WriteLine("                                                                                        ");

			}
		}

	}
}
