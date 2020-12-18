using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.ViewModels.CommonPage;
using System;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace StudentManagement.Views.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditSubjectPopup : PopupPage
    {
        private ISQLiteHelper _db;
        private Subject _subject;

        public EditSubjectPopup()
        {
            InitializeComponent();
            EntrySubjectName.Text = "";
        }

        #region Instance

        private static EditSubjectPopup _instance;

        public static EditSubjectPopup Instance => _instance ?? (_instance = new EditSubjectPopup());

        public void Show(ISQLiteHelper database, Subject subject)
        {
            _db = database;
            _subject = subject;
            EntrySubjectName.Text = subject.Name;
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
                var subject = _db.Get<Subject>(s => s.Name.ToLower().Equals(EntrySubjectName.Text.Trim().ToLower()));
                if (subject != null)
                {
                    LabelWrong.IsVisible = true;
                    LabelWrong.Text = "Tên môn học bị trùng";
                }
                else
                {
                    _subject.Name = EntrySubjectName.Text.Trim();
                    _db.Update(_subject);
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
            ChangeSubjectsInfoPageViewModel.Instance.EditSuccessfullyExecute();
        }
    }
}
