dotnet new sln -n EmailNotificationSystem
dotnet new webapi -n EmailNotificationSystem.Server
dotnet new blazorwasm -n EmailNotificationSystem.Client
dotnet new classlib -n EmailNotificationSystem.Shared
dotnet sln add EmailNotificationSystem.Server/EmailNotificationSystem.Server.csproj
dotnet sln add EmailNotificationSystem.Client/EmailNotificationSystem.Client.csproj
dotnet sln add EmailNotificationSystem.Shared/EmailNotificationSystem.Shared.csproj

dotnet add EmailNotificationSystem.Server reference EmailNotificationSystem.Shared
dotnet add EmailNotificationSystem.Client reference EmailNotificationSystem.Shared
