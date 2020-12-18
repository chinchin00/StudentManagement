using StudentManagement.Helpers;
using StudentManagement.Models;
using StudentManagement.ViewModels.CommonPage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
            //vm.StudentItemTapped(student);
        }
    }
}
