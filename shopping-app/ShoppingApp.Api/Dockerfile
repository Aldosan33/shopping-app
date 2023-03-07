FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ShoppingApp.Api.csproj", "ShoppingApp.Api/"]
RUN dotnet restore "ShoppingApp.Api/ShoppingApp.Api.csproj"
COPY . ./ShoppingApp.Api

WORKDIR "/src/ShoppingApp.Api"
RUN dotnet build "ShoppingApp.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ShoppingApp.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ShoppingApp.Api.dll"]