using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Models;
using StudentManagement.ViewModels.ViewClassesStudentsFlow;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentManagement.Views.ViewClassesStudentsFlow
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClassesPage : ContentPage
    {
        public ClassesPage()
        {
            InitializeComponent();
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var _class = (Class)e.Item;
            ListViewClasses.SelectedItem = null;
            var vm = (ClassesPageViewModel)BindingContext;
            vm.ClassesItemTapped(_class);
        }
    }
}