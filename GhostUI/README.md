# ASP.NET Core 7.0 + React + Redux + TypeScript + Hot Module Replacement (HMR)
This template is a SPA application built using ASP.NET Core 7.0 as the REST API server and React/Redux/TypeScript as the web client (Bulma + SASS + styled-components for UI styling). You can find a similar version using Vue + Vuex (and associated libraries) here: [aspnet-core-vue-vuex-playground-template](https://github.com/based-ghost/aspnet-core-vue-vuex-playground-template)


![demo](./demo/react_dot_net_52530-2021.gif)


## General Overview
This template is vaguley based on the original React + Redux .NET Core SPA template that was offered around the time of .NET Core 2.0 release (the existing template is a much more simplified version of what was offered in the past and the structure is quite different as well). Using that as a base, this template greatly extends the functionality provided and also uses the latest versions of all referenced libraries/packages. Keep in mind that I use this project (or others like it) as a testing ground for varying libraries/packages and it is not meant to act as a stand-alone final solution - it is more of POC. For example, the login & logout processes are stubbed to simulate the actual process (no real authentication is happening, however, it is something I plan to add to this project in the near future). I plan on keeping this up to date, and the listed technology stack may be subject to change.

> <strong><em>Note: All components are written using `FunctionComponents` & `React Hooks`. Legacy class components are not used.</em></strong><br>

## Technology Stack Overview
- **Server**
  - ASP.NET Core 7.0
  - SignalR
  - HealthChecks + [AspNetCore.HealthChecks.UI package](https://github.com/xabaril/AspNetCore.Diagnostics.HealthChecks) - this provides  a nicely formatted UI for viewing the results of the HealthCheck modules in use and is accessed on ```/health-ui``` (also, provide an option for viewing the raw JSON data that the UI package prettifies for you at ```/healthchecks-json```). Access this view in the application via the floating settings cog on right screen by clicking the "Health Checks" link.
  - API Documentation using Swagger UI - using package [NSwag.AspNetCore](http://NSwag.org) to prettify the specification output and display at ```/swagger/*``` & [NSwag.MSBuild](http://NSwag.org) to handle automatic updates - so that when the project builds, the NSwag CLI will run and generate an updated API specification. Access this view in the application via the floating settings cog on right screen by clicking the "Swagger API" link.
  - Brotli/Gzip response compression (production build)
- **Client**
  - [`React`](https://reactjs.org/)
  - [`Redux`](https://redux.js.org/)
  - [`TypeScript`](https://www.typescriptlang.org/)
  - [`Webpack`](https://github.com/webpack/webpack) for bundling of application assets and HMR (Hot Module Replacement)
  - [`Bulma CSS`](https://bulma.io/) + [`SASS`](https://github.com/sass/sass) + Font Awesome 5 (using fontawesome-svg-core)
  - [`styled-components`](https://www.styled-components.com/) - CSS-in-JS via template literals - Examples in this project:   `Checkbox.tsx`, `Spinner.tsx`, `Authenticator.tsx`, `Settings.tsx`, and `Footer.tsx` are written using `styled-components`.
  - [`react-functional-select`](https://github.com/based-ghost/react-functional-select) - A micro-sized & micro-optimized select component for ReactJS. Inspired by [`react-select`](https://github.com/JedWatson/react-select) and built for ultimate performance - leverages [`react-window`](https://github.com/bvaughn/react-window) to virtualize long options data and `styled-components` to handle styling via CSS-in-JS. Note: I am the author of this package.
  - [`Axios`](https://github.com/axios/axios) for REST endpoint requests
  - [`react-toastify`](https://github.com/fkhadra/react-toastify) - a highly configurable toast notification library - comes hooked up to display login error & SignalR hub push notifications examples.
  - react-router/react-router-dom - route transitions handled using [`react-transition-group`](https://github.com/reactjs/react-transition-group)
  - Custom, reusable Dropdown & Checkbox components that provide full functionality w/ state management (without a JQuery dependency).
  - Two different loader components (spinner & authentication animation w/ callback for success/fail)

## Setup
  - [Node.js version >= 14](https://nodejs.org/en/download/)
  - [`.NET 7.0 SDK`](https://dotnet.microsoft.com/download/dotnet/7.0)
  - Clone the repository and run ```npm install``` from the root of the ```ClientApp``` directory to properly install all node packages/dependencies.
  - Opening the solution in VisualStudio should automatically trigger nuget package and other dependencies to be restored (assuming latest version of VisualStudio and installation of .NET Core version mentioned aboved). If issues are encountered, attempting to refresh the dependencies or executing a ```rebuild solution``` should resolve them.
  - A solution.sln file is added to act as an entry point to open the application in Visual Studio. Visual Studio 2022 and up.
  - GhostUI/GhostUI.csproj acts as the entry point to open the application in Visual Studio Code.
