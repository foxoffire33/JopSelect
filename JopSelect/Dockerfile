FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["JopSelect/JopSelect.csproj", "JopSelect/"]
RUN dotnet restore "JopSelect/JopSelect.csproj"
COPY . .
WORKDIR "/src/JopSelect"
RUN dotnet build "JopSelect.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JopSelect.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JopSelect.dll"]
