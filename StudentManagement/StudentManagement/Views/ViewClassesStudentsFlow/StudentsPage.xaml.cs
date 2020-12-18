using StudentManagement.Helpers;
using StudentManagement.Models;
using StudentManagement.ViewModels.ViewClassesStudentsFlow;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentManagement.Views.ViewClassesStudentsFlow
{
    public partial class StudentsPage : ContentPage
    {
        public StudentsPage()
        {
            InitializeComponent();
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var student = (Student)e.Item;
            ListViewStudents.SelectedItem = null;
            var vm = (StudentsPageViewModel)BindingContext;
            var user = vm.Database.GetUser();
            if (user.Role.Equals(RoleManager.StudentRole))
                return;
            vm.StudentItemTapped(student);
        }
    }
}
