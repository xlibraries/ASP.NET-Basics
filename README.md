# ASP.NET-Basics
1) Web form:-
Client server architure
Client --> Request --> Server(Presentation Layer, Buisness Layer, Data Access Layer, Database) --> Response --> Client

Over load   as everything is handle by single entity



2) ASP MVC

Model: Data[class]
View: UI page
Controller: logic
All three layers are splitted seperately so that load in reduced

Life Cycle
-Application: [Start,Stop] - fromthe  time it stared 
-Request: 
	The instance a request is made by your client
	Request life cycle unnique for every request.
	Request --> Controller --> Routing --> Action execution (based upon routing) --> Result execution --> Response
	Diagramitic representation: 

3) in Core 
There is a middle ware access info between clien and

Controller :
- SEt of Public methods
-Handles incoming request
-System.Web.MVC.Controller
-Interact with both models and views
-Every Controller must end with word 'controller'
---------------------x---------------------------l--------------------------------i----------------------------------b--------------------------------
1)Routing
-Conventional based
-Attribute Based

2)Restful Route

3)Creating Web API Controller for data Access

4)Data Repository and Dependency Injection
