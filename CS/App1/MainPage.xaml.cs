using DevExpress.Data.Filtering;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            EnumProcessingHelper.RegisterEnum(typeof(UserRole));
            this.InitializeComponent();
        }
    }
}
