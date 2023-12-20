using Shared.Models;
using System.Collections.ObjectModel;

namespace ContactApp.Pages;

public partial class AddContactPage : ContentPage
{
	private ObservableCollection<Contact> _contactList = new ObservableCollection<Contact>();
	public AddContactPage()
	{
		InitializeComponent();
	}

	private void OnAddContactClicked(object sender, EventArgs e)
	{
		//hämtar värden från .xaml
		string firstname = FirstNameEntry.Text;
		string lastname = LastNameEntry.Text;
		string phonenumber = PhoneEntry.Text;
		string email = EmailEntry.Text;
		string streetaddress = StreetaddressEntry.Text;
		string city = CityEntry.Text;

        //skapa en ny kontakt och lägg denna till listan
        MyAppContact newContact = new MyAppContact
        {
            FirstName = firstname,
			LastName = lastname,
			Phonenumber = phonenumber,
			Email = email,
			StreetAddress = streetaddress,
			City = city

		};	
	}

	private void OnBackClicked(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}