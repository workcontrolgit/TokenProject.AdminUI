FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/TokenProject.STS.Identity/TokenProject.STS.Identity.csproj", "src/TokenProject.STS.Identity/"]
COPY ["src/TokenProject.Admin.EntityFramework.Shared/TokenProject.Admin.EntityFramework.Shared.csproj", "src/TokenProject.Admin.EntityFramework.Shared/"]
COPY ["src/TokenProject.Shared/TokenProject.Shared.csproj", "src/TokenProject.Shared/"]
RUN dotnet restore "src/TokenProject.STS.Identity/TokenProject.STS.Identity.csproj"
COPY . .
WORKDIR "/src/src/TokenProject.STS.Identity"
RUN dotnet build "TokenProject.STS.Identity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TokenProject.STS.Identity.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "TokenProject.STS.Identity.dll"]