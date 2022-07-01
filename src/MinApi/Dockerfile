FROM mcr.microsoft.com/dotnet/sdk as build
WORKDIR /app
COPY MinApi.csproj /app
RUN dotnet restore MinApi.csproj
COPY . /app/
RUN dotnet build -c Release
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/publish .
CMD dotnet MinApi.dll