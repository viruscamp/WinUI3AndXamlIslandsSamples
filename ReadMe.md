## WinForms 程序引入 WinUI3 Xaml Islands

0. 项目属性, 依赖项
```xml
  <PropertyGroup>
    <OutputType>WinExe</OutputType>
    <TargetFrameworks>net10.0-windows10.0.19041</TargetFrameworks>
    <TargetPlatformMinVersion>10.0.17763.0</TargetPlatformMinVersion>
    <RuntimeIdentifiers>win-x64</RuntimeIdentifiers>
    <Platforms>x64</Platforms>

    <AppxPackage>false</AppxPackage>
    <WindowsAppSDKSelfContained>true</WindowsAppSDKSelfContained>
    <WindowsPackageType>None</WindowsPackageType>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.WindowsAppSDK" Version="1.8.260317003" />
  </ItemGroup>
```

1. `<WindowsAppSDKSelfContained>true</WindowsAppSDKSelfContained>` 生成如下 `[ModuleInitializer]` 代码
```
AutoInitialize.InitializeWindowsAppSDK();
```

2. 可选 `WinRT.ComWrappersSupport.InitializeComWrappers();`
  - 手写的 Program.cs 最好保留
  - 自动生成的 Program.cs 内包含

3. 必须 `DispatcherQueueController controller = DispatcherQueueController.CreateOnCurrentThread();` xaml 事件队列

4. 可选 `Microsoft.UI.Xaml.Hosting.WindowsXamlManager.InitializeForCurrentThread()` 最好保留
  - 可选路径 `new DesktopWindowXamlSource() -> new UIElement()`
  - 必须路径 `WindowsXamlManager.InitializeForCurrentThread() -> new UIElement() -> new DesktopWindowXamlSource()`

5. 必须 `new DesktopWindowXamlSource` winform 提供给 xaml 的挂载点

6. 可选 `WindowsAppSdkHelper.EnableContentPreTranslateMessageInEventLoop();` 否则 island 不能输入文字

7. 可选 XamlApp

8. 可选 包装类 DesktopWindowXamlSourceControl
