FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/TokenProject.Admin/TokenProject.Admin.csproj", "src/TokenProject.Admin/"]
COPY ["src/TokenProject.Admin.EntityFramework.Shared/TokenProject.Admin.EntityFramework.Shared.csproj", "src/TokenProject.Admin.EntityFramework.Shared/"]
COPY ["src/TokenProject.Admin.EntityFramework.SqlServer/TokenProject.Admin.EntityFramework.SqlServer.csproj", "src/TokenProject.Admin.EntityFramework.SqlServer/"]
COPY ["src/TokenProject.Admin.EntityFramework.PostgreSQL/TokenProject.Admin.EntityFramework.PostgreSQL.csproj", "src/TokenProject.Admin.EntityFramework.PostgreSQL/"]
COPY ["src/TokenProject.Shared/TokenProject.Shared.csproj", "src/TokenProject.Shared/"]
COPY ["src/TokenProject.Admin.EntityFramework.MySql/TokenProject.Admin.EntityFramework.MySql.csproj", "src/TokenProject.Admin.EntityFramework.MySql/"]
RUN dotnet restore "src/TokenProject.Admin/TokenProject.Admin.csproj"
COPY . .
WORKDIR "/src/src/TokenProject.Admin"
RUN dotnet build "TokenProject.Admin.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TokenProject.Admin.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "TokenProject.Admin.dll"]