using StudentManagement.Models;
using StudentManagement.ViewModels.ReportsFlow;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentManagement.Views.ReportsFlow
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReportBySubjectPage : ContentPage
    {
        public ReportBySubjectPage()
        {
            InitializeComponent();
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var c = (Class)e.Item;
            ListClass.SelectedItem = null;
            var vm = (ReportBySubjectPageViewModel)BindingContext;
            vm.ListClassItemTapped(c);
        }
    }
}
