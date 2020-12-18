using ImTools;
using Rg.Plugins.Popup.Extensions;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.ViewModels.CommonPage;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace StudentManagement.Views.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddClassPopup
    {
        private ISQLiteHelper _db;

        public AddClassPopup()
        {
            InitializeComponent();
            EntryClassName.Text = "";
        }

        #region Instance

        private static AddClassPopup _instance;

        public static AddClassPopup Instance => _instance ?? (_instance = new AddClassPopup());

        public void Show(ISQLiteHelper database)
        {
            _db = database;
            LabelWrong.IsVisible = false;
            App.Current.MainPage.Navigation.PushPopupAsync(this);
        }
        #endregion

        #region ConfirmPassword

        private async void ButtonConfirm_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EntryClassName.Text))
            {
                LabelWrong.IsVisible = true;
                LabelWrong.Text = "Tên lớp học không được bỏ trống";
            }
            else
            {
                var listclasses = _db.GetList<Class>(a => a.Id >= 0);
                var cls = listclasses.FindFirst(c =>
                    c.Name.ToLower().Equals(EntryClassName.Text.Trim().ToLower()));

                if (cls != null)
                {
                    LabelWrong.IsVisible = true;
                    LabelWrong.Text = "Tên lớp học bị trùng";
                }
                else
                {
                    // Get max id
                    var classes = _db.GetList<Class>(c => c.Id > 0);
                    int idMax = classes.Select(c => c.Id).Concat(new[] { 0 }).Max();
                    // Insert new subject
                    var newClass = new Class() { Id = ++idMax, Name = EntryClassName.Text.Trim() };
                    _db.Insert(newClass);
                    LabelWrong.IsVisible = false;
                    await Task.Delay(400);
                    ReturnResult();
                }
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
            ChangeClassesInfoPageViewModel.Instance.AddSuccessfullyExecute();
        }
    }
}
