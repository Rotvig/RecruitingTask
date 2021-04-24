using System;
using System.Threading;
using LogTest;

namespace Application
{
	class Program
	{
		static void Main(string[] args)
		{
			LogInterface logger = new AsyncLogInterface();

			for (int i = 0; i < 15; i++)
			{
				logger.WriteLog("Number with Flush: " + i.ToString());
				Thread.Sleep(50);
			}

			logger.Stop_With_Flush();

			LogInterface logger2 = new AsyncLogInterface();

			for (int i = 50; i > 0; i--)
			{
				logger2.WriteLog("Number with No flush: " + i.ToString());
				Thread.Sleep(20);
			}

			logger2.Stop_Without_Flush();

			Console.ReadLine();
		}
	}
}