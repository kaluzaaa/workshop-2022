FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
COPY 07.csproj /app
RUN dotnet restore 07.csproj
COPY . /app/
RUN dotnet build -c Release
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/publish .
CMD dotnet 07.dll  --urls=http://0.0.0.0:5000