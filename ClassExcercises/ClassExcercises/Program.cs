using System;

namespace ClassExcercises
{
    class Program
    {

        static void Main(string[] args)
        {
            //=============FOR USERS===============//
            User user1 = new User();
            user1.forename = "Leonardo";
            user1.surname = "Turtle";
            user1.nickname = "Leo";
            user1.age = 7;
            user1.email = "Leo@gmail.com";

            User user2 = new User();
            user2.forename = "Raphael";
            user2.surname = "Turtle";
            user2.nickname = "Raph";
            user2.age = 8;
            user2.email = "Raph@gmail.com";

            User user3 = new User();
            user3.forename = "Donatello";
            user3.surname = "Turtle";
            user3.nickname = "Don";
            user3.age = 9;
            user3.email = "Don@gmail.com";

            user1.PrintInfo();
            user2.PrintInfo();
            user3.PrintInfo();

            User user4 = new User("Michaelangelo", "Turtle", "Mike", 9, "Mike@gmail.com");
            user4.PrintInfo();

            Console.WriteLine();

            //=============FOR USERS initialising===============//
            //1.Try instantiating users in different ways using a object initializers with and without constructors.


            //=============FOR CAR===============//
            Console.WriteLine("Car Excercises");
            Car car1 = new Car();
             car1.manufacturer = "Vauxhall";
             car1.model = "Nova";
             car1.dateManufactured = "1980";

            car1.GetInformation();
            Console.WriteLine(car1.GetInfo());

            Car car2 = new Car("Mini", "Cooper", "2000");
            car2.GetInformation();
            Console.WriteLine(car2.GetInfo());
        }
    }
}





//2.Research task: Using QA Community, you will be researching and attempting the implementation of Class Properties.
//You can find the module under C# Intermediate -> Class Properties

//    Auto-implemented Exercises:
//Create an `Item` class with the following fields:
//NamePriceBarcodeNo
//2.Convert each of the regular fields to auto implemented properties

//    Properties backed by a field Exercises:
//Convert the `Price` auto implemented property on the `Item` class to a public property backed by a private field.In the `Price` property’s set accessor, validate that the price is greater than 0 before setting it. If it is 0 or less, use the instruction: 
//`throw new Exception(“Price MUST BE greater than 0!”);`.
//Test the Price fields validation with the following values:
//39
//12
//1
//0 
//- 1
//- 15

//Expression Body Definition Exercise

//Convert the BarcodeNo field to a property backed by a field that uses get and set expression-bodied members.
