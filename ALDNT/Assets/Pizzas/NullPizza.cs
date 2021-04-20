using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PizzaN
{
    //Ётот класс €вл€етс€ стандартным наследником класса Pizza и предназначен дл€ сбора его статических значений
    //ѕожалуйста, не используйте его, если не указано иное
    public class NullPizza : Pizza
    {
        public NullPizza()
        {
            pizzaCount = base.pizzaCount;
            Cost = 0;
            Pop = 0;
            CookSpeed = 0;
        }
    }
}