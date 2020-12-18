using Rg.Plugins.Popup.Extensions;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.ViewModels.CommonPage;
using System;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace StudentManagement.Views.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditClassPopup
    {
        private ISQLiteHelper _db;
        private Class _class;

        public EditClassPopup()
        {
            InitializeComponent();
            EntrySubjectName.Text = "";
        }

        #region Instance

        private static EditClassPopup _instance;

        public static EditClassPopup Instance => _instance ?? (_instance = new EditClassPopup());

        public void Show(ISQLiteHelper database, Class cls)
        {
            _db = database;
            _class = cls;
            EntrySubjectName.Text = cls.Name;
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
                LabelWrong.Text = "Tên lớp học không được bỏ trống";
            }
            else
            {
                var cls = _db.Get<Class>(c => c.Name.ToLower().Equals(EntrySubjectName.Text.Trim().ToLower()));
                if (cls != null)
                {
                    LabelWrong.IsVisible = true;
                    LabelWrong.Text = "Tên lớp học bị trùng";
                }
                else
                {
                    _class.Name = EntrySubjectName.Text.Trim();
                    _db.Update(_class);
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
            ChangeClassesInfoPageViewModel.Instance.EditSuccessfullyExecute();
        }
    }
}
