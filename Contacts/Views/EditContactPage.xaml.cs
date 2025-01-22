using Contacts.Models;
using Contact = Contacts.Models.Contact; //adding this due to ambigious naming of "Contact"
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
			entryName.Text = _contact.Name;
			entryEmail.Text = _contact.Email;
			entryPhone.Text = _contact.Phone;
			entryAddress.Text = _contact.Address;
		}
	}
}