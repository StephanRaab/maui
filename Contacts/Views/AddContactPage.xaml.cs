namespace Contacts.Views;

public partial class AddContactPage : ContentPage
{
	public AddContactPage()
	{
		InitializeComponent();
	}

	private void AddContactClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("..");
	}
}