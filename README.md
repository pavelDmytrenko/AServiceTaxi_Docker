# AServiceTaxi
 Service Taxi. ASP.Net Core 6 Application with Angular 10. Using Docker compose(Linux). 
 
##Make docker container of app
##link with exixsting info about docker  https://medium.com/bb-tutorials-and-thoughts/dockerizing-angular-app-with-net-core-backend-734ea2df84df
##setup from powerShell for prepare project

dotnet run
## build and publish
dotnet publish -c Release -o published
dotnet published/AServiceTaxi.dll


##command for create build image - started from directory with Dockerfile
docker build -t ang-dotnet-img ..
## command for create and start container from existing image
docker run -d -p 5000:80 --name ang-dotnet-ui ang-dotnet-img

## checking container if need
docker exec -it ang-dotnet-ui /bin/sh

## For Starting DB at Docker container

docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=1qaz@WSX" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-CU15-ubuntu-20.04 

##After that we have 2 container and should change connect to db at appsettings.json file (for my system )
  "ConnectionStrings": {
    "DefaultConnection": "Server=192.168.0.205,1433;User Id=sa;Password=1qaz@WSX;"
	
## We can check connection from Managment Studio - we can connect to server with this credentials.
