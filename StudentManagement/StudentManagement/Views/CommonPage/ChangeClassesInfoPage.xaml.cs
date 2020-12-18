using StudentManagement.Models;
using StudentManagement.ViewModels.CommonPage;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentManagement.Views.CommonPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangeClassesInfoPage : ContentPage
    {
        private ChangeClassesInfoPageViewModel _vm;
        public ChangeClassesInfoPage()
        {
            InitializeComponent();
        }
        protected override void OnBindingContextChanged()
        {
            if (BindingContext != null)
                _vm = (ChangeClassesInfoPageViewModel)BindingContext;
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListClasses.SelectedItem = null;
        }

        private void EditIcon_Tapped(object sender, EventArgs e)
        {
            var icon = (Image)sender;
            var _class = (Class)icon.BindingContext;
            _vm.EditExecute(_class);
        }

        private void RemoveIcon_Tapped(object sender, EventArgs e)
        {
            var icon = (Image)sender;
            var _class = (Class)icon.BindingContext;
            _vm.RemoveExecute(_class);
        }
    }
}
