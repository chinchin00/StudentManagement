using Prism.Navigation;
using Prism.Services;
using StudentManagement.Interfaces;
using StudentManagement.ViewModels.Base;

namespace StudentManagement.ViewModels.ReportsFlow
{
    public class ReportHomePageViewModel : ViewModelBase
    {
        public ReportHomePageViewModel(INavigationService navigationService, IPageDialogService dialogService,
            ISQLiteHelper sqLiteHelper)
            : base(navigationService, dialogService, sqLiteHelper)
        {
            PageTitle = "Báo cáo tổng kết";
        }
    }
}
