using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Models;
using StudentManagement.ViewModels.ViewClassesStudentsFlow;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentManagement.Views.ViewClassesStudentsFlow
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonalScoreListPage : ContentPage
    {
        public PersonalScoreListPage()
        {
            InitializeComponent();
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var subject = (Subject)e.Item;
            ListPersonalScore.SelectedItem = null;
            var vm = (PersonalScoreListPageViewModel)BindingContext;
            vm.ScoreItemTapped(subject);
        }
    }
}