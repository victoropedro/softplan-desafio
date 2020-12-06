FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["taxajuros.csproj", "./"]
RUN dotnet restore "./taxajuros.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "taxajuros.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "taxajuros.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "taxajuros.dll"]
