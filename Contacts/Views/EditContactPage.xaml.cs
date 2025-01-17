namespace Contacts.Views;

public partial class EditContactPage : ContentPage
{
	public EditContactPage()
	{
		InitializeComponent();
	}

    private void UpdateContactClicked(object sender, EventArgs e)
    {
		// ".." pops off to previous route
		Shell.Current.GoToAsync("..");
    }
}