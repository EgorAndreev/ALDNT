using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PizzaN
{
    public class Marinara : Pizza
    {
        public Marinara() 
        {
            Cost = 3.49;
            Pop = 1 / pizzaCount;
            CookSpeed = 0.04;
        }
    }
}