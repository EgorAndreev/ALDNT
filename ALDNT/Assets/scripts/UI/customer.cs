using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PizzaN
{
    public class customer : MonoBehaviour
    {
        public GameObject[] Customers = new GameObject[5];
        private bool flag = false;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (flag)
            {
                CustomerGo();
            }
            CustomerGo();
        }
        void CustomerGo()
        {
            System.Random rand = new System.Random();
            int customerName = rand.Next(0, 5);
            Instantiate(Customers[customerName]);
            flag = false;
        }
        void CustomerAnim() {
            flag = !flag;
        } 
    }
}