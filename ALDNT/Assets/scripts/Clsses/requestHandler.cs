using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
namespace PizzaN
{
    public class requestHandler : MonoBehaviour
    {
        private double second = 1;
        private const double speed = 0.06;
        private bool flag = false;
        private double Progress = 0;
        private static Request tempElem;

        public static Queue<Request> requestQueue = new Queue<Request>();

        void Start()
        {

        }

        void Update()
        {
            second -= Time.deltaTime;
            if (requestQueue.Any() && flag == false)
            {
                tempElem = requestQueue.Peek();
                flag = true;
                second = 1;
            }

            if (flag)
            {
                Progress += (speed * Shop.chef_count - tempElem.pizzaSpeed);
            }
            //TODO: Закончить обработчик очереди и подцепить к кухне
        }


    }
}
