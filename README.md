# Vendor and Order Tracker

#### By: **Brishna Bakshev**

## Technologies Used

* C#
* Razor HTML
* .Net 6
* MSTest

## Description

_This application will prompt the user to create a tracker for the vendors they're partnered with to sell new orders. The application will allow the user to add a new vendor by clicking the "Add a new Vendor" link, then it will take the user to a form where the user can input the details for the vendor as well as order details._


![mainpage](https://user-images.githubusercontent.com/121061679/222862677-fb9fd82d-641b-418e-8d6d-dc55083ce2d6.png)

## Setup/Installation Requirements

#### You will need:
* A code editor, such as [VS Code](https://code.visualstudio.com/)
* [Git](https://github.com/) installed

#### Open Terminal (not including the dollar symbol):
```sh
  $ cd Desktop
  $ git clone https://github.com/bbakshev/VendorOrderTracker.Solution.git
  $ cd VendorOrderTracker.Solution
```

#### Install .Net 6 SDK:
* [OS X and Windows Instructions](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net)

#### Confirm all business logic tests pass with MSTest by running commands (not including the dollar symbol):

```sh
$ dotnet restore ./VendorOrderTracker.Tests
$ dotnet test ./VendorOrderTracker.Tests
```

#### To run the program in the terminal use the following command (not including the dollar symbol):

```sh
$ dotnet watch run ./VendorOrderTracker
```

## Known Bugs

* None

## License

[MIT](https://github.com/git/git-scm.com/blob/main/MIT-LICENSE.txt)

Copyright (c) 2023 Brishna Bakshev
