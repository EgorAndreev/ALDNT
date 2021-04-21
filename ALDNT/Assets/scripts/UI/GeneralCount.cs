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
        public GameObject Balance;
        public GameObject PopUp;
        public GameObject PopUpText;
        public GameObject Products;
        private Vector2 newPos;
        private Vector2 oldPos;
        private bool open = false;
        private static bool popUpFlag = false;
        private double seconds = 2.0;
        
        void Start()
        {
            oldPos = new Vector2(PopUp.transform.localPosition.x, PopUp.transform.localPosition.y);
            newPos = new Vector2(PopUp.transform.localPosition.x + 1000, PopUp.transform.localPosition.y);
        }

        // Update is called once per frame
        void  Update()
        {
            CustomersCount.GetComponent<Text>().text = " Customers: " + requestgen.requestCount.ToString();
            ChefCount.GetComponent<Text>().text = " Chefs: " + Shop.chef_count.ToString();
            CashCount.GetComponent<Text>().text = " Cashier lvl: " + Shop.cashier_mp.ToString();
            AdsCount.GetComponent<Text>().text = " Ads: " + Shop.ad_mp.ToString();
            Products.GetComponent<Text>().text = " Products: " + requestHandler.productsCount.ToString();
            Balance.GetComponent<Text>().text = Shop.balance + "$";
            
            if (popUpFlag)
            {
                PopUpText.GetComponent<Text>().text = "Expenses: " + Shop.expenses;
                PopUp.transform.localPosition = newPos;
                open = true;
            }
            if (open){
                seconds -= Time.deltaTime;
                Debug.Log(open);
                if (seconds <= 0)
                {
                    popUpFlag = false;
                    open = false;
                    seconds = 2;
                    PopUp.transform.localPosition = oldPos;
                }
                
            }
            

        }
        public static void ExEventHandler() {
            popUpFlag = true;
            
        }
    }

}
