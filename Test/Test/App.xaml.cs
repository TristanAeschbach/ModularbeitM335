using Xamarin.Forms;

namespace ModularbeitM335
{
    public partial class App : Application
    {
        private static Database database;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static Database Database
        {
            get
            {
                if (database == null) database = new Database();
                return database;
            }
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