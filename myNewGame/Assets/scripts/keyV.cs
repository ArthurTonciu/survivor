using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class keyV : MonoBehaviour
{
    Text curKeys;

    // Start is called before the first frame update

    void Start()
    {
        curKeys = GameObject.Find("CKV").GetComponent<Text>();
    }

    void OnMouseDown()
    {
        curKeys.text = (int.Parse(curKeys.text) + 1).ToString();
        Destroy(gameObject);
    }


}