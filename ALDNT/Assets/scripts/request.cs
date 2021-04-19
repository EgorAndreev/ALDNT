using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace PizzaN
{

    public class Request
    {
        public Pizza Margarita = new Pizza();
        public Pizza Marinara = new Pizza();
        public Pizza Hawaiian = new Pizza();
        void Gen()
        {
            //MENU:
            //Marinara
            //Margarita
            //Hawaiian
            System.Random rand = new System.Random();
            double MarinaraVar = rand.Next(-10, 10);
            double MargaritaVar = rand.Next(-10, 10);
            double HawaiianVar = rand.Next(-10, 10);
            MargaritaVar += Margarita.Pop;
        }
    }
}