using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfSpreadsheetMenuCustomization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DevExpress.Xpf.Core.ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            spreadsheetControl.ActiveWorksheet.Cells["B2"].Value = "Right-click a cell to display the custom context menu";
        }

        #region HighlightCells
        private void HighlightCells_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            // Fill selected cells with the yellow color. 
            spreadsheetControl.Selection.FillColor = System.Drawing.Color.Yellow;
        }
        #endregion
    }
}
