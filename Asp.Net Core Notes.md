**Lecture :- 08 ( Asp.net core launchsetting.json file )**



\-> The setting of this file uses when we run our project using visual studio or .net core cli

\-> This file only required on our local development machine , we did not need it of to publishing our asp.net core application

\-> If there are some certain settings which are mandatory to use to run after publishing an app , then u can store them in appsetting.json file

\-> We can have appsetting.json file based on our enviornment like appsetting.staging.json etc

\-> When we run our project through ctrl+f5 or just f5 , then IIS Express profile is used

\-> There's one more profile which will get used when we run our project through cli

\-> You can select manually also about which profile u wanna run from dropdown which is at top





**Lecture :- 08 ( Asp.net core appsetting.json file )**



\-> Before asp.net core we store configuration information in webconfig file , but in asp.net core we store application configuration settings in appsetting.json file

\-> appsetting.json is kind of configuration sources file

\-> these configuration are usually stored as a key value pair

\-> To access all those configuration which we write in appsetting.json file , those we access through Iconfiguration Service

\-> In asp.net core dependency injection is an integral part

\-> Settings which are present in enviornment specific file , those will override in normal appsetting.json file

\-> Later configuration source override the setting of that key which is present in previously configuration source

\-> If we wanna give configuration through commandline then run ( dotnet run "mykey" = "value }

\-> We can add our custom configuration source too \& order can also be change according to us





**Lecture :- 08 ( Middleware in asp.net core )**



\-> A middleware is a software that habdles http request or response

\-> A given middleware component have very specific purpose like

&#x20; 1. To authenticate the user

&#x20; 2. To handle errors

&#x20; 3. To show static files

\-> It's the pipeline which decides how a request is processed

\-> A middleware processed the incoming request and then passed it to next midddleware

\-> A middleware can decide that too whether it needs to passed request to another middleware or not \& this is called short circuting

\-> A middleware can ignore request too

\-> These middleware are availiable as nuget pacakages , this means we can update each middleware seprately

&#x20;



**Lecture :- ( Configure ASP NET Core request processing pipeline )**



\-> app.Run() :- a method which response to an every object

\-> A request delegate is something which takes HttpContext as a parameter

\-> A terminal middleware is a middleware that's does not call the next request in the pipeline , so for that we use app.Use() method which takes two parameter one is Context \& Next



**app.Use(async (context , next) =>**

**{**

&#x20;  **await context.Repponse.WriteAsync("Welcome Back");**

&#x20;  **await next() :- to call next middleware**

**})**





**Lecture :- ( Static files in asp net core )**



\-> All static files must be in wwwroot folder which is inside project root folder

\-> app.UseStaticFiles()

\-> We can display those static files too which are not in wwwroot folder but through some other way

\-> By default default name of an document is ( default.htm or default.html or index.htm or index.html )

\-> These oders are also matter

&#x20;   app.UseStaticFiles() ; 



&#x20;   app.UseDefaultFiles() ;

\-> If usedafultfiles use before usestaticfiles , then only document files will get shows

\-> You can use app.UsefileServer() too after removing usestaticfiles \& usedafultfiles

\-> And to customise them we create object of that which contains this extension method











































































