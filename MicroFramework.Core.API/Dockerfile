FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-sac2016 AS build
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore
COPY . ./

WORKDIR /app
RUN dotnet publish -c Release -o out

FROM microsoft/dotnet:3.1-aspnetcore-runtime AS runtime

WORKDIR /app

COPY --from=build /app/out ./

ENTRYPOINT ["dotnet", "MicroFramework.Core.API.dll"]