# AServiceTaxi
 Service Taxi. ASP.Net Core 6 Application with Angular 14. Using Docker compose. 
 
 Make docker container
##link with exixsting info about docker  https://medium.com/bb-tutorials-and-thoughts/dockerizing-angular-app-with-net-core-backend-734ea2df84df
##setup from powerShell for prepare project

dotnet run
## build and publish
dotnet publish -c Release -o published
dotnet published/angular-dotnet-example.dll


##command for create build image - started from directory with Dockerfile
docker build -t ang-dotnet-img ..
## command for create and start container from existing image
docker run -d -p 5000:80 --name ang-dotnet-ui ang-dotnet-img

## checking container if need
docker exec -it ang-dotnet-ui /bin/sh
