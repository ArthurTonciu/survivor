using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap_dmg : MonoBehaviour
{
    Player player;
    public Animation anim;
    public bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("P").GetComponent<Player>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (!active && col.name =="P")
        {
            anim.Play();
            player.Damage(0.2f);
            active = true;
        }  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
