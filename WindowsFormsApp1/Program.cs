using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// For UI thread exception
			Application.ThreadException +=
				new ThreadExceptionEventHandler(GlobalExceptionHandler);

			// Force all Windows Forms errors to go through our handler
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

			// For non-UI thread exceptions
			AppDomain.CurrentDomain.UnhandledException +=
				new UnhandledExceptionEventHandler(GlobalExceptionHandler);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new OrderWin());
		}

		private static void GlobalExceptionHandler(object sender, EventArgs e)
		{
			// Log the issue
			MessageBox.Show("There was a problem with the application. Please contact support.");
			System.Windows.Forms.Application.Exit();
		}
	}
}
