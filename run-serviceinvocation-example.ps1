Start-Process -NoNewWindow dapr 'run --app-id serviceinvocation1 -- dotnet run --project .\ServiceInvocation1\ServiceInvocation1.csproj'
Start-Process -NoNewWindow dapr 'run --app-id greetservice --app-port 3500 -- dotnet run --project .\ServiceInvocation2\ServiceInvocation2.csproj'

