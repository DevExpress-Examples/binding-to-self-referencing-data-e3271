Imports Microsoft.VisualBasic
Imports System.Windows.Controls

Namespace DXTreeList_DataBinding
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			treeListControl1.ItemsSource = Stuff.GetStuff()
			treeListControl1.View.ExpandAllNodes()
		End Sub
	End Class
End Namespace
