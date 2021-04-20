using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace PizzaN
{
    public class requestgen : MonoBehaviour
    { 
        private const double speed = 0.05;
        private double Progress = 0;
        private double second = 1;
        private int requestCount = 0;
        public short MaxRequestCount = 6;
        System.Random rand = new System.Random();
        // TODO: �������� ��������� ������� ��������� � ��������� �������
        void Start()
        {
        }

        // ������ ������ ����
        void Update()
        {
            second -= Time.deltaTime;

            if (second <= 0)
            {
                double offset = rand.Next(0, 10);
                Progress += (speed * Shop.ad_mp + offset/100); //��������� ������� � ������ ����������
                second = 1;
                //Debug.Log(offset);
                //Debug.Log(Progress);

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
        }

        Request genRequest()
        {
            Hawaiian havaiian = new Hawaiian();
            Margarita margarita = new Margarita();
            Marinara marinara = new Marinara();
            //NullPizza ������������ ��� ��������� pizzaCount ��� ����������� �� ������ �������� ������ Pizza
            NullPizza nullpizza = new NullPizza();
            //���� �� �������: ���������, ���������, �������� !!!��������: ������������ ������ � ����� �������
            double pizzaRandom = Math.Round(rand.NextDouble(), 2);
            if (pizzaRandom <=  havaiian.Pop) {
                havaiian.Pop -= (nullpizza.pizzaCount - 1) / 100;
                margarita.Pop += 0.01;
                marinara.Pop += 0.01;
                Request newRequest = new Request(havaiian);
                return newRequest;
            }
            else if (pizzaRandom > havaiian.Pop && pizzaRandom <= (havaiian.Pop + margarita.Pop)) {
                havaiian.Pop += 0.01;
                margarita.Pop -= (nullpizza.pizzaCount - 1) / 100;
                marinara.Pop += 0.01;
                Request newRequest = new Request(margarita);
                return newRequest;
            }
            else {
                havaiian.Pop += 0.01;
                margarita.Pop += 0.01;
                marinara.Pop -= (nullpizza.pizzaCount-1) / 100;
                Request newRequest = new Request(marinara);
                return newRequest;
            }
        }
    }
}