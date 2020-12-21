using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using StudentManagement.Models;
using StudentManagement.Helpers;
using StudentManagement.ViewModels.CommonPage;

namespace StudentManagement.Views.CommonPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminRoleInfoPage : ContentPage
    {
        public AdminRoleInfoPage()
        {
            InitializeComponent();
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var account = (Account)e.Item;
            ListViewAccounts.SelectedItem = null;
            var vm = (AdminRoleInfoPageViewModel)BindingContext;
            var user = vm.Database.GetUser();
            if (user.Role.Equals(RoleManager.StudentRole))
                return;
        }
    }
}
