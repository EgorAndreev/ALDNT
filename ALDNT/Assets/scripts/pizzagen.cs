using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PizzaN;
public class pizzagen : MonoBehaviour
{
    private const double speed = 0.07;
    public int chef = 1;
    private double Progress;
    private double second = 1 ;
    private int pizzaCount = 0;
    public short MaxPizzaCount = 6;
    public Pizza[] pizzaDone = new Pizza[6];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        second -= Time.deltaTime;

        if (second <= 0) {
            Progress += speed * chef;
            second = 1;
        }
        if (Progress >= 1.0) {
            if (pizzaCount < MaxPizzaCount)
//TODO: Заменить строчку на генерацию пиццы в зависимости от заказа
//Создать генератор заказов в зависим
            {
                pizzaCount += 1;
            }
            Progress = 0.0;
            Debug.Log(pizzaCount);
        }
        
    }
}
