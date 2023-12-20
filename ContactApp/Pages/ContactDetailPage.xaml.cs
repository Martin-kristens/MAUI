using ContactApp.ViewModels;

namespace ContactApp;

public partial class ContactDetailPage : ContentPage
{
	public ContactDetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    private void OnBackClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}