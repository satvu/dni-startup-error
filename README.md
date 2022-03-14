# Azure Functions Investigating .NET6 Isolated Startup Failures

- Used to investigate [startup failures](https://github.com/Azure/azure-functions-host/issues/8025) with .NET6 isolated. Attempt to repro the [startup error from the scneario in this comment](https://github.com/Azure/azure-functions-dotnet-worker/issues/747#issuecomment-989926373).
- Compared this to the [Inproc Version](https://github.com/satvu/inproc-startup-failure) of this app, no error is thrown for the missing `secrets.json` file.
