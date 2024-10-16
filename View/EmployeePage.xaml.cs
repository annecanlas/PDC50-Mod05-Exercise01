using Module07DataAccess.Services;
using Module07DataAccess.ViewModel;

namespace Module07DataAccess.View;

public partial class EmployeePage : ContentPage
{
    public EmployeePage()
    {
        InitializeComponent();
        var employeeViewModel = new EmployeeViewModel();
        BindingContext = employeeViewModel;
    }
}