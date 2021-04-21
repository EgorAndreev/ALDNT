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
            SceneManager.LoadScene("you lose", LoadSceneMode.Additive);
        }
    }
}