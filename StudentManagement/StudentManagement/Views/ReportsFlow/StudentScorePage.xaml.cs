using StudentManagement.Helpers;
using StudentManagement.ViewModels.ReportsFlow;
using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentManagement.Views.ReportsFlow
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentScorePage : ContentPage
    {
        public StudentScorePage()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            if (BindingContext != null)
            {
                try
                {
                    var vm = (StudentScorePageViewModel)BindingContext;
                    var user = vm.Database.GetUser();
                    if (user.Role.Equals(RoleManager.PrincipalRole) || user.Role.Equals(RoleManager.AdminRole))
                    {
                        this.ToolbarItems.Add(new ToolbarItem
                        {
                            Text = "Edit",
                            Icon = "ic_ic_edit_white.png",
                            Command = vm.EditCommand
                        });
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }
            }
        }
    }
}
