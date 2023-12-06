# Blazor Web App with an API call

This sample updates the `Weather`` page in the default Blazor Web App to make an API call from the client to the server when the page is prerendered and uses the Auto render mode.

- The `Weather` component depends on an `IWeatherService` for getting the weather data. This insulates the component from needing to know where it is running.
- The server project has a `WeatherService` that generates the weather data and is exposed as an API endpoint.
- The client project has a `WeatherService` that calls the server API endpoint to get the weather data.
- The `Weather` page is prerendered using static streaming rendering, so the page loads immediately with a "Loading..." placeholder and then is updated with the weather data.
- The `Weather` page then renders using the Auto interactive render mode, so it renders initially from the server over a WebSocket while the .NET runtime is downloaded, and then switches to WebAssembly for future visits.
- The `Weather` page persists its prerendered state so that the state can be reused when the page renders interactively.
- Links to the `Weather` page disable enhanced navigation (`data-enhance-nav="false"`), which is currently incompatible with persisted component state ([dotnet/aspnetcore#51584](https://github.com/dotnet/aspnetcore/issues/51584))