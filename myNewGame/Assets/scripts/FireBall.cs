using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("P") != null)
        {
            player = GameObject.Find("P").GetComponent<Player>();
        }
    }

    void OnTriggerEnter(Collider col)
    {
      if(col.name == "P")
        {
            player.Damage(0.05f);
            player.ActiveBlick();
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
