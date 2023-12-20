using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactApp.Pages;
using System.Collections.ObjectModel;


namespace ContactApp.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [RelayCommand]
    async Task Tap(string s)
    {
        //await Shell.Current.GoToAsync(nameof(ContactDetailPage));

        switch (s)
        {
            case "Add Contact":
                await Shell.Current.GoToAsync(nameof(AddContactPage));
                break;

            case "View Contact":
                await Shell.Current.GoToAsync(nameof(ViewAllContactsPage));
                break;

            case "View Details of Contact":
                await Shell.Current.GoToAsync(nameof(ContactDetailPage));
                break;

            case "Update Contact":
                await Shell.Current.GoToAsync(nameof(UpdateContactPage));
                break;

            case "Delete Contact":
                await Shell.Current.GoToAsync(nameof(DeleteContactPage));
                break;
        }
    }
    
}
