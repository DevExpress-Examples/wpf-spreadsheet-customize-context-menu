Imports System.Linq

Namespace WpfSpreadsheetMenuCustomization

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits DevExpress.Xpf.Core.ThemedWindow

        Public Sub New()
            InitializeComponent()
            spreadsheetControl.ActiveWorksheet.Cells("B2").Value = "Right-click a cell to display the custom context menu"
        End Sub

#Region "HighlightCells"
        Private Sub HighlightCells_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            ' Fill selected cells with the yellow color. 
            spreadsheetControl.Selection.FillColor = System.Drawing.Color.Yellow
        End Sub
#End Region
    End Class
End Namespace
