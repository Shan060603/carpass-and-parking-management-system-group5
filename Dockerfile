# Use SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy all files (including .csproj) first to ensure layer caching
COPY . .

# Restore dependencies
RUN dotnet restore

# Publish the application
RUN dotnet publish Carpass_Profilling.csproj -c Release -o /app/out

# Use ASP.NET runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copy published output from build stage
COPY --from=build /app/out .

# Run the app
ENTRYPOINT ["dotnet", "Carpass_Profilling.dll"]
