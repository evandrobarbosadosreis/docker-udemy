#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["DockerDotnet.Api/DockerDotnet.Api.csproj", "DockerDotnet.Api/"]
RUN dotnet restore "DockerDotnet.Api/DockerDotnet.Api.csproj"
COPY . .
WORKDIR "/src/DockerDotnet.Api"
RUN dotnet build "DockerDotnet.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerDotnet.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DockerDotnet.Api.dll"]