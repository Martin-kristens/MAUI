using Shared.Models;

namespace Shared.Services;

public class ContactService
{
    private List<MyAppContact> _contacts = [];

    public bool AddContactToList(MyAppContact contact)
    {
        if (!string.IsNullOrWhiteSpace(contact.Email))
        {
            _contacts.Add(contact);
            return true;
        }
        return false;
    }

    public IEnumerable<MyAppContact> GetContacts()
    {
        return _contacts;
    }

    public bool RemoveContactToList(MyAppContact contact)
    {
        if (!string.IsNullOrWhiteSpace(contact.Email))
        {
            var existingContact = _contacts.FirstOrDefault(x => x.Email == contact.Email);
            if (existingContact != null)
            {
                _contacts.Remove(existingContact);
                return true;
            }
            
        }
        return false;
    }
}
