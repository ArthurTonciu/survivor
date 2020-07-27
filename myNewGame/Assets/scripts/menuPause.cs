using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuPause : MonoBehaviour
{
    public GameObject PausePnl;
    public GameObject GamePnl;
    public bool pause;
    public string menuLevel;
    public string FirstLevel;
    // Start is called before the first frame update


    void Start()
    {
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        GamePnl.SetActive(false);
        PausePnl.SetActive(true);
        Time.timeScale = 0.001f;
        pause = true;
    }

    public void UnPause()
    {
        Time.timeScale = 1f;
        GamePnl.SetActive(true);
        PausePnl.SetActive(false);
        pause = false;
    }

    
    public void Restart()
    {
        Application.LoadLevel(FirstLevel);
    }



    // Update is called once per frame
    void Update()
    {
        
    }


    public void Menu()
    {
    Application.LoadLevel(menuLevel);
    }
}
