using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
namespace PizzaN
{
    public class requestHandler : MonoBehaviour
    {
        private static double second = 1;
        private const double speed = 0.06;
        private static bool flag = false;
        private static double Progress = 0;
        private static Request tempElem;
        public static int productsCount = 0;
        public static Queue<Request> requestQueue = new Queue<Request>();
        public delegate void DelCustomer();
        public event DelCustomer DelMe;
        void Start()
        {
            Debug.Log(Shop.balance);
            DelMe += requestgen.DelMeH;
        }
    
        void Update()
        {
            Shop.balance = System.Math.Round(Shop.balance, 2);
            second -= Time.deltaTime;
            if (requestQueue.Any() && flag == false)
            {
                tempElem = requestQueue.Dequeue();
                flag = true;
                second = 1;
                productsCount = 1;
            }

            if (flag && second<=0)
            {
                Progress += (speed * Shop.chef_count - tempElem.pizzaSpeed);
                second = 1;
            }

            if (Progress >= 1)
            {
                DelMe?.Invoke();
                Progress = 0;
                flag = false;
                Shop.balance += tempElem.cost;
                requestgen.requestCount -= 1;
                productsCount = 0;
                //Debug.Log(Shop.balance);
            }
        }


    }
}
