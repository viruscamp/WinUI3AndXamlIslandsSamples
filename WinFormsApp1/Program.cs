using System;
using System.Windows.Forms;
using Microsoft.UI.Dispatching;

namespace WinFormsApp1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            global::WinRT.ComWrappersSupport.InitializeComWrappers();
            // Island-support: This is required to use the WindowsAppSDK UI stack on the thread.
            var controller = DispatcherQueueController.CreateOnCurrentThread();

            //ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // Island-support: Shut down the DispatcherQueue and all the WindowsAppSDK UI objects on the thread.
            controller.ShutdownQueue();
        }
    }
}
