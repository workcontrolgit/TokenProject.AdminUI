
## Install the dotnet new template
dotnet new -i Skoruba.IdentityServer4.Admin.Templates::2.0.1

## Create new project
dotnet new skoruba.is4admin --name TokenProject --title TokenProject --adminemail "admin@example.com" --adminpassword "Pa$$word123" --adminrole MyRole --adminclientid MyClientId --adminclientsecret MyClientSecret --dockersupport true

## Project URL localhost and Azure
### DemoProject.Admin 
https://localhost:44303 
https://cat-token-admin.azurewebsites.net

### DemoProject.Admin.Api
https://localhost:44302
https://cat-token-adminapi.azurewebsites.net

### DemoProject.STS.Identity
https://localhost:44310
https://cat-token-identity.azurewebsites.net