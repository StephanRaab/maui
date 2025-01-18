using System.Security.Cryptography.X509Certificates;

namespace Contacts.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

        List<Contact> contacts = new List<Contact>() {
            new Contact{Name="John Doe", Email="John.Doe@email.com" },
            new Contact{Name="Jane Doe", Email="Jane.Doe@email.com" },
            new Contact{Name="J D", Email="J.D@email.com" },
            new Contact{Name="Hank Green", Email="HG@email.com" },
        };

        contactsList.ItemsSource = contacts;        
    }	

    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    private void contactsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(EditContactPage));      
    }

    private void contactsList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        // Remove the ItemSelected event handler temporarily
        contactsList.ItemSelected -= contactsList_ItemSelected;

        // Set the SelectedItem to null
        contactsList.SelectedItem = null;

        // Reattach the ItemSelected event handler
        contactsList.ItemSelected += contactsList_ItemSelected;
    }
}