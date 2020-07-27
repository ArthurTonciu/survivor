using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class doorV : MonoBehaviour
{
    public GameObject[] keys;
    public Text CKV;
    public Transform Player;
    public float Dist = 5;
    public bool openD = false;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        if (Vector3.Distance(Player.position, gameObject.transform.position) < Dist)
        {
            int keysC = int.Parse(CKV.text);
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
            if (keys[0].activeSelf == true)
            {
                gameObject.GetComponent<Animation>().Play();
                openD = true;
            }
        }
    }
}
