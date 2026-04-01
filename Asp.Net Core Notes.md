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





**Lecture :- ( ViewBag in ASP NET Core MVC )**



\-> With viewbag we use dynamic property but in viewdata we use string keys

\-> No compile time checking

\-> Loosely type view





**Lecture :- ( Strongly Typed View in ASP NET Core MVC )**



\-> To use this we have to specify @model directive at the top

\-> With the directive we use lower case 'm' \& with property upper case 'M'





**Lecture :- ( ViewModel in ASP NET Core MVC )**



\-> It can be in anywhere in our project

\-> To settle data b/w view \& controller

\-> Basically when we wanna bind model data \& other data too in single model

\-> We create viewmodel inside viewmodel folder and Its a csharph file

\-> We create this when our model does not contains all the data which our view needs





**Lecture :- ( List view in asp net core mvc )**



\-> Nothing just passed data in form of list and show on view through foreach loop





**Lecture :- ( Layout view in asp net core mvc )**



\-> Without layout view we repeat common view in so many files

\-> So in layout file we define them one's and then just use path of that layout file

\-> We majorly keep layout file in shared folder

\-> @RenderBody() :- this is something through which normal view file data render in layout file

\-> To include this layout file we have to set path in Layout property





**Lecture :- ( Sections in layout page in ASP NET Core MVC )**



\-> It provides a way to organize where certain element would be place

\-> @RenderSection("newsection" , false) :- basically u can used for some specific section and using true or false means not mandatory to create in specific view file

\-> @section newsection :- to create section in specific view file





**Lecture :- ( ViewStart cshtml in ASP NET Core MVC )**



\-> In this file we majorly add layout file path because to write layout file in multiple file and let suppose it needs to be change so we have to change name in all of the files , instead of it we give that file name in viewstart file

\-> If layout path is also available in normal view file then it override path in viewtstart file

\-> Viewstart file executed first before normal view code executes

\-> If multiple viewstart file is there then first one viewtsrt will get executed





**Lecture :- ( ViewImports cshtml in ASP NET Core MVC )**



\-> Instead of writing full model path including project name , so instead of this we write path till models in viewimports file and rest model name can be used in specific file according to requirement



**Lecture :- ( Routing in ASP NET Core MVC )**



\-> There are two types of routing

&#x20; 	1. Conventional Routing

&#x09;2. Attribute Routing

\-> When we hit on something and that hit will go to a specific method of some specific controller , thats handled through this route rules

\-> app.usemvcwithdefaultroute() means it use with default route ( Controller \& Action method name already there )

\-> app.usemvc() or app.MapControllerRoute() no configured route

\-> We did not required to add Controller as a prefix in route

\-> Here above basically we have done conventional routing

\-> To make parameter optional , just add ? at the end of paramater in program.cs where u are writing path for routing which is known as convetional routing





**Lecture :- ( Attribute Routing in ASP NET Core MVC )**



\-> For this we use Route() attribute on controller to define routing for our application

\-> If we are using conventional routing , then it does not matter whatever we are using name of controller or method name . Only matter is whatever we are writing inside route attribute
-> If u wanna use some specific view then use absolute path of that view in view()

\-> We can apply route attribute on controller class too , to avoid repetition of writing controller name again \& again

\-> When we are using just '\\' or \~\\ in route attribute then at that time it does not combined with specific method

\-> Convetional routing supports token replacement also like this \[Route("controller")]



**Lecture :- ( Install and use Bootstrap in ASP NET Core )**



\->  There are many tools which we can use with visual studio to install client side pacakages like bower , npm and webpack etc . Instead of this we use libman manager to install these packages

\-> To install these pacakages just right click on projet and then on client side library

\-> We can edit version also over there of that library

\-> After clicking on add these will automatically add into lib folder which is inside wwwroot folder

\-> There's one more file libman.json in which version of these library will get manage \& one change done in that , it will automatically reflect in lib folder which is inside wwwroot folder

\-> If u wanna clean these libraries then just right click on this .json file and clean . Same like restore option is also availiable





**Lecture :- ( AddSingleton vs AddScoped vs AddTransient )**



\-> To inject service into view , for that we use @injective in a view



**AddSingleton :-** In this when first object or instace is created of that class which implements functionality of an interface , that will going to use throughout



**AddScoped :-** Basically in this only same instance or object is going to used inside that single request only , once another request comes another object will get creates



**AddTransient :-** When this service is used during every http request , every instance or object is created . In this basically changes done by controller not going to seen by view and same vice versa





**Lecture :- ( Introduction to entity framework core )**



\-> It's also known as EF Core

\-> ORM Tool ( Object Relational Mapper )

\-> Lightweight , Opensource \& Extensible

\-> Microsoft's official data access platform

\-> It enables developers to works with objects



**Use of an orm :-**

\-> Without orm we have to write a lot of data access code to retrieve \& update data of something like an employee



\-> With the help of EF Core , we did not required to write data access code which works between our db \& model class



\-> Ef Core supports both db first \& code first approach . BTW database first approach have every less functionalities which it supports



**Code-First Approach** :- 

\-> With this first we create application domain classess ( models ) \& db context class 

\-> With the help of this EF Core it will create tables \& etc in our database



**Database-First Approach :-** 

\-> With the help of ef core it will create classess \& db context class in our code



\-> EF Core is able to do all of these things beccause of these database providers

\-> Database Providers sits between EF Core \& Database





**Lecture :- ( Install entity framework core in visual studio )**



\-> Meta pacakages does not have their own code , they only contains list of other packages

\-> application which is on Asp.net core 2.0 or above version will contained EF core already installed as part of meta pacakage

\-> EF Core is usually required in Data Access Layer Project which is a class library project and it does not have these meta pacakages 



**Entity Framework Core Package :-**

1. Microsoft.EntityFrameworkCore.SqlServer
2. Microsft.EntityFrameworkCore.Relation
3. Microsoft.EntityFrameworkCore

First one have dependency on second , second one on third.

If we installed Microsoft.EntityFrameworkCore.SqlServer , then remaining were automatically installed by themself



**Lecture :- ( DbContext in entity framework core )**

\-> This is a class which we use in our application to our database

\-> This class we use to save \& retrieve data from our db

\-> To make our class behave like dbcontext class we derived it from  DbContext 

\-> To do any sql work , it needs instance of dbContext options class

\-> We need a DbSet<> property for each table , procedure or view which we have in our db































































































































