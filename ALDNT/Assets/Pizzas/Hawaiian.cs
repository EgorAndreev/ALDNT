using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PizzaN
{
    public class Hawaiian : Pizza
    {
        public Hawaiian()
        {
            Cost = 5.49;
            Pop = 1 / pizzaCount;
            CookSpeed = 0.06;
        }
    }
}