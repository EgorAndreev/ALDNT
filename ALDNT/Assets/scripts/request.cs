using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace PizzaN
{

    public class Request
    {
        public double cost;
        public double pizzaSpeed;
        public Request(Pizza pizza)
        {
            this.cost = pizza.Cost;
            this.pizzaSpeed = pizza.CookSpeed;
        }
    }
}