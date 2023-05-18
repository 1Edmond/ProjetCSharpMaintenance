using Microsoft.Extensions.DependencyInjection;
using MudBlazor;

namespace ProjetCSharpMaintenance.Services;

public class MaintenanceNotification : IMaintenanceNotification
{
    IServiceProvider ServiceProvider { get; set; }

    public MaintenanceNotification(IServiceProvider serviceProvider)
    {
        ServiceProvider = serviceProvider;
    }

    public Task ShowErrorNotification(string message, ISnackbar snackbar)
    {
        snackbar.Configuration.PositionClass = Defaults.Classes.Position.TopEnd;
        snackbar.Add(message, Severity.Error);
        return Task.CompletedTask;
    }

    public Task ShowInfoNotification(string message, ISnackbar snackbar)
    {
        snackbar.Configuration.PositionClass = Defaults.Classes.Position.TopEnd;
        snackbar.Add(message, Severity.Info);
        return Task.CompletedTask;
    }

    public Task ShowSimpleNotification(string message, ISnackbar snackbar)
    {
        snackbar.Configuration.PositionClass = Defaults.Classes.Position.TopEnd;
        snackbar.Add(message, Severity.Normal);
        return Task.CompletedTask;
    }

    public Task ShowSccessNotification(string message, ISnackbar snackbar)
    {
        snackbar.Configuration.PositionClass = Defaults.Classes.Position.TopEnd;
        snackbar.Add(message, Severity.Success);
        return Task.CompletedTask;
    }
    
    public Task ShowWarningNotification(string message, ISnackbar snackbar)
    {
        snackbar.Configuration.PositionClass = Defaults.Classes.Position.TopEnd;
        snackbar.Add(message, Severity.Warning);
        return Task.CompletedTask;
    }
}
