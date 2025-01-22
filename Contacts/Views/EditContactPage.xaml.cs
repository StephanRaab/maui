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

    private void cancelClicked(object sender, EventArgs e)
    {
        // ".." navigate back to parent
        Shell.Current.GoToAsync("..");
    }

    private void UpdateContactClicked(object sender, EventArgs e)
    {
		// this is so ugly...can't wait to add in data binding
		_contact.Name = entryName.Text;
		_contact.Phone = entryPhone.Text;
		_contact.Email = entryEmail.Text;
		_contact.Address = entryAddress.Text;

		ContactRepository.UpdateContact(_contact.ContactId, _contact);

        // ".." navigate back to parent
        Shell.Current.GoToAsync("..");
    }

	public string ContactId
	{
		set {
			_contact = ContactRepository.GetContactById(int.Parse(value));
			if (_contact != null)
			{
				entryName.Text = _contact.Name;
				entryEmail.Text = _contact.Email;
				entryPhone.Text = _contact.Phone;
				entryAddress.Text = _contact.Address;
			}
		}
	}
}