using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace PizzaN
{
    public class chngScene : MonoBehaviour
    {


        void Start()
        {
        }
        void Update()
        {
            if (Shop.balance <= 0)
            {
                Shop.balance = 1;
                LoadGame();
            }
        }

        void LoadGame()
        {
            SceneManager.LoadScene("you lose");
        }
        public void LoadMain()
        {
            SceneManager.LoadScene("main");
        }
        public void LoadTwoMain()
        {
            SceneManager.LoadScene("main2");
        }
        public void LoadThreeMain()
        {
            SceneManager.LoadScene("main3");
        }
    }
}