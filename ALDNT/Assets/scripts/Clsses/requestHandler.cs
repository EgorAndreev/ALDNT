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
        public GameObject target3;
        private static Request tempElem;
        public static int productsCount = 0;
        public static Queue<Request> requestQueue = new Queue<Request>();
        
        void Start()
        {
            Debug.Log(Shop.balance);
        }
    
        void Update()
        {
            System.Math.Round(Shop.balance, 2);
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
                requestgen.DelMe?.Invoke();
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
