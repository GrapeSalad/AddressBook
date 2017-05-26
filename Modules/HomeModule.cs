using Nancy;
using AddressBook.Objects;
using System;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["contacts_home.cshtml", allContacts];
      };
      
      Get["/contact"] = _ => {
        return View["contact_form.cshtml"];
      };

      Post["/contact/new"] = _ => {
        int number = 1;
        bool isZipCodeNumber = int.TryParse(Request.Form["zipCode"], out number);
        string fName = (Request.Form["fName"]);
        if ((isZipCodeNumber) && (fName != "")){
          Contact newContact = new Contact(Request.Form["fName"], Request.Form["lName"], Request.Form["phoneNumber"], Request.Form["streetAddress"], Request.Form["city"], Request.Form["state"], Request.Form["zipCode"], Request.Form["emailAddress"]);
          return View["new_contact.cshtml", newContact];
        }
        else {
          return View["invalid_entry.cshtml"];
        }
      };

      Post["/contact/clear"] = _ => {
        Contact.Clear();
        return View["contacts_cleared.cshtml"];
      };

      Get["/contact/{id}"] = parameters => {
        Contact contact = Contact.Find(parameters.id);
        return View["contact_details.cshtml", contact];
      };
      Post["/contact/{id}"] = parameters => {
        Contact contact = Contact.Find(parameters.id);
        contact.Remove();
        List<Contact> allContacts = Contact.GetAll();
        return View["contacts_home.cshtml", allContacts];
      };
    }
  }
}
