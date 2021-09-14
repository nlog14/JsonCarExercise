using System;
using System.Xml.Schema;

namespace JsonCarExercise
{
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public string registrationNumber { get; set; }

        public Car()
        {

        }


        public Car(string Model, string Color, string registrationNumber)
        {
            this.Model = Model;
            this.Color = Color;
            this.registrationNumber = registrationNumber;
        }
    }
}
