using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using StudentManagement.Helpers;
using StudentManagement.ViewModels.ViewClassesStudentsFlow;
using System;
using System.Threading.Tasks;

namespace StudentManagement.Views.Popups
{
    public partial class ConfirmPasswordPopup : PopupPage
    {
        private string _username;
        private bool _isCorrectPassword;
        private bool _isFinishConfirm;
        private bool _isDisappeared;

        public ConfirmPasswordPopup()
        {
            InitializeComponent();
            EntryPasswordConfirm.Text = "";
        }

        #region Instance

        private static ConfirmPasswordPopup _instance;

        public static ConfirmPasswordPopup Instance => _instance ?? (_instance = new ConfirmPasswordPopup());

        public void Show(string username)
        {
            _isCorrectPassword = false;
            _isFinishConfirm = false;
            _isDisappeared = false;
            _username = username;
            LabelWrongPasswordConfirm.IsVisible = false;
            App.Current.MainPage.Navigation.PushPopupAsync(this);
        }
        #endregion

        #region ConfirmPassword

        private async void ButtonConfirm_Clicked(object sender, EventArgs e)
        {
            _isCorrectPassword = UserHelper.Instance.ConfirmPassword(_username, EntryPasswordConfirm.Text);
            LabelWrongPasswordConfirm.IsVisible = !_isCorrectPassword;
            if (_isCorrectPassword)
            {
                await Task.Delay(400);
                _isDisappeared = false;
                _isFinishConfirm = true;
                ReturnResult();

            }
        }

        #endregion

        #region Cancel

        private void ButtonCancel_Clicked(object sender, EventArgs e)
        {
            _isCorrectPassword = false;
            _isDisappeared = false;
            _isFinishConfirm = true;
            ReturnResult();
        }

        #endregion

        protected override void OnDisappearing()
        {
            if (!_isFinishConfirm)
            {
                _isCorrectPassword = false;
                _isDisappeared = true;
                _isFinishConfirm = true;
                ReturnResult();
            }
        }

        private void ReturnResult()
        {
            if (!_isDisappeared) Navigation.PopPopupAsync();
            StudentDetailPageViewModel.Instance.OnReceiveConfirmPasswordResult(_isCorrectPassword);
        }
    }
}
