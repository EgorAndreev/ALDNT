using UnityEngine;
using System;
using System.Linq;
namespace PizzaN
{
    public class Pizza
    {
        public double Cost { get; set; }
        private double _pop;
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