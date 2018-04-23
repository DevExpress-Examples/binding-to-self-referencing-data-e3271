using System.Windows.Controls;

namespace DXTreeList_DataBinding {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            treeListControl1.ItemsSource = Stuff.GetStuff();
            treeListControl1.View.ExpandAllNodes();
        }
    }
}
