using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIHandler : MonoBehaviour
{

   public  void onRestart()
    {
        SceneManager.LoadScene("SampleScene");
    }

   public void OnExit()
    {
        Application.Quit();
    }
}
