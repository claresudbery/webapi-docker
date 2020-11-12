FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
COPY webapi-docker/*.csproj ./webapi-docker/
RUN dotnet restore ./webapi-docker/webapi-docker.csproj

# copy everything else and build app
COPY webapi-docker/. ./webapi-docker/
WORKDIR /source/webapi-docker
RUN dotnet publish webapi-docker.csproj -c release -o /app

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app ./

# To run the docker container locally, the ENTRYPOINT line needs to be uncommented.
# (...but to deploy to heroku, the ENTRYPOINT line needs to be commented out.)
#ENTRYPOINT ["dotnet", "webapi-docker.dll"]

# Tell Docker that when we run "docker run", we want it to
# run the following command:
CMD ASPNETCORE_URLS=http://*:$PORT dotnet webapi-docker.dll
# $PORT is set by Heroku - we don't use port 5000 like we normally would with ASP.Net


