FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
EXPOSE 5012
COPY . /app/
ENTRYPOINT ["dotnet", "ExchangeDemo.dll"]