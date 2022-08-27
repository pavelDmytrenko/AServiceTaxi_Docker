#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /build

RUN curl -sL https://deb.nodesource.com/setup_10.x |  bash -
RUN apt-get install -y nodejs

COPY ["AServiceTaxi/AServiceTaxi.csproj", "AServiceTaxi/"]
COPY ["AServiceTaxi.BL/AServiceTaxi.BL.csproj", "AServiceTaxi.BL/"]
COPY ["AServiceTaxi.DL/AServiceTaxi.DL.csproj", "AServiceTaxi.DL/"]
RUN dotnet restore "AServiceTaxi/AServiceTaxi.csproj"
COPY . .
WORKDIR /build/AServiceTaxi
RUN dotnet publish -c release -o published --no-cache

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /build/AServiceTaxi/published ./
ENTRYPOINT ["dotnet", "AServiceTaxi.dll"]