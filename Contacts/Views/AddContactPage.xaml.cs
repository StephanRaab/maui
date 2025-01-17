namespace Contacts.Views;

public partial class AddContactPage : ContentPage
{
	public AddContactPage()
	{
		InitializeComponent();
	}

	private void AddContactClicked(object sender, EventArgs e)
	{
		// this is the other way to go back
		Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
	}
}