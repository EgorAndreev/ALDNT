using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PizzaN
{
    //���� ����� �������� ����������� ����������� ������ Pizza � ������������ ��� ����� ��� ����������� ��������
    //����������, �� ����������� ���, ���� �� ������� ����
    public class NullPizza : Pizza
    {
        public NullPizza()
        {
            pizzaCount = base.pizzaCount;
            Cost = 0;
            Pop = 0;
            CookSpeed = 0;
        }
    }
}