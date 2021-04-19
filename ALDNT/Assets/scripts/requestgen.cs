using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace PizzaN
{
    public class requestgen : MonoBehaviour
    {
        private const double speed = 0.05;
        public double ad = 1;
        private double Progress = 0;
        private double second = 1;
        private int requestCount = 0;
        public short MaxRequestCount = 6;
        System.Random rand = new System.Random();
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            second -= Time.deltaTime;

            if (second <= 0)
            {
                double offset = rand.Next(-10, 10);
                Progress += (speed * ad + offset/100); //генерация рандома в мозгах покупателя
                second = 1;
                Debug.Log(Progress);

            }
            if (Progress >= 1.0)
            {
                if (requestCount < MaxRequestCount)
                {
                    requestCount += 1;
                    
                }
                Progress = 0.0;
                Debug.Log(requestCount);
            }
        }
    }
}