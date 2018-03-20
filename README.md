# MBran Error 404
MBran Error 404 is a package to protect your website from ugly 404 pages through these simple steps:

[1]: https://our.umbraco.org/projects/backoffice-extensions/mbran-error-404/ "Umbraco Package Link"
[2]: https://www.nuget.org/packages/MBran.Error404/ "NuGet Package Link"

## From NuGet:

1. Install package ([https://www.nuget.org/packages/MBran.Error404/][2])
2. Browse to your website http://yourdomain.com/pagedoestnotexist

## From Umbraco Package  Manager:

1. Download and install package ([https://our.umbraco.org/projects/backoffice-extensions/mbran-error-404/][1])
2. Browse to your website http://yourdomain.com/pagedoestnotexist

## How to configure the 404 page:

* Create a property called "error404" with data type "content picker" from your domain node (where culture hostname is specified)
* OR create a doc type with alias "error404"
* OR if #1 and #2 are not found, 404 pages will render the homepage.

## Features:

* Multi-tenant support
* Fallback support 
