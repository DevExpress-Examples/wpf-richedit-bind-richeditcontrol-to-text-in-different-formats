<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/BindingConverter/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/BindingConverter/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/BindingConverter/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/BindingConverter/MainWindow.xaml.vb))
<!-- default file list end -->
# How to implement a converter to bind RichEditControl to the text in different formats


<p>This example demonstrates how you can establish data binding with the RichEditControl. <br />
The DXRichEdit for WPF Suite provides a number of converters that can be used to convert RichEditContol's content to and from all supported document formats. They inherit from two base classes - the <a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfRichEditContentToSpecificFormatConvertertopic"><u>ContentToSpecificFormatConverter</u></a> class and the <a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfRichEditSpecificFormatToContentConvertertopic"><u>SpecificFormatToContentConverter</u></a> class.<br />
The code in this example uses the <a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfRichEditContentToPlainTextConvertertopic"><u>ContentToPlainTextConverter</u></a> class to bind standard <strong>TextControl </strong>to the <strong>RichEditControl</strong>, so the TextControl reflects text modifications of the document loaded in the RichEditControl.<br />
A <a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfBarsBarManagertopic"><u>BarManager</u></a> component is added to enable the hover menu feature of the RichEditControl.</p>

<br/>


