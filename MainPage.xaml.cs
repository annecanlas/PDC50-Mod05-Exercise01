using Module07DataAccess.Services;
using MySql.Data.MySqlClient;

namespace Module07DataAccess

{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        private readonly DatabaseConnectionService _dbConnectionService;

        public MainPage()
        {
            InitializeComponent();

            //Initialize Database Connection
            _dbConnectionService = new DatabaseConnectionService();

        }
        private async void OnViewEmployeePageClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//EmployeePage");
        }
    }

}
