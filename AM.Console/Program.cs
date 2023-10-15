// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;

Console.WriteLine("Hello, World!");

//constructeur par défaut
Plane plane = new Plane();
plane.Capacity = 300;
plane.ManufactureDate = DateTime.Now;
plane.PlaneType = PlaneType.Boing;
//Constructeur paramétré
Plane plane2 = new Plane(PlaneType.Boing,new DateTime(2018,2,12),200);

//initialiseur d'objet 
Plane plane3 = new Plane
{
    Capacity = 100,
    ManufactureDate = DateTime.Now,
    PlaneType = PlaneType.Boing,
    PlaneId = 2
};


Passenger P1= new Passenger
{
    FirstName = "test",
    LastName = "test",
    EmailAddress = "test",
    
};
Traveller t1= new Traveller
{
    FirstName= "tra",BirthDate= DateTime.Now,   
};
Staff s1= new Staff
{
    FirstName= "test"
};
P1.PassengerType();
s1.PassengerType();
t1.PassengerType();
Console.WriteLine(P1.checkProfile("nom", "prenom"));