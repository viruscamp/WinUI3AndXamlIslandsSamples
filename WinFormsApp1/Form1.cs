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

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            var panelWindowId = new WindowId((ulong)panel1.Handle); // 官方示例直接转换
            var wid = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(panel1.Handle); // 文档 https://learn.microsoft.com/zh-cn/windows/apps/desktop/modernize/winrt-com-interop-csharp
            //MessageBox.Show($"wid={wid.Value} panelWindowId={panelWindowId.Value}");

            _desktopWindowXamlSource = new DesktopWindowXamlSource();
            // 将XAML源附加到当前窗体上特定的面板或控件（比如一个Panel）的句柄
            var interop = _desktopWindowXamlSource;
            interop.Initialize(wid);

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
    }
}