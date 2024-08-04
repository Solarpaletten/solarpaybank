# Use the official .NET Core SDK image as a build environment
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copy the .csproj file and restore as distinct layers
COPY ./Business/*.csproj ./Business/
COPY ./Data/*.csproj ./Data/
COPY ./DataAccess/*.csproj ./DataAccess/
COPY ./solarpay_client/*.csproj ./solarpay_client/
COPY ./solarpay_core/*.csproj ./solarpay_core/

RUN dotnet restore ./Business/YourApp.csproj

# Copy everything else and build
COPY . ./
RUN dotnet publish ./Business/YourApp.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .

# Expose port 80
EXPOSE 80

# Entry point for the application
ENTRYPOINT ["dotnet", "YourApp.dll"]
