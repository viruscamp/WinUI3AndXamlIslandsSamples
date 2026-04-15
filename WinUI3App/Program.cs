// See https://www.cnblogs.com/lindexi/p/17678659.html

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

global::WinRT.ComWrappersSupport.InitializeComWrappers();

Application.Start((p) =>
{
    var window = new Window()
    {
        Title = "控制台创建应用"
    };
    window.Content = new Grid()
    {
        Children =
                    {
                        new TextBlock()
                        {
                            Text = "控制台应用",
                            HorizontalAlignment = HorizontalAlignment.Center,
                            VerticalAlignment = VerticalAlignment.Center
                        }
                    }
    };
    window.Activate();
});
