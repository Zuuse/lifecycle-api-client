# lifecycle-api-client
A client API wrapper around the Zuuse Lifecycle API, providing access to lifecycle register, baselines and scenarios.

## Generation
This project is a lightweight, code-generated wrapper around the Zuuse Lifecycle API.  It is generated using Autorest https://github.com/Azure/autorest/blob/master/docs/generating-a-client.md in PowerShell as:

```
iwr https://zuuselifecyclemanagementapidev.azurewebsites.net/swagger/docs/v1 -o interface.xml
autorest --input-file=interface.xml --csharp --output-folder=Zuuse.Lifecycle.Client --namespace=Zuuse.Lifecycle.Client
```

Make sure to check the version in Zuuse.Lifecycle.Client.csproj for the NuGet package and make changes as necessary.
