Imports System.Windows

Namespace MenuCustomization

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

'#Region "#PopupMenuShowing"
        Private Sub SpreadsheetControl_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.Xpf.Spreadsheet.Menu.PopupMenuShowingEventArgs)
            ' Check whether this event was raised for a cell popup menu of the Spreadsheet control.
            If e.MenuType = DevExpress.Xpf.Spreadsheet.SpreadsheetMenuType.Cell Then
                ' Remove the first menu item.
                e.Customizations.Add(New DevExpress.Xpf.Bars.RemoveBarItemAndLinkAction() With {.ItemIndex = 0})
                ' Create a custom menu item.
                Dim menuItem As DevExpress.Xpf.Bars.BarButtonItem = New DevExpress.Xpf.Bars.BarButtonItem()
                menuItem.Name = "customHighlightItem"
                menuItem.Content = "Highlight Selection"
                AddHandler menuItem.ItemClick, New DevExpress.Xpf.Bars.ItemClickEventHandler(AddressOf customHighlightItem_ItemClick)
                ' Insert a new item into the Spreadsheet cell popup menu.
                e.Customizations.Add(menuItem)
            End If
        End Sub

        Private Sub customHighlightItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Me.spreadsheetControl.Selection.FillColor = System.Drawing.Color.Yellow
        End Sub

'#End Region  ' #PopupMenuShowing
'#Region "#PopupMenuCustomization"
        Private Sub customCheckItem_CheckedChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
        ' Implement the custom action.
        ' ...
        End Sub
'#End Region  ' #PopupMenuCustomization
    End Class
End Namespace
