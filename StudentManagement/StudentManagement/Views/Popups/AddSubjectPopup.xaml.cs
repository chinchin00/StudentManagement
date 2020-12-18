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
    public partial class AddSubjectPopup
    {
        private ISQLiteHelper _db;

        public AddSubjectPopup()
        {
            InitializeComponent();
            EntrySubjectName.Text = "";
        }

        #region Instance

        private static AddSubjectPopup _instance;

        public static AddSubjectPopup Instance => _instance ?? (_instance = new AddSubjectPopup());

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
            if (string.IsNullOrEmpty(EntrySubjectName.Text))
            {
                LabelWrong.IsVisible = true;
                LabelWrong.Text = "Tên môn học không được bỏ trống";
            }
            else
            {
                var listsubjects = _db.GetList<Subject>(s => s.Id >= 0);
                var subject =
                    listsubjects.FindFirst(s => s.Name.ToLower().Equals(EntrySubjectName.Text.Trim().ToLower()));

                if (subject != null)
                {
                    LabelWrong.IsVisible = true;
                    LabelWrong.Text = "Tên môn học bị trùng";
                }
                else
                {
                    // Get max id
                    var subjects = _db.GetList<Subject>(s => s.Id > 0);
                    int idMax = subjects.Select(s => s.Id).Concat(new[] { 0 }).Max();
                    // Insert new subject
                    var newSubject = new Subject { Id = ++idMax, Name = EntrySubjectName.Text.Trim() };
                    _db.Insert(newSubject);
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
            ChangeSubjectsInfoPageViewModel.Instance.AddSuccessfullyExecute();
        }
    }
}
