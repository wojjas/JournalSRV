DESCR:
This is the server-part of an web-app. An example inspired from pluralsight course:
http://pluralsight.com/courses/table-of-contents/html5-advanced "Offline Applications"

PROJECT CREATION:
New project... C#, Web, "ASP .NET Web Application", Empty, Web Api
(Add Controller)

CORS: (see http://enable-cors.org/)
To make it possible to access this server's api from another domain:
1) Add with NuGet: microsoft.aspnet.webapi and then microsoft.aspnet.webapi.cors
   https://www.nuget.org/packages/Microsoft.AspNet.WebApi.Cors/5.2.2 
2) Modify *Controller.cs with "using System.Web.Http.Cors;" & "[EnableCors(origins: "*", headers: "*", methods: "*")]"
3) Modify WebApiConfig.cs with "config.EnableCors();"

RECEIVE PARAMETER:
To be able to receive a parameter to the post method.

JSON:
To be able to respond with an JSON string.


MSIC:
This server presents one interface configured through:
WebApiConfig.cs
http://localhost:49992/api/message/get
To get to get an response.
Of course "get" can be replaced by "post/delete/put" and an parameter can be appended.
