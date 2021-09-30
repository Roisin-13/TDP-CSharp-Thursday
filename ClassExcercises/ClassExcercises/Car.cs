using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExcercises
{


    //Create a class called Car
    //Give your class 3 fields:
    //manufacturer
    //model
    //dateManufactured
    // 3.  Add a GetInfo() instance method which returns information as a string about the car object
    // 4. Instantiate an instance of Car and set its fields 
    // 5. Call the GetInfo() method on your car instance, store its result in a 
    //variable and then print that variable to the console
    class Car
    {
        public string manufacturer;
        public string model;
        public string dateManufactured;

        public Car(string manufacturer, string model, string dateManufactured)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.dateManufactured = dateManufactured;
        }

        public Car()
        {
        }

        public void GetInformation()
        {
            Console.WriteLine($"The car is {model}, made by: {manufacturer} in {dateManufactured}.");
        }

        public string GetInfo()
        {
            return $"{model} car, is made by: {manufacturer} in {dateManufactured} year.";
        }


    }





}
