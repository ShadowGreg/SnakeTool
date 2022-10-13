FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SnakeTool/SnakeTool.csproj", "SnakeTool/"]
RUN dotnet restore "SnakeTool/SnakeTool.csproj"
COPY . .
WORKDIR "/src/SnakeTool"
RUN dotnet build "SnakeTool.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SnakeTool.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SnakeTool.dll"]
