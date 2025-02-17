// STEP 1
// Create a builder object for a web app
// CreateBuilder() method initializes any instance of the web app Builder class
// and using the provided command line arguments

//And this is where the configuration, logging, and service dependencies are set up.

var builder = WebApplication.CreateBuilder(args);

// STEP 2
// Add services to the container.
// In here we can add the ASP.NET built-in services and any custom services 
// using the dependency injection
// So basically this command indicates that you can add services to the app dependency injection container
// services like db context configuration services or any custom services required by our 
// app should be registered in here.


// STEP 3
//Building the app --> This line builds web app based on the configurations and services defined in the builder
//and it prepares the app to start accepting the http request
var app = builder.Build();

// STEP 4
// Configure the HTTP request pipeline. --> After building the app, we can go here
// In here we can configure the middleware for the app's http request pipeline and
// middleware components, handle the requests and responses.
// The common examples including the configuring, routing, authentication, authorization, and serving the static files and so on


// STEP 5
// The last step is app.Run() which is to run the app
// This line basically starts the web app.
// It is listening for the incoming http requests and routes them to the appropriate endpoints or handlers
// as configured in the app in the previous step.

app.Run();

