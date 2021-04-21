using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace PizzaN
{
    public class requestgen : MonoBehaviour
    { 
        private const double speed = 0.04;
        private double Progress = 0;
        private double second = 1;
        private double daySecond = 1;
        private int daySecCounter = 480;
        public static int requestCount = 0;
        public short MaxRequestCount = 6;
        public delegate void ExPopUp();
        event ExPopUp ExEvent;
        System.Random rand = new System.Random();
        void Start()
        {
            ExEvent += GeneralCount.ExEventHandler;
        }

        // Запуск каждый кадр
        void Update()
        {
            second -= Time.deltaTime;

            if (second <= 0)
            {
                double offset = rand.Next(0, 10);
                Progress += (speed * Shop.ad_mp + offset/100); //генерация рандома в мозгах покупателя
                second = 1;

            }
            if (Progress >= 1.0)
            {
                if (requestCount < MaxRequestCount)
                {
                    requestCount += 1;
                    requestHandler.requestQueue.Enqueue(genRequest());
                }
                Progress = 0.0;
                Debug.Log(requestCount);
            }

            daySecond -= Time.deltaTime;

            if (daySecond <= 0)
            {
                daySecCounter--;
                daySecond = 1;
            }

            if (daySecCounter == 0)
            {
                Shop.balance -= Shop.expenses;
                daySecCounter = 480;
                ExEvent?.Invoke();
                Debug.Log(Shop.balance);
            }
        }

        Request genRequest()
        {
            Hawaiian havaiian = new Hawaiian();
            Margarita margarita = new Margarita();
            Marinara marinara = new Marinara();
            //Меню по порядку: Гавайская, Маргарита, Маринара !!!ВНИМАНИЕ: использовать только в таком порядке
            double pizzaRandom = Math.Round(rand.NextDouble(), 2);
            if (pizzaRandom <=  havaiian.Pop) {
                havaiian.Pop -= (Pizza.pizzaCount - 1) / 100;
                margarita.Pop += 0.01;
                marinara.Pop += 0.01;
                Request newRequest = new Request(havaiian);
                return newRequest;
            }
            else if (pizzaRandom > havaiian.Pop && pizzaRandom <= (havaiian.Pop + margarita.Pop)) {
                havaiian.Pop += 0.01;
                margarita.Pop -= (Pizza.pizzaCount - 1) / 100;
                marinara.Pop += 0.01;
                Request newRequest = new Request(margarita);
                return newRequest;
            }
            else {
                havaiian.Pop += 0.01;
                margarita.Pop += 0.01;
                marinara.Pop -= (Pizza.pizzaCount-1) / 100;
                Request newRequest = new Request(marinara);
                return newRequest;
            }
        }
    }
}