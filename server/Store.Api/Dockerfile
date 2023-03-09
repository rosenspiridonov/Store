FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Copy and restore Store.Api project
COPY ["Store.Api/Store.Api.csproj", "Store.Api/"]
RUN dotnet restore "Store.Api/Store.Api.csproj"

# Copy and restore Store.Data project
COPY ["Store.Data/Store.Data.csproj", "Store.Data/"]
RUN dotnet restore "Store.Data/Store.Data.csproj"

# Copy remaining source code
COPY . .

WORKDIR "/src/Store.Api"
RUN dotnet build "Store.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Store.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=build /src/Store.Data/bin/Release/net7.0/* /app/publish/
ENTRYPOINT ["dotnet", "Store.Api.dll"]
