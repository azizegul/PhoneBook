FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5007

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Contact/PhoneBook.Contact.Api/PhoneBook.Contact.Api.csproj", "src/Contact/PhoneBook.Contact.Api/"]
COPY ["src/Contact/PhoneBook.Contact.Infrastructure/PhoneBook.Contact.Infrastructure.csproj", "src/Contact/PhoneBook.Contact.Infrastructure/"]
COPY ["src/Contact/PhoneBook.Contact.Application/PhoneBook.Contact.Application.csproj", "src/Contact/PhoneBook.Contact.Application/"]
COPY ["src/Contact/PhoneBook.Contact.Domain/PhoneBook.Contact.Domain.csproj", "src/Contact/PhoneBook.Contact.Domain/"]
RUN dotnet restore "src/Contact/PhoneBook.Contact.Api/PhoneBook.Contact.Api.csproj"
COPY . .
RUN dotnet build "src/Contact/PhoneBook.Contact.Api/PhoneBook.Contact.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "src/Contact/PhoneBook.Contact.Api/PhoneBook.Contact.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PhoneBook.Contact.Api.dll"]