# AddressBook App

#### An Epicodus project using Object Oriented C#, 5/29/2017

#### **By David Wilson**

## Description

This web application will allow a user to create an Address Book that will save contact information for their friends, family, and acquaintances.

#### RESTful Routing
| behavior | input | output |
|---|---|---|
| Home page | "localhost:5004/" | contacts_home.cshtml |
| Contact entry form | "localhost:5004/contact" | contact_form.cshtml |
| Details of new entered contact page | "localhost:5004/contact/new" | new_contact.cshtml |
| All contacts cleared page | "localhost:5004/contact/clear" | contacts_cleared.cshtml |
| See selected contact details page | "localhost:5004/contact/{id}" | contact_details.cshtml |

#### User Inputs/Outputs
| behavior | input | output |
|---|---|---|
| First and last names are concatenated | Drewpy and Pie are entered | "Drewpy Pie" |
| Zip Code must be a number | h4lso | "Invalid Entry, Please Try Again"|
| Delete single entry | click on link in list of contact names, then click delete this contact | list of contact names is shown missing the deleted contact |
| Delete all contacts | click delete all contacts button | native home-page will be displayed due to the list being empty |

## GH-Pages
Link to the Gh-pages site:
grapesalad.github.io/AddressBook

## Setup/Installation Requirements

Go to the Github repository page at https://github.com/GrapeSalad/AddressBook
Click the "download or clone" button and copy the link.
In your Microsoft Windows installation location open PowerShell.
In PowerShell navigate to the directory in which you want to store the app files.
Clone using "git clone " and the copied link.
To run the project locally you will need Mono Compiler (http://www.mono-project.com/download/#download-win), Visual Studio 2015 (https://go.microsoft.com/fwlink/?LinkId=532606), and ASP.Net 5 (https://go.microsoft.com/fwlink/?LinkId=627627).
Once those are all installed, restart PowerShell and enter "dnvm upgrade" into the prompt.
Now you can navigate to the directory in which you downloaded the AddressBook App, and then into the AddressBook home file.
To start the web server necessary for proper app functionality you will need to type in "dnx kestrel".
Open a web browser, and type "localhost:5004".
To view the code you can open the files using your editor of choice.
If you have the editor path set in your system properties you will be able to open them through PowerShell.

## Support and Contact Details

If you have any issues, questions, ideas, concerns, or contribution ideas please contact any of the contributors via Github.

## Technologies used

* C-Sharp
* CSS
* Javascript
* HTML
* Boostrap
* JSON
* DVNM
* PowerShell
* Google Chrome

### License

This software is licensed under the MIT license.

Copyright (c) 2017 **David Wilson**
