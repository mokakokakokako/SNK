FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["snk/snk.csproj", "snk/"]
RUN dotnet restore "snk/snk.csproj"
COPY . .
WORKDIR "/src/snk"
RUN dotnet build "snk.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "snk.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "snk.dll"]
