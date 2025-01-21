using Contacts.Models;
using Contact = Contacts.Models.Contact; //adding this due to otherwise ambigious naming of "Contact"
namespace Contacts.Views;

[QueryProperty(nameof(ContactId), "Id")]
public partial class EditContactPage : ContentPage
{
    private Contact _contact;

	public EditContactPage()
	{
		InitializeComponent();
	}

    private void UpdateContactClicked(object sender, EventArgs e)
    {
		// ".." navigate back to parent
		Shell.Current.GoToAsync("..");
    }

	public string ContactId
	{
		set {
			_contact = ContactRepository.GetContactById(int.Parse(value));
			//lblName.Text = _contact.Name;
		}
	}
}