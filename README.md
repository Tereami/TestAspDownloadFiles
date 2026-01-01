# TestAspDownloadFiles

A simple ASP.NET Core application consisting of a server and client component, implementing file downloads and uploads. The server side is ASP.NET Core MVC, the client side is Windows Forms. Version .NET 8.0.

Files are processed in a controller action (files are not public).

While downloading files, a progress bar, speed, and download progress are displayed. The entire process is performed asynchronously via FileStream.