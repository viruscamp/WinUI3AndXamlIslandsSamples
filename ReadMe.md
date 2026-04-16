## WinForms 程序引入 WinUI3 Xaml Islands
1. `<WindowsAppSDKSelfContained>true</WindowsAppSDKSelfContained>` Module.Init
```
AutoInitialize.InitializeWindowsAppSDK();
GlobalVtableLookup.InitializeGlobalVtableLookup();
```
2. 可选 `WinRT.ComWrappersSupport.InitializeComWrappers();`
3. 必须 `DispatcherQueueController controller = DispatcherQueueController.CreateOnCurrentThread();`
4. 可选 `Microsoft.UI.Xaml.Hosting.WindowsXamlManager.InitializeForCurrentThread()`
5. 必须 `new DesktopWindowXamlSource`
  - `new DesktopWindowXamlSource() -> new UIElement()`
  - `WindowsXamlManager.InitializeForCurrentThread() -> new UIElement() -> new DesktopWindowXamlSource()`

6. 可选 XamlApp
7. 可选 `WindowsAppSdkHelper.EnableContentPreTranslateMessageInEventLoop();`
8. 可选 包装类 DesktopWindowXamlSourceControl
