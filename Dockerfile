# Step 1: Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj and restore
COPY Carpass_Profilling.csproj ./
RUN dotnet restore

# Copy everything else and publish
COPY . ./
RUN dotnet publish Carpass_Profilling.csproj -c Release -o /app/publish

# Step 2: Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

COPY --from=build /app/publish ./

# Set environment variables if needed
# ENV ASPNETCORE_URLS=http://+:80

ENTRYPOINT ["dotnet", "Carpass_Profilling.dll"]
