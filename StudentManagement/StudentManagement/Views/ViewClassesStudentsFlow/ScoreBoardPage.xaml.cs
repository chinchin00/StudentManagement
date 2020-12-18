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
    public partial class ScoreBoardPage : ContentPage
    {
        public ScoreBoardPage()
        {
            InitializeComponent();
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {

            var student = (Student)e.Item;
            ListScoreBoard.SelectedItem = null;
            var vm = (ScoreBoardPageViewModel)BindingContext;
            vm.ScoreBoardItemTapped(student);
        }
    }
}