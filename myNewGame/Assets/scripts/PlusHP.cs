using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusHP : MonoBehaviour
{
    Player player;
    public float hpPLUS;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("P").GetComponent<Player>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "P")
        {
            player.hp += hpPLUS;
            Destroy(gameObject);
        }
    }

}