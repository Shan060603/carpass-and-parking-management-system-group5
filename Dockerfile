# Use the official .NET 8.0 runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Use the .NET 8.0 SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy CSPROJ first and restore dependencies
COPY Carpass_Profilling.csproj ./
RUN dotnet restore

# Copy the rest of the project
COPY . ./

# Build and publish the app to the /app/out folder
RUN dotnet publish Carpass_Profilling.csproj -c Release -o /app/out

# Final runtime image
FROM base AS final
WORKDIR /app
COPY --from=build /app/out .

# Start the application
ENTRYPOINT ["dotnet", "Carpass_Profilling.dll"]
