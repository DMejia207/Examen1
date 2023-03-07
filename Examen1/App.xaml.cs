using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace Examen1
{
    public partial class App : Application
    {
        static Controllers.GuardControllers dblog;

        public static Controllers.GuardControllers DBlog
        {
            get
            {
                if (dblog == null)
                {
                    var dbpath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    var dbname = "Login.db3";
                    dblog = new Controllers.GuardControllers(Path.Combine(dbpath, dbname));

                }
                return dblog;
            }

        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.PagePrincipal());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
