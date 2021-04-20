using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace PizzaN
{
    public class GeneralCount : MonoBehaviour
    {
        public GameObject CustomersCount;
        public GameObject ChefCount;
        public GameObject CashCount;
        public GameObject AdsCount;
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            CustomersCount.GetComponent<Text>().text = " Customers: " + requestgen.requestCount.ToString();
            ChefCount.GetComponent<Text>().text = " Chefs: " + Shop.chef_count.ToString();
            CashCount.GetComponent<Text>().text = " Cashier lvl: " + Shop.cashier_mp.ToString();
            AdsCount.GetComponent<Text>().text = " Ads: " + Shop.ad_mp.ToString();
        }
    }
}
