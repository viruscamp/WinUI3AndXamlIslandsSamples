using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
	public static class Program
	{
		[STAThread]
		public static void Main()
		{
			WinRT.ComWrappersSupport.InitializeComWrappers();
			App app = new App();
			app.InitializeComponent();
			app.Run();
		}
	}
}
