#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.


FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["OC.MembersAPI/OC.MembersAPI.csproj", "OC.MembersAPI/"]
COPY ["OC.Data/OC.Data.csproj", "OC.Data/"]
COPY ["OC.Domain/OC.Domain.csproj", "OC.Domain/"]
RUN dotnet restore "OC.MembersAPI/OC.MembersAPI.csproj"
COPY . .
WORKDIR "/src/OC.MembersAPI"
RUN dotnet build "OC.MembersAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OC.MembersAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OC.MembersAPI.dll"]