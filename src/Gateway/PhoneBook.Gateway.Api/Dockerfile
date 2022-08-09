FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Gateway/PhoneBook.Gateway.Api/PhoneBook.Gateway.Api.csproj", "src/Gateway/PhoneBook.Gateway.Api/"]
RUN dotnet restore "src/Gateway/PhoneBook.Gateway.Api/PhoneBook.Gateway.Api.csproj"
COPY . .
RUN dotnet build "src/Gateway/PhoneBook.Gateway.Api/PhoneBook.Gateway.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "src/Gateway/PhoneBook.Gateway.Api/PhoneBook.Gateway.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 5005
ENTRYPOINT ["dotnet", "PhoneBook.Gateway.Api.dll"]
