using System;
using System.Collections.Generic;

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
    private int _zipCode;
    private string _emailAddress;
    private int _id;
//CONSTRUCTING
    public Contact(string fName, string lName, string phoneNumber, string streetAddress, string city, string state, int zipCode, string emailAddress)
    {
      _fName = fName;
      _lName = lName;
      _phoneNumber = phoneNumber;
      _streetAddress = streetAddress;
      _city = city;
      _state = state;
      _zipCode = zipCode;
      _emailAddress = emailAddress;
      _contacts.Add(this);
      _id = _contacts.Count;
    }
//RETURNING
    public string GetName()
    {
      return _fName + " " + _lName;
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
    public int GetZipCode()
    {
      return _zipCode;
    }
    public string GetEmailAddress()
    {
      return _emailAddress;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Contact> GetAll()
    {
      return _contacts;
    }
//REMOVING
    public static void Clear()
    {
      _contacts.Clear();
    }
    public void Remove()
    {
      _contacts.Remove(this);
    }
//FINDING
    public static Contact Find(int searchId)
    {
      return _contacts[searchId-1];
    }
  }
}
