using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using StudentManagement.Interfaces;
using StudentManagement.Interfaces.Navigator;
using StudentManagement.Services.LocalDatabase;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentManagement.ViewModels.Base
{
    public class ViewModelBase : BindableBase, INavigationAware
    {
        public INavigationService NavigationService { get; private set; }
        public IPageDialogService Dialog { get; private set; }
        public ISQLiteHelper Database { get; private set; }
        public INavService Navigator { get; internal set; }

        public ICommand BCommand { get; set; }

        private async void BExecute()
        {
            await NavigationService.NavigateAsync("NavigationPage/B");
        }

        public ICommand ACommand { get; set; }

        private async void AExecute()
        {
            await NavigationService.NavigateAsync("NavigationPage/A");
        }

        public ICommand CCommand { get; set; }

        private async void CExecute()
        {
            await NavigationService.NavigateAsync("C");
            //await Navigator.PushModal("C");
        }

        public ICommand BackCommand { get; set; }

        private async void BackCommandExecute()
        {
            //await Navigator.Home();
            await Application.Current.MainPage.Navigation.PopToRootAsync();
        }

        public ViewModelBase(
            INavigationService navigationService = null,
            IPageDialogService dialogService = null,
            ISQLiteHelper sqLiteHelper = null)
        {
            if (navigationService != null) NavigationService = navigationService;
            if (dialogService != null) Dialog = dialogService;
            if (sqLiteHelper != null) Database = sqLiteHelper;

            BackCommand = new DelegateCommand(BackCommandExecute);

            BCommand = new DelegateCommand(BExecute);

            ACommand = new DelegateCommand(AExecute);

            CCommand = new DelegateCommand(CExecute);
        }


        #region Navigate

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters != null)
            {
                var navMode = parameters.GetNavigationMode();
                switch (navMode)
                {
                    case NavigationMode.New: OnNavigatedNewTo(parameters); break;
                    case NavigationMode.Back: OnNavigatedBackTo(parameters); break;
                }
            }

        }

        public virtual void OnNavigatedNewTo(INavigationParameters parameters)
        {
            
        }

        public virtual void OnNavigatedBackTo(INavigationParameters parameters)
        {

        }

        #endregion

        #region General Properties

        private string _pageTitle;
        public string PageTitle
        {
            get => _pageTitle;
            set => SetProperty(ref _pageTitle, value);
        }

        #endregion
    }
}
