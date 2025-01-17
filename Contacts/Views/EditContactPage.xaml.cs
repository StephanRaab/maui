namespace Contacts.Views;

public partial class EditContactPage : ContentPage
{
	public EditContactPage()
	{
		InitializeComponent();
	}

    private void UpdateContactClicked(object sender, EventArgs e)
    {
		// ".." navigate back to parent
		Shell.Current.GoToAsync("..");
    }
}