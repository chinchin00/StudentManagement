using ImTools;
using Rg.Plugins.Popup.Extensions;
using StudentManagement.Helpers;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.ViewModels.CommonPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentManagement.Views.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddUserPopup
    {
        private ISQLiteHelper _db;

        public AddUserPopup()
        {
            InitializeComponent();
        }

        #region InitInfo

        private void InitInfo()
        {
            EntryName.Text = "";
            EntryUsername.Text = "";
            EntryPassword.Text = "";

            var roles = new List<string>()
            {
                RoleManager.AdminRole,
                RoleManager.PrincipalRole,
                RoleManager.TeacherRole
            };
            pickerRole.ItemsSource = roles;
            pickerRole.SelectedItem = roles[1];

        }

        #endregion

        #region Instance

        private static AddUserPopup _instance;

        public static AddUserPopup Instance => _instance ?? (_instance = new AddUserPopup());

        public void Show(ISQLiteHelper database)
        {
            _db = database;

            InitInfo();

            LabelWrong.IsVisible = false;
            App.Current.MainPage.Navigation.PushPopupAsync(this);
        }
        #endregion

        #region CheckEmptyBlank

        private bool CheckEmptyBlank()
        {
            if (string.IsNullOrEmpty(EntryName.Text))
            {
                LabelWrong.IsVisible = true;
                LabelWrong.Text = "Tên không được bỏ trống";
                return true;
            }
            if (string.IsNullOrEmpty(EntryUsername.Text))
            {
                LabelWrong.IsVisible = true;
                LabelWrong.Text = "Username không được bỏ trống";
                return true;
            }
            if (string.IsNullOrEmpty(EntryPassword.Text))
            {
                LabelWrong.IsVisible = true;
                LabelWrong.Text = "Password không được bỏ trống";
                return true;
            }

            return false;
        }

        #endregion

        #region ConfirmPassword

        private async void ButtonConfirm_Clicked(object sender, EventArgs e)
        {
            if (CheckEmptyBlank()) return;

            var listaccounts = _db.GetList<Account>(a => a.Id >= 0);

            var acc = listaccounts.FirstOrDefault(c =>
                c.UserName.ToLower().Equals(EntryUsername.Text.Trim().ToLower()) &&
                c.Password.Equals(EntryPassword.Text));

            if (acc != null)
            {
                LabelWrong.IsVisible = true;
                LabelWrong.Text = "Username và password đã có sẵn";
            }
            else
            {
                // Get max id
                int idMax = listaccounts.Count();

                Class iClass = new Class();

                if (pickerRole.SelectedItem.Equals(RoleManager.TeacherRole))
                {
                    var classes = _db.GetList<Class>(c => c.Id > 0);
                    iClass = classes.FindFirst(c =>
                        c.Name == pickerClass.SelectedItem.ToString() &&
                        c.SchoolYear == pickerSchoolYear.SelectedItem.ToString());
                }

                // Insert new Account
                var newAccount = new Account()
                {
                    Id = idMax,
                    Name = EntryName.Text,
                    Role = pickerRole.SelectedItem.ToString(),
                    Avatar = "ic_account_circle.png",
                    ClassId = iClass.Id,
                    UserName = EntryUsername.Text,
                    Password = EntryPassword.Text,
                    ClassName = iClass.Name,
                    SchoolYear = iClass.SchoolYear
                };
                _db.Insert(newAccount);
                LabelWrong.IsVisible = false;
                await Task.Delay(400);
                ReturnResult();
            }
        }

        #endregion

        #region Cancel

        private void ButtonCancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PopPopupAsync();
        }

        #endregion

        private void ReturnResult()
        {
            Navigation.PopPopupAsync();
            AdminRoleInfoPageViewModel.Instance.AddSuccessfullyExecute();
        }

        private void PickerRole_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (Picker)sender;

            if (item.SelectedItem == null)
                return;

            lblClass.IsVisible = item.SelectedItem.Equals(RoleManager.TeacherRole);
            lblSchoolYear.IsVisible = item.SelectedItem.Equals(RoleManager.TeacherRole);
            pickerClass.IsVisible = item.SelectedItem.Equals(RoleManager.TeacherRole);
            pickerSchoolYear.IsVisible = item.SelectedItem.Equals(RoleManager.TeacherRole);

            if (item.SelectedItem.Equals(RoleManager.TeacherRole))
            {
                var classes = _db.GetList<Class>(c => c.Id >= 0);
                var listClasses = new List<string>();
                foreach (var c in classes)
                {
                    listClasses.Add(c.Name);
                }
                pickerClass.ItemsSource = listClasses;
                pickerClass.SelectedItem = listClasses[0];

                pickerSchoolYear.SelectedItem = "2017 - 2018";
            }
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(EntryName.Text) && LabelWrong.IsVisible)
                LabelWrong.IsVisible = false;
            if (!string.IsNullOrEmpty(EntryUsername.Text) && LabelWrong.IsVisible)
                LabelWrong.IsVisible = false;
            if (!string.IsNullOrEmpty(EntryPassword.Text) && LabelWrong.IsVisible)
                LabelWrong.IsVisible = false;
        }
    }
}
