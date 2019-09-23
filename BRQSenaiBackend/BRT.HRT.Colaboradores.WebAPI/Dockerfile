FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["BRT.HRT.Colaboradores.WebAPI/BRT.HRT.Colaboradores.WebAPI.csproj", "BRT.HRT.Colaboradores.WebAPI/"]
RUN dotnet restore "BRT.HRT.Colaboradores.WebAPI/BRT.HRT.Colaboradores.WebAPI.csproj"
COPY . .
WORKDIR "/src/BRT.HRT.Colaboradores.WebAPI"
RUN dotnet build "BRT.HRT.Colaboradores.WebAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "BRT.HRT.Colaboradores.WebAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BRT.HRT.Colaboradores.WebAPI.dll"]