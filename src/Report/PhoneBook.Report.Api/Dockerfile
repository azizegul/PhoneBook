FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5009

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Report/PhoneBook.Report.Api/PhoneBook.Report.Api.csproj", "src/Report/PhoneBook.Report.Api/"]
COPY ["src/Report/PhoneBook.Report.Infrastructure/PhoneBook.Report.Infrastructure.csproj", "src/Report/PhoneBook.Report.Infrastructure/"]
COPY ["src/Report/PhoneBook.Report.Application/PhoneBook.Report.Application.csproj", "src/Report/PhoneBook.Report.Application/"]
COPY ["src/Report/PhoneBook.Report.Domain/PhoneBook.Report.Domain.csproj", "src/Report/PhoneBook.Report.Domain/"]
RUN dotnet restore "src/Report/PhoneBook.Report.Api/PhoneBook.Report.Api.csproj"
COPY . .
RUN dotnet build "src/Report/PhoneBook.Report.Api/PhoneBook.Report.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "src/Report/PhoneBook.Report.Api/PhoneBook.Report.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PhoneBook.Report.Api.dll"]