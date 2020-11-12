# webapi-docker

Dockerising a dotnet webapi app and deploying to Heroku (hopefully!)

# Starting the API locally

- On the command line: `dotnet run`
    - (Note that you can use `dotnet watch run` if you want to see code changes reflected as soon as you make them).
- Then in the browser, visit any of the following:
    - http://localhost:5000/swagger/index.html
    - http://localhost:5000/weatherforecast
    - http://localhost:5000/clareforecast
    - http://localhost:5000/shiny
    - (You need `http` for the endpoints, not `https`)
