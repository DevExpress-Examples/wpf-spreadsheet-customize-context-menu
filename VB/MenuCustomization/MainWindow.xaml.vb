Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Spreadsheet
Imports DevExpress.Xpf.Spreadsheet.Menu
Imports DevExpress.XtraSpreadsheet.Commands

Namespace MenuCustomization

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits DevExpress.Xpf.Core.DXWindow

        Public Sub New()
            Me.InitializeComponent()
            Me.spreadsheetControl1.Document.Worksheets(0).Cells("B2").Value = "Right-click any cell or column header to display the custom context menu"
        End Sub

#Region "#PopupMenuShowing"
        Private Sub SpreadsheetControlPopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            ' Check whether this event was raised for a cell popup menu of the Spreadsheet control.
            If e.MenuType = SpreadsheetMenuType.Cell Then
                ' Remove the "Clear Contents" menu item.
                e.Customizations.Add(New RemoveSpreadsheetCommandAction() With {.Id = SpreadsheetCommandId.FormatClearContentsContextMenuItem})
                ' Create a menu item for the Spreadsheet command, which inserts a picture into a worksheet.
                e.Customizations.Add(New BarButtonItem() With {.Command = SpreadsheetUICommand.InsertPicture, .Content = "Insert Picture", .CommandParameter = Me.spreadsheetControl1})
                ' Create a custom menu item and handle its click event.
                Dim menuItem As BarButtonItem = New BarButtonItem()
                menuItem.Name = "customHighlightItem"
                menuItem.Content = "Highlight Selection"
                AddHandler menuItem.ItemClick, New ItemClickEventHandler(AddressOf customHighlightItem_ItemClick)
                e.Customizations.Add(menuItem)
            End If
        End Sub

        Private Sub customHighlightItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            ' Fill the selection with the yellow color. 
            Me.spreadsheetControl1.Selection.FillColor = System.Drawing.Color.Yellow
        End Sub
#End Region  ' #PopupMenuShowing
    End Class
End Namespace
