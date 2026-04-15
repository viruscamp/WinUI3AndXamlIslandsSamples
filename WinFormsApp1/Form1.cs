
using System;
using System.Windows.Forms;
using Microsoft.UI.Xaml.Hosting;
using Microsoft.UI;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private DesktopWindowXamlSource? _desktopWindowXamlSource;

        private Panel panel1;

        public Form1()
        {
            InitializeComponent();

            panel1 = new Panel();
            panel1.Dock = DockStyle.Fill;

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _desktopWindowXamlSource = new DesktopWindowXamlSource();
            // 将XAML源附加到当前窗体上特定的面板或控件（比如一个Panel）的句柄
            var interop = _desktopWindowXamlSource;
            Windowing_GetWindowIdFromWindow(panel1.Handle, out var windowId);
            interop.Initialize(windowId);

            interop.Content = new Microsoft.UI.Xaml.Controls.TextBlock
            {
                Text = "Hello from WinUI 3 in WinForms!",
                FontSize = 24,
                HorizontalAlignment = Microsoft.UI.Xaml.HorizontalAlignment.Center,
                VerticalAlignment = Microsoft.UI.Xaml.VerticalAlignment.Center
            };

            // 创建你的WinUI 3控件实例
            //var myControl = new MyWinUI3Library.MyWinUI3Control();

            // 将控件设置为桌面窗口源的内容
            //interop.Content = myControl;
        }

        [DllImport("Microsoft.Internal.FrameworkUdk.dll")]
        private static extern int Windowing_GetWindowIdFromWindow(IntPtr hwnd, out WindowId windowId);
    }
}