FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ClassroomBooking.Web/ClassroomBooking.Web.csproj", "ClassroomBooking.Web/"]
COPY ["ClassroomBooking.Infrastructure/ClassroomBooking.Infrastructure.csproj", "ClassroomBooking.Infrastructure/"]
COPY ["ClassroomBooking.Application/ClassroomBooking.Application.csproj", "ClassroomBooking.Application/"]
COPY ["ClassroomBooking.Domain/ClassroomBooking.Domain.csproj", "ClassroomBooking.Domain/"]
COPY ["ClassroomBooking.Persistence/ClassroomBooking.Persistence.csproj", "ClassroomBooking.Persistence/"]
RUN dotnet restore "ClassroomBooking.Web/ClassroomBooking.Web.csproj"
COPY . .
WORKDIR "/src/ClassroomBooking.Web"
RUN dotnet build "ClassroomBooking.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "ClassroomBooking.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
ENV ASPNETCORE_ENVIRONMENT=Development
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ClassroomBooking.Web.dll"]
