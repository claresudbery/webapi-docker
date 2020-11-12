# webapi-docker

Dockerising a dotnet webapi app and deploying to Heroku.

The basic vanilla API was created using `dotnet new webapi` on the command line, and then I added a couple of endpoints.

# Starting the API locally

- On the command line: `dotnet run`
    - (Note that you can use `dotnet watch run` if you want to see code changes reflected as soon as you make them).
- Then in the browser, visit any of the following:
    - http://localhost:5000/swagger/index.html
    - http://localhost:5000/weatherforecast
    - http://localhost:5000/clareforecast
    - http://localhost:5000/shiny
    - (You need `http` for the endpoints, not `https`)

# Running the API in a docker container

- To get it to work locally, you have to uncomment the `ENTRYPOINT` command in `Dockerfile`.
- Then run the following:

`docker build -t webapi-docker .`
`docker run --rm -p 8080:80 --name webapi-docker-c webapi-docker`

- Then visit http://localhost:8080/clareforecast

# Deploying the API to Heroku

- Make sure the `ENTRYPOINT` command in `Dockerfile` is commented out
- Run the following:

`heroku container:push web --app [heroku app name]`
`heroku container:release web --app [heroku app name]`

Visit https://[heroku app name].herokuapp.com/shiny or any of the endpoints listed above.

It is currently deployed at https://webapi-docker.herokuapp.com/shiny (where you can also reach the other endpoints).
