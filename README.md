# eSupport - Microservices Architecture and Containers
eSupport .NET Core reference application

**Note Visual Studio 2017 version required**: Please, use VS 2017 15.5 or later. 

## .NET Core 2.0 
NOTE: This Application is Divided in three main Parts.

## Part 1: Application
Application is the main source for the application which is developed using Election with .NET Core.

## Part 2: Services
Services is the backend part,the logical part based on microservices and DDD(Domain-Driven Design). For every service or Microservice is created a folder and Project.

## Part 3: Web 
The Web part is the portal of the eSupport System where the client can view the state of their ticket based on the ticket number they have received. The number is received through email in first place but also in invoice. They Can login to see the status with the number or email. Also can reply to the solution.

## The logic
The logic is based on Events, EventBus and other tools, using the concepts of DDD


## Run Application

Under the Application Folder run the follwoing command:
```
dotnet restore
```

Make sure you have node.js v8.6.0 and on macOS/Linux the electron-packager installed!
```
sudo npm install electron-packager --global
```

At the first time, you need an Electron.NET project initialization. Type the following command in your ASP.NET Core folder:
```
dotnet electronize init
```

Now a electronnet.manifest.json should appear in your ASP.NET Core project
After the generation run the following:
```    
dotnet electronize start
```

Enjoy the Electron Application Demo Part 1! :D

## Run Web
Under the Web Folder run the follwoing command:
```
npm install
```

Make sure you have @angular/cli installed!

```
sudo npm install @angular/cli@latest --global
```
and 
```
sudo npm install --save-dev @angular/cli@latest
```

At the first time, you need an restore of .NET Core libraries. Type the following command in your ASP.NET Core folder:
```
dotnet restore
```

Now we are ready to view the app running the following command:
```    
dotnet run
```

Enjoy the Web Demo Part 1! :D


The **dockerfiles** in the solution have also been updated and now support [**Docker Multi-Stage**](https://blogs.msdn.microsoft.com/stevelasker/2017/09/11/net-and-multistage-dockerfiles/) since mid-December 2017.

**Architecture overview**: 

## Overview of the application code

## Setting up your development environment

## Kubernetes 

## Questions

