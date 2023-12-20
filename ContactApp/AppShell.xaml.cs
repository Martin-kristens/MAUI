using ContactApp.Pages;

namespace ContactApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Registrerar vägarna som programmet ska ta när man klickar på något på sidan
            Routing.RegisterRoute(nameof(ContactDetailPage), typeof(ContactDetailPage));
            Routing.RegisterRoute(nameof(AddContactPage), typeof(AddContactPage));
            Routing.RegisterRoute(nameof(DeleteContactPage), typeof(DeleteContactPage));
            Routing.RegisterRoute(nameof(UpdateContactPage), typeof(UpdateContactPage));
            Routing.RegisterRoute(nameof(ViewAllContactsPage), typeof(ViewAllContactsPage));

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        }
    }
}
