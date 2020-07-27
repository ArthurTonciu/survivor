using System.Collections;
using System.Collections.Generic;
//using System.Runtime.Hosting;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public string nextLevel;


    void Start()
    {
        Time.timeScale = 1f;
    }


    public void NewGame()
    {
        Application.LoadLevel(nextLevel);
    }

    public void Continue()
    {

    }

    public void Exit()
    {
        Application.Quit();
    }
}
