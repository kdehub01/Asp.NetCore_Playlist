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





**Lecture :- ( ASP NET Core developer exception page )**



\-> app.UseDeveloperExceptionPage()

\-> To customise this developerexception page , we create a object of developerexceptionpageoptions

\-> There's a property sourcecodelinecount property in this which shows how many lines u wanna show on a error page





**Lecture :- ( ASP NET Core environment variables ) ( Pending )**





**Lecture :- ( ASP NET Core MVC tutorial )**



\-> Model View Controller

\-> It have multiple layers majorly ( User Interface Layer , Buisness Logic Layer , Data Access Layer )

\-> We use DI because its loosely coupled





**Lecture :- ( Setup mvc in asp net core )**



\-> AddMvc() :- to add all the mvc services we required

\-> app.UseMvcWithDefaultRoute()

\-> If something is using with services then it's a service , but if something is using with app.something then its a middleware

\-> Before to use UseMvcWithDefaultRoute() we have to add AddMvc() in program.cs file





**Lecture :- ( ASP NET Core AddMvc vs AddMvcCore )**



\-> AddMvc() method internally calls AddMvcCore() method also

\-> AddMvcCore() method only uses core services but Addmvc() use all the required mvc services





**Lecture :- ( Model in ASP NET Core MVC )**



\-> A models in mvc that contains set of setup of classess which represent \& manage data

\-> We use interface in our mvc project because for dependency injection \& without this unit testing also become difficult to do





**Lecture :- ( ASP NET Core dependency injection tutorial )**



\-> When someone like HomeController request IEmployeeRepository , then we want from asp.net core to create an instance of an implement of IEmployeeRepository which is MockEmployeeRepository and then inject that instance into a controller but bydefault dependency injection system will not able to do that

\-> So because of that we have to register IEmployeeRepository and its implementation into program.cs file

\-> builder.Services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>(); 

with the help of above line when homecontroller request to IEmployeeRepository service of MockEmployeeRepository and then inject that instance into HomeController

\-> Asp.net core provides 3 methods to register depeddency injection in dependency injection container , these method determines the lifetime of that specific registered services

&#x20; 1. AddScoped<> :- This create an instance once per request within a scope and used same instance with other calls but in same web request

&#x20; 2. AddTransient<> :- Each time it create an instance whenever its required

&#x20; 3. AddSingleton<> :- this create instance only one time and that instance only used in whole application





**Lecture :- ( Controller in ASP NET Core MVC )**



\-> A controller in mvc is class that derived fron Controller base class 

\-> A name of controller class ends with Controller

\-> A set of methods inside this controller is called an action methods

\-> Basically data pass fron controller to view through binding with model





**Lecture :- ( Views in ASP NET Core MVC )**

\-> In mvc it looks for a view inside a name of that folder which is matached with controller name

\-> View name should be same as a method name

\-> Extension os this file is .cshtml





**Lecture :- ( Customize view discovery in asp net core mvc )**



\-> Basically we can return view() with or without data

\-> return View("../SomeCustomViews/customviewfile") :- this .. means to move one level up in a hierarchy

no of levels up , u have to add that number of dots like for 2 level up 4 dots need





**Lecture :- ( Passing data to view in ASP NET Core MVC )**



\-> There are 3 ways to pass data from controller to view 

&#x20;  1. ViewData ( Loosely Typed )

&#x20;  2. ViewBag ( Loosely Typed )

&#x20;  3. Strongly Typed View

\-> ViewData :- Dictionary of weeakly typed objects

&#x09;       Use string keys to store data

&#x09;       Dynamically resolved at runtime

&#x20;              No compile time checking	

\-> View is a kind of razor view in which we write C# \& html code together

&#x09;       	















































