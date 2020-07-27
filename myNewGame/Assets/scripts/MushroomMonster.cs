using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
//using System.Media;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class MushroomMonster : MonoBehaviour
{
    public int activeDist;
    public int atackDist;
    public bool active;
    public bool attack;
    public int hp;
    public Animation genAnim;
    public int damage;
    public GameObject player;
    public int speed;
    Animation anim;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("P");
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!active && anim.clip.name != "Idle" && !attack)
        {
            anim.Play("Idle");
        }


        if (active && anim.clip.name != "Run" && !attack)
        {
            anim.Play("Run");
        }

        if (active && attack && anim.clip.name != "Attack")
        {
            anim.Play("Attack");
        }


        float D = Vector3.Distance(player.transform.position, gameObject.transform.position);
        if (D < activeDist && D > atackDist)
        {
            transform.LookAt(player.transform.position);
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
            active = true;
        }
        if (D > activeDist)
        {
            active = false;
        }
        if (D > atackDist)
        {
            attack = false;
        }
        if (D < atackDist)
        {
            transform.LookAt(player.transform.position);
            attack = true;
        }
    }
}
