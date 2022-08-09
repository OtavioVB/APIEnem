#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["APIEnem.API/APIEnem.API.csproj", "APIEnem.API/"]
COPY ["APIEnem.Domain/APIEnem.Domain.csproj", "APIEnem.Domain/"]
COPY ["APIEnem.Infra/APIEnem.Infra.csproj", "APIEnem.Infra/"]
RUN dotnet restore "APIEnem.API/APIEnem.API.csproj"
COPY . .
WORKDIR "/src/APIEnem.API"
RUN dotnet build "APIEnem.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "APIEnem.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "APIEnem.API.dll"]
