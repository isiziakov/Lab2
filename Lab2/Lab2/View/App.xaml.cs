using Lab2.Model;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab2
{
    public partial class App : Application
    {
        public const string DBFILENAME = "xamarintestdb.db";
        public App()
        {
            InitializeComponent();

            string dbPath = DependencyService.Get<IPath>().GetDatabasePath(DBFILENAME);
            using (var db = new Context(dbPath))
            {
                db.Database.EnsureCreated();
            }

            MainPage = new MainPage();
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
