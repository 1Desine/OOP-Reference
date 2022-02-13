FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Haha/Haha.csproj", "Haha/"]
RUN dotnet restore "Haha/Haha.csproj"
COPY . .
WORKDIR "/src/Haha"
RUN dotnet build "Haha.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Haha.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Haha.dll"]
