using UnityEngine;
using System;
using System.Linq;
namespace PizzaN
{
    public class Pizza
    {
        public double Cost { get; set; }
        private string _type;
        public string Type {
            get {
                return _type;
            }
            set {
                string[] types = new string[] { "margarita", "hawaiian", "marinara" };
                if (types.Any(str => str == value)) {
                    _type = value;

                }
                else {
                    throw new Exception("You are an idiot!");
                }
            }
        }
        private float _pop;
        public float Pop
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