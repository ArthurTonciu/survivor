using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class door : MonoBehaviour
{
    public GameObject[] keys;
    public Text CKG;
    public Transform Player;
    public float Dist = 5;
    public bool openD = false;

    
    // Start is called before the first frame update
    void OnMouseDown()
    {
        if(Vector3.Distance(Player.position,gameObject.transform.position)<Dist)
        {
            int keysC = int.Parse(CKG.text);
            for (int i = 0; i < keysC; i++)
            {
                keys[i].SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (openD == false)
        {
            if (keys[4].activeSelf == true)
            {
                gameObject.GetComponent<Animation>().Play();
                openD = true;
            }
        }
    }
}
