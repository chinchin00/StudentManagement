using StudentManagement.ViewModels.AddStudentsFlow;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentManagement.Views.AddStudentsFlow
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();

            SetPickerValue();
        }

        private void SetPickerValue()
        {
            var vm = BindingContext as SearchPageViewModel;

            if (vm != null)
            {
                PickerClass.ItemsSource = vm.ListClasses;
                PickerClass.SelectedIndex = 0;
            }

            PickerGioiTinh.SelectedIndex = 0;

            PickerNamHoc.ItemsSource = new List<string>()
            {
                "Tất cả",
                "2017 - 2018",
                "2016 - 2017",
                "2015 - 2016",
                "2014 - 2015"
            };

            PickerNamHoc.SelectedIndex = 0;

            PickerHocKi.ItemsSource = new List<string>()
            {
                "Tất cả",
                "Học kỳ 1",
                "Học kỳ 2",
                "Cả năm"
            };

            PickerHocKi.SelectedIndex = 0;
        }
    }
}
