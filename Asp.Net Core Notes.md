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





