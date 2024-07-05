# StringtoQRdotnet
string to QR code generator .net
Create a new .NET Core Web Application:
Open a terminal or command prompt and create a new .NET Core Web Application: 
  "dotnet new web -o QrCodeGenerator"
  "cd QrCodeGenerator"
Add the QRCoder library:
"dotnet add package QRCoder"
Modify the Startup.cs:
Open the Startup.cs file and modify it to configure the application:
Create a QR Code Controller:
Create a new controller named QrCodeController:
In the Controllers folder (create it if it doesn't exist), create a new file named QrCodeController.cs.
