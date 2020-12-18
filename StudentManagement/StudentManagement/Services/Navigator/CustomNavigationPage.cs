using StudentManagement.Interfaces.Navigator;
using Xamarin.Forms;

namespace StudentManagement.Services.Navigator
{
    public class CustomNavigationPage : NavigationPage
    {
        //This ctor is required. This is so  you can call it like normal
        //ex: new CustomNavigationPage(new MyHomePage());
        public CustomNavigationPage(Page content)
            : base(content)
        {
            Init();
        }

        private void Init()
        {
            //this.Pushed += (object sender, NavigationEventArgs e) =>
            //{
            //    //here you can handle when pushing a new screen. 
            //    //arg e.Page has the new page to display

            //};

            this.Popped += (object sender, NavigationEventArgs e) =>
            {
                var navpage = e.Page as IPageLifetime;
                if (navpage != null)
                {
                    // Unregister vm of page, message listener etc
                    navpage.CleanupPage();
                }
            };

        }
    }
}
