# Versioned Web API Example

This project is an exploration of the versioning functionality for ASP.NET Core api controllers.

Note: this project was created from aspnetcore 2.1 template and then upgraded to aspnetcore 3.1 to better replicate what would need to happen in some of my existing projects to support the versioning package.

This is based on https://github.com/microsoft/aspnet-api-versioning

Some lessons learned so far
- dotnetcore 2.1 does not seem supported by the Microsoft.AspNetCore.Mvc.Versioning package.
- The swagger example at the versioning project site seems to be broken at this time (sad face)
- Versioning by a date string yyyymmdd seems to make sense over 1.0 since this would provide context of when a version became supported and might reduce the fear of too many versions.

What's next
- figure out how to get swagger to work with this
