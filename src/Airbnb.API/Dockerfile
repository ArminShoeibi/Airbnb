FROM mcr.microsoft.com/dotnet/sdk:6.0.300-bullseye-slim-amd64 AS sdk
WORKDIR /Airbnb-Source
COPY ["src/Airbnb.API/Airbnb.API.csproj", "src/Airbnb.API/"]
RUN dotnet restore "src/Airbnb.API/Airbnb.API.csproj"
COPY . .
RUN dotnet publish "src/Airbnb.API/Airbnb.API.csproj" -c Release -o Publish/

FROM mcr.microsoft.com/dotnet/aspnet:6.0.5-bullseye-slim-amd64
WORKDIR /app
EXPOSE 20000
COPY --from=sdk /Airbnb-Source/Publish .
ENTRYPOINT ["dotnet", "Airbnb.API.dll"]
