using StudentManagement.Models;
using StudentManagement.ViewModels.ReportsFlow;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentManagement.Views.ReportsFlow
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReportBySemesterPage : ContentPage
    {
        private bool _isInitialized;

        public ReportBySemesterPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            if (!_isInitialized)
            {
                var vm = (ReportBySemesterPageViewModel)BindingContext;
                vm.InitData();
                _isInitialized = true;
            }
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var c = (Class)e.Item;
            ListClass.SelectedItem = null;
            var vm = (ReportBySemesterPageViewModel)BindingContext;
            vm.ListClassItemTapped(c);
        }
    }
}
