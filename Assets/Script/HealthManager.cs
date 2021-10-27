using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthManager : MonoBehaviour
{
    public static bool isGameOver;
    public Text enemytext;
    public static int dNumber;
    
 public static HealthManager singleton;
     public void Start()
    {
      //  ss = 0;
        singleton = this;
       
        dNumber = 0;
        
        isGameOver = false;
        enemytext.text = "Enemy:  " + dNumber;
    }

    public void Update()
    {

       
        enemytext.text = "Enemy:  " + dNumber;
    }

 public static void TakeDamag(int Amount)
    {
        dNumber += Amount;
        

    }

}
