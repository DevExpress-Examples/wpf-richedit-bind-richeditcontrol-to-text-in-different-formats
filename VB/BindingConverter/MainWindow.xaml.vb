Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.XtraRichEdit

Namespace BindingConverter

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            AddHandler Me.richEditControl1.Loaded, New RoutedEventHandler(AddressOf richEditControl1_Loaded)
        End Sub

        Private Sub richEditControl1_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.richEditControl1.LoadDocument("sample.docx", DocumentFormat.OpenXml)
        End Sub
    End Class
End Namespace
