using UnityEngine;
using System;
namespace PizzaN
{
    public class Pizza
    {
        public static int pizzaCount = 3;
        public double CookSpeed { get; set; }
        public double Cost { get; set; }
        private static double _pop;
        public double Pop
        {
            get
            {
                return _pop;
            }
            set
            {
                if (value < 1.0)
                {
                    _pop = value;
                }
                else
                {
                    throw new Exception("Pop must be < 1");
                }
            }
        }
    }
}