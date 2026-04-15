using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;

namespace WinUI3App
{
    public class App : Application
    {
        public event EventHandler<LaunchActivatedEventArgs>? Launched;

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            Launched?.Invoke(this, args);
        }
    }
}
