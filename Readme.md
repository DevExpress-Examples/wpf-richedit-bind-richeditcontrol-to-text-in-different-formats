<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128607769/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2794)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Rich Text Editor for WPF - Implement a Converter to Bind RichEditControl to the Text in Different Formats


This example demonstrates how you can establish data binding with the RichEditControl.

The code in this example uses the [ContentToPlainTextConverter](https://docs.devexpress.com/WPF/DevExpress.Xpf.RichEdit.ContentToPlainTextConverter) class to bind standard **TextControl** to the **RichEditControl**, so the TextControl reflects text modifications of the document loaded in the RichEditControl.

The [BarManager](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarManager) component is added to enable the hover menu feature of the RichEditControl.

## Files to Review

* [MainWindow.xaml](./CS/BindingConverter/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/BindingConverter/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/BindingConverter/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/BindingConverter/MainWindow.xaml.vb))


