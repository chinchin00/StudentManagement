using StudentManagement.Helpers;
using StudentManagement.ViewModels.ViewClassesStudentsFlow;
using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentManagement.Views.ViewClassesStudentsFlow
{
    public partial class StudentDetailPage : ContentPage
    {
        public StudentDetailPage()
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
                    var vm = (StudentDetailPageViewModel)BindingContext;
                    var user = vm.Database.GetUser();
                    if (user.Role.Equals(RoleManager.PrincipalRole) || user.Role.Equals(RoleManager.AdminRole))
                    {
                        this.ToolbarItems.Add(new ToolbarItem
                        {
                            Text = "Remove",
                            Icon = "ic_remove_student.png",
                            Command = vm.RemoveStudentCommand
                        });
                        this.ToolbarItems.Add(new ToolbarItem
                        {
                            Text = "Edit",
                            Icon = "ic_ic_edit_white.png",
                            Command = vm.EditStudentCommand
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
