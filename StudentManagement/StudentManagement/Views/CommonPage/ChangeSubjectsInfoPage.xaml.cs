using StudentManagement.Models;
using StudentManagement.ViewModels.CommonPage;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentManagement.Views.CommonPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangeSubjectsInfoPage : ContentPage
    {
        private ChangeSubjectsInfoPageViewModel _vm;

        public ChangeSubjectsInfoPage()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            if (BindingContext != null)
                _vm = (ChangeSubjectsInfoPageViewModel)BindingContext;
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListSubjects.SelectedItem = null;
        }

        private void EditIcon_Tapped(object sender, EventArgs e)
        {
            var icon = (Image)sender;
            var subject = (Subject)icon.BindingContext;
            _vm.EditExecute(subject);
        }

        private void RemoveIcon_Tapped(object sender, EventArgs e)
        {
            var icon = (Image)sender;
            var subject = (Subject)icon.BindingContext;
            _vm.RemoveExecute(subject);
        }
    }
}
