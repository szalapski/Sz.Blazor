#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Sz.Blazor/Sz.Blazor.csproj", "Sz.Blazor/"]
COPY ["Sz.Blazor.Client/Sz.Blazor.Client.csproj", "Sz.Blazor.Client/"]
RUN dotnet restore "./Sz.Blazor/Sz.Blazor.csproj"
COPY . .
WORKDIR "/src/Sz.Blazor"
RUN dotnet build "./Sz.Blazor.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Sz.Blazor.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sz.Blazor.dll"]