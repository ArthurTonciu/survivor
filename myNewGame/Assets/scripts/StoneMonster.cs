using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
//using System.Media;
//using System.Media;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class StoneMonster : MonoBehaviour
{
    public string E_name;
    public int activeDist;
    public int atackDist;
    public bool active;
    public bool attack;
    public float hp;
    public float maxHP;
    public Animation genAnim;
    public int damage;
    Player ply; 
    public GameObject player;
    public int speed;
    public Transform ball;
    public Transform InstPlace;
    public int F_force;
    public float delay;
    public bool isFire = false;
    public int hitDist;
    public int hitForce;
    Animation anim;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("P");
        ply = player.GetComponent<Player>();
        anim = GetComponent<Animation>();
    }

    public void PLAttack()
    {
        if (!ply.dead) { 
            if (Vector3.Distance(player.transform.position, gameObject.transform.position) < hitDist)
        {
                if (ply.isAttack)

                {
                    ply.enemyHPBar.gameObject.SetActive(true);
                    anim.Play("Anim_Damage");
                    gameObject.GetComponent<Rigidbody>().AddForce(player.transform.forward * hitForce);
                    hp = hp - 30;
                    ply.enemyName.text = E_name;
                    ply.enemyHPBar.fillAmount = (hp / maxHP);
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (!ply.dead)
        {
            if (!active && anim.clip.name != "Anim_Idle" && !attack)
            {
                anim.Play("Anim_Idle");
            }


            if (active && anim.clip.name != "Anim_Run" && !attack)
            {
                anim.Play("Anim_Run");
            }

            if (active && attack && anim.clip.name != "Anim_Attack")
            {
                anim.Play("Anim_Attack");
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
                if (!isFire)
                {
                    StartCoroutine(Fire());
                }
            }
            if (hp <= 0)
            {
                gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                anim.Play("Anim_Death");
                this.enabled = false;
            }
        }
        //if(active = false )
        //{
            // ply.enemyHPBar.gameObject.SetActive(false);
        //}
    }


    IEnumerator Fire()
    {
        isFire = true;
        yield return new WaitForSeconds(delay);
        SpawnFire();
        isFire = false;
    }


    void SpawnFire()
    {
        Transform b = (Transform)GameObject.Instantiate(ball, InstPlace.position,Quaternion.identity);
        b.GetComponent < Rigidbody>().AddForce(InstPlace.forward*F_force);
    }
}
