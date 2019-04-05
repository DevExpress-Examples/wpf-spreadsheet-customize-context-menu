<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MenuCustomization/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MenuCustomization/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MenuCustomization/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MenuCustomization/MainWindow.xaml.vb))
<!-- default file list end -->
# How to customize the popup menu of the WPF Spreadsheet control


<p>The following example illustrates how to customize the Spreadsheet control popup menus by removing existing menu items and adding new items.<br>In XAML, add new <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfBarsBarItemtopic">BarItem elements</a> and <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfBarsRemoveBarItemAndLinkActiontopic">RemoveBarItemAndLinkAction</a> actions to the <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfSpreadsheetMenuSpreadsheetMenuCustomizationtopic">SpreadsheetMenuCustomization</a> object contained in the <a href="http://help.devexpress.com/#WPF/DevExpressXpfSpreadsheetSpreadsheetControl_MenuCustomizationstopic">SpreadsheetControl.MenuCustomizations</a> collection.<br>At runtime, handle the <a href="http://help.devexpress.com/#WPF/DevExpressXpfSpreadsheetSpreadsheetControl_PopupMenuShowingtopic">PopupMenuShowing</a> event and add new <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfBarsBarItemtopic">BarItem elements</a> and <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfBarsRemoveBarItemAndLinkActiontopic">RemoveBarItemAndLinkAction</a> actions to the <a href="http://help.devexpress.com/#WPF/DevExpressXpfSpreadsheetMenuPopupMenuShowingEventArgs_Customizationstopic">e.Customizations</a> collection.<br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-customize-the-popup-menu-of-the-wpf-spreadsheet-control-e5147/15.2.4+/media/fbd0f7df-38f2-4d1d-82ef-a662af9ac426.png"></p>

<br/>


