FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ShoppingApp.Client/ShoppingApp.Client.csproj", "ShoppingApp.Client/"]
RUN dotnet restore "ShoppingApp.Client/ShoppingApp.Client.csproj"
COPY . .
WORKDIR "/src/ShoppingApp.Client"
RUN dotnet build "ShoppingApp.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ShoppingApp.Client.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ShoppingApp.Client.dll"]