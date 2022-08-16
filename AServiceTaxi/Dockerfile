#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AServiceTaxi/AServiceTaxi.csproj", "AServiceTaxi/"]
COPY ["AServiceTaxi.BL/AServiceTaxi.BL.csproj", "AServiceTaxi.BL/"]
COPY ["AServiceTaxi.DL/AServiceTaxi.DL.csproj", "AServiceTaxi.DL/"]
RUN dotnet restore "AServiceTaxi/AServiceTaxi.csproj"
COPY . .
WORKDIR "/src/AServiceTaxi"
RUN dotnet build "AServiceTaxi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AServiceTaxi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AServiceTaxi.dll"]