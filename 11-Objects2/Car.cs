﻿/// File: Car.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace CISP1010
{
    /// <summary>
    /// Models a Car object
    /// </summary>
    internal class Car
    {
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="color">The color of the Car</param>
        /// <param name="make">The make of the Car</param>
        /// <param name="model">The model of the Car</param>
        /// <param name="price">The price of the Car</param>
        public Car(string color, string make, string model, double price)
        {
            this.Color = color;
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }
    }
}
