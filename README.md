# signalr-winform
SignalR implementation in Winform App

Server Setup:
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
     - e.g.
  
       ![image](https://github.com/user-attachments/assets/71037605-e732-46cf-93db-6efe2a4ee8d0)


Client Setup:
1. Install the ff. nuget packge:
    - microsoft.aspnetcore.signalr.client

        ![image](https://github.com/user-attachments/assets/65531554-a56e-48b2-a66f-c063121afa5c)

2. In MainForm.cs, Add method for "InitializeConnection":
    - e.g.

        ![image](https://github.com/user-attachments/assets/87cba179-a652-4894-aaff-f4b28a54ffb8)

4. In MainForm.cs, Add method for 'StartConnection":
    - e.g.

        ![image](https://github.com/user-attachments/assets/8668251e-600d-415c-9e0f-8444e9760ee4)

5. In Mainform.cs, Add method for "SendMessage" to send message in server as well:
    - e.g.

        ![image](https://github.com/user-attachments/assets/0980248c-fb45-43c4-a869-97a4dfaa9031)

6. Add the ff. method in constructor:
    - e.g.

        ![image](https://github.com/user-attachments/assets/d82b4770-7b56-46c1-bf5b-395c737123b2)

7. Sample UI for Client winform:
    - e.g.

        ![image](https://github.com/user-attachments/assets/0ef752d4-48c6-42fc-8f7b-30608f7657e5)
