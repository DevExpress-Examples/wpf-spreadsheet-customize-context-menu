using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Spreadsheet;
using DevExpress.Xpf.Spreadsheet.Menu;
using DevExpress.XtraSpreadsheet.Commands;

namespace MenuCustomization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DevExpress.Xpf.Core.DXWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            spreadsheetControl1.Document.Worksheets[0].Cells["B2"].Value = "Right-click any cell or column header to display the custom context menu";
        }

        #region #PopupMenuShowing
        private void SpreadsheetControlPopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            // Check whether this event was raised for a cell popup menu of the Spreadsheet control.
            if (e.MenuType == SpreadsheetMenuType.Cell)
            {
                // Remove the "Clear Contents" menu item.
                e.Customizations.Add(new RemoveSpreadsheetCommandAction() { Id = SpreadsheetCommandId.FormatClearContentsContextMenuItem });

                // Create a menu item for the Spreadsheet command, which inserts a picture into a worksheet.
                e.Customizations.Add(new BarButtonItem() { Command = SpreadsheetUICommand.InsertPicture,
                    Content = "Insert Picture", CommandParameter = spreadsheetControl1 });

                // Create a custom menu item and handle its click event.
                BarButtonItem menuItem = new BarButtonItem();
                menuItem.Name = "customHighlightItem";
                menuItem.Content = "Highlight Selection";
                menuItem.ItemClick += new ItemClickEventHandler(customHighlightItem_ItemClick);
                e.Customizations.Add(menuItem);
            }
        }

            private void customHighlightItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Fill the selection with the yellow color. 
            spreadsheetControl1.Selection.FillColor = System.Drawing.Color.Yellow;
        }
        #endregion #PopupMenuShowing
    }
}
