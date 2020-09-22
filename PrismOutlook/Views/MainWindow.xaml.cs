using Infragistics.Windows.Ribbon;
using System.Windows;

namespace PrismOutlook.Views
{
#if MahApps_Metro
    using MahApps.Metro.Controls;
    using MahApps.Metro.Controls.Dialogs;
#endif
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : XamRibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Infragistics.Themes.ThemeManager.ApplicationTheme = new Infragistics.Themes.Office2013Theme();
        }
    }
}
