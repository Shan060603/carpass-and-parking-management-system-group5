# Use SDK to build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj and restore
COPY Carpass_Profilling.csproj ./
RUN dotnet restore

# Copy rest of the project
COPY . ./

# Publish app
RUN dotnet publish Carpass_Profilling.csproj -c Release -o /app/out

# Use runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "Carpass_Profilling.dll"]
