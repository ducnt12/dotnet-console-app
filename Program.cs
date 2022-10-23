// See https://aka.ms/new-console-template for more information
// Add(1, 2, 3);
Car car = new Car("Ford", "Mustang", 2022);
Car car1 = new Car("Ford", "Mustang", 2021);
Car car2 = new Car("Ford", "Mustang", 2020);
Bicycle bike1 = new Bicycle();
car.Drive();
bike1.Drive();
System.Console.WriteLine(car.GetSpeed());
System.Console.WriteLine(bike1.GetSpeed());
System.Console.WriteLine(Vehicle.GetNumberOfVehicles());

