using StudentManagement.Models;
using StudentManagement.ViewModels.ReportsFlow;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentManagement.Views.ReportsFlow
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentScoreTab : TabbedPage
    {
        public StudentScoreTab()
        {
            InitializeComponent();
        }

        private void ListViewSemester1_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var subject = (Subject)e.Item;
            ListPersonalScore1.SelectedItem = null;
            var vm = (StudentScoreTabViewModel)BindingContext;
            vm.ScoreItemTapped(subject);
        }

        private void ListViewSemester2_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var subject = (Subject)e.Item;
            ListPersonalScore2.SelectedItem = null;
            var vm = (StudentScoreTabViewModel)BindingContext;
            vm.ScoreItemTapped(subject);
        }

        private void ListViewTotal_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var subject = (Subject)e.Item;
            ListPersonalScoreCN.SelectedItem = null;
            var vm = (StudentScoreTabViewModel)BindingContext;
            vm.ScoreItemTapped(subject);
        }
    }
}
