#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Calculadora.Client/Calculadora.Client.csproj", "Calculadora.Client/"]
COPY ["Calculadora.Client.Domain/Calculadora.Client.Domain.csproj", "Calculadora.Client.Domain/"]
COPY ["Calculadora.Client.Anticorruption/Calculadora.Client.Anticorruption.csproj", "Calculadora.Client.Anticorruption/"]
RUN dotnet restore "Calculadora.Client/Calculadora.Client.csproj"
COPY . .
WORKDIR "/src/Calculadora.Client"
RUN dotnet build "Calculadora.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Calculadora.Client.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Calculadora.Client.dll"]