using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.ViewModels.Base;
using StudentManagement.Views.Popups;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace StudentManagement.ViewModels.CommonPage
{
    public class AdminRoleInfoPageViewModel : ViewModelBase
    {
        public AdminRoleInfoPageViewModel(INavigationService navigationService = null, IPageDialogService dialogService = null, ISQLiteHelper sqLiteHelper = null) :
            base(navigationService, dialogService, sqLiteHelper)
        {
            PageTitle = "Thông tin tài khoản";

            Accounts = new ObservableCollection<Account>(Database.GetList<Account>(a => a.Id > 0)); ;
            AddCommand = new DelegateCommand(AddExecute);

            Instance = this;
        }

        public static AdminRoleInfoPageViewModel Instance { get; set; }

        #region Properties

        private ObservableCollection<Account> _accounts;

        public ObservableCollection<Account> Accounts
        {
            get => _accounts;
            set => SetProperty(ref _accounts, value);
        }

        private ObservableCollection<Account> _listAccounts;

        public ObservableCollection<Account> ListAccounts
        {
            get => _listAccounts;
            set => SetProperty(ref _listAccounts, value);
        }

        #endregion

        #region AddCommand

        public ICommand AddCommand { get; set; }
        public void AddExecute()
        {
            AddUserPopup.Instance.Show(Database);
        }

        public void AddSuccessfullyExecute()
        {
            Accounts = new ObservableCollection<Account>(Database.GetList<Account>(a => a.Id > 0)); ;
        }

        #endregion
    }
}
