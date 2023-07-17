FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/phadec.Web.Host/phadec.Web.Host.csproj", "src/phadec.Web.Host/"]
COPY ["src/phadec.Web.Core/phadec.Web.Core.csproj", "src/phadec.Web.Core/"]
COPY ["src/phadec.Application/phadec.Application.csproj", "src/phadec.Application/"]
COPY ["src/phadec.Core/phadec.Core.csproj", "src/phadec.Core/"]
COPY ["src/phadec.EntityFrameworkCore/phadec.EntityFrameworkCore.csproj", "src/phadec.EntityFrameworkCore/"]
WORKDIR "/src/src/phadec.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/phadec.Web.Host", "src/phadec.Web.Host"]
COPY ["src/phadec.Web.Core", "src/phadec.Web.Core"]
COPY ["src/phadec.Application", "src/phadec.Application"]
COPY ["src/phadec.Core", "src/phadec.Core"]
COPY ["src/phadec.EntityFrameworkCore", "src/phadec.EntityFrameworkCore"]
WORKDIR "/src/src/phadec.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "phadec.Web.Host.dll"]
