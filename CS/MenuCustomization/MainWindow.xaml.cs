using System.Windows;

namespace MenuCustomization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        #region #PopupMenuShowing
        private void SpreadsheetControl_PopupMenuShowing(object sender, DevExpress.Xpf.Spreadsheet.Menu.PopupMenuShowingEventArgs e)
        {
            // Check whether this event was raised for a cell popup menu of the Spreadsheet control.
            if (e.MenuType == DevExpress.Xpf.Spreadsheet.SpreadsheetMenuType.Cell)
            {
                // Remove the first menu item.
                e.Customizations.Add(new DevExpress.Xpf.Bars.RemoveBarItemAndLinkAction()
                {
                    ItemIndex = 0
                });

                // Create a custom menu item.
                DevExpress.Xpf.Bars.BarButtonItem menuItem = new DevExpress.Xpf.Bars.BarButtonItem();
                menuItem.Name = "customHighlightItem";
                menuItem.Content = "Highlight Selection";
                menuItem.ItemClick += new DevExpress.Xpf.Bars.ItemClickEventHandler(customHighlightItem_ItemClick);
                // Insert a new item into the Spreadsheet cell popup menu.
                e.Customizations.Add(menuItem);
            }
            
        }

        private void customHighlightItem_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            
            spreadsheetControl.Selection.FillColor = System.Drawing.Color.Yellow;
        }
        #endregion #PopupMenuShowing
        #region #PopupMenuCustomization
        private void customCheckItem_CheckedChanged(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            // Implement the custom action.
            // ...
        }
        #endregion #PopupMenuCustomization
    }
}
