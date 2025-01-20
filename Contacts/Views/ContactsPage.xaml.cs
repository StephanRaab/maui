using Contact = Contacts.Models.Contact; //adding this due to otherwise ambigious naming of "Contact"
using Contacts.Models;

namespace Contacts.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

        List<Contact> contacts = ContactRepository.GetAllContacts();

        contactsList.ItemsSource = contacts;        
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