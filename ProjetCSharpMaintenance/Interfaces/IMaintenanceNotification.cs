using MudBlazor;

namespace ProjetCSharpMaintenance.Interfaces;

public interface IMaintenanceNotification
{
    Task ShowErrorNotification(string message, ISnackbar snackbar);
    Task ShowInfoNotification(string message, ISnackbar snackbar);
    Task ShowSimpleNotification(string message, ISnackbar snackbar);
    Task ShowSccessNotification(string message, ISnackbar snackbar);
    Task ShowWarningNotification(string message, ISnackbar snackbar);


}
