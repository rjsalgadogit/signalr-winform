# signalr-winform
SignalR implementation in Winform App

1. Add Helper classes for SignalR in Server winform:
    - SignalRHub
    - SignalRServer

      ![Screenshot 2025-01-26 185431](https://github.com/user-attachments/assets/8a71407c-1459-4cf2-ba80-4e934bfd8a7d)

2. Install the ff. nuget packages:
    - microsoft.aspnetcore
    - microsoft.aspnetcore.hosting
    - microsoft.aspnetcore.signalr
    - microsoft.aspnetcore.signalr.client
    - microsoft.extensions.hosting

      ![image](https://github.com/user-attachments/assets/7a18eab0-6294-4728-9858-112bda15ba4a)

3. Right click on Server project > Edit Project File > Add the "Microsoft.AspNetCore.App" Framework reference inside of "ItemGroup" tag:
    - NOTE: This is for aspnetcore (see image below)

      ![image](https://github.com/user-attachments/assets/c9a6bb56-7e75-43ed-8e30-aa01aa12267d)

4. Input all the necessary code in SignalRServer.cs and SignalRHub.cs (please look at the project solution for reference).

5. Now, start the server from MainForm on load.
     - see image below for reference
  
       ![image](https://github.com/user-attachments/assets/71037605-e732-46cf-93db-6efe2a4ee8d0)


