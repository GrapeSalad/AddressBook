namespace AddressBook.Objects
{
  public class Contact
  {
    private static List<Contact> _contacts = new List<Contact> {};
    private string _fName;
    private string _lName;
    private string _phoneNumber;
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _emailAddress;
    private int _id;

    public Contact(string fName, string lName, string phoneNumber, string streetAddress, string city, string state, string emailAddress)
    {
      _fName = fName;
      _lName = lName;
      _phoneNumber = phoneNumber;
      _streetAddress = streetAddress;
      _city = city;
      _state = state;
      _emailAddress = emailAddress;
      _contact.Add(this);
      _id = _contact.Count;//To be implemented with deletion of contact
    }

    public string GetName()
    {
      return _fName + _lName;
    }
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public string GetStreetAddress()
    {
      return _streetAddress;
    }
    public string GetCity()
    {
      return _city;
    }
    public string GetState()
    {
      return _state;
    }
    public string GetEmailAddress()
    {
      return _emailAddress;
    }
    public int GetId
    {
      return _id;
    }
    public static List<Contact> GetAll()
    {
      return _contacts;
    }
    public static void Clear()
    {
      _contacts.Clear();
    }
    public static Contact Find(int searchId)
    {
      return _artists[searchId-1];
    }
  }
}
