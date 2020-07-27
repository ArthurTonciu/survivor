using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class key : MonoBehaviour
{
    Text curKeys;
    Transform Player;
    public float Dist = 3;

    // Start is called before the first frame update

    void Start()
    {
        curKeys = GameObject.Find("CKG").GetComponent<Text>();
        Player = GameObject.Find("P").transform;

    }

    void OnMouseDown()
    {
        if (Vector3.Distance(Player.position, gameObject.transform.position) < Dist)
        {
            curKeys.text = (int.Parse(curKeys.text) + 1).ToString();
            Destroy(gameObject);
        }
    }
}
    
