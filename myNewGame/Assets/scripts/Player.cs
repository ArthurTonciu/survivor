using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;



public class Player : MonoBehaviour
{
    public float hp = 1;
    public Image HP_bar;
    public bool dubinka= false;
    public Image fireImg;
    public bool isAttack = false;
    public Image enemyHPBar;
    public Text enemyName;
    public bool dead = false;
    public GameObject DeadMenu;

    // Start is called before the first frame update

    

    public void  Damage(float dmg)
    {
        hp -= dmg;
    }
    // Update is called once per frame
    void Update()
    {
        if (hp > 1)
        {
            hp = 1;
        }
        HP_bar.fillAmount = hp;

        if(gameObject.GetComponent<Animation>().isPlaying)
        {
            isAttack = false;
            dubinka = false;

        }
        if (hp <= 0)
        {
            if (!dead)
            {
                Camera.main.transform.parent = null;
                gameObject.GetComponent<CharacterController>().enabled = false;
                this.enabled = false;
                Camera.main.GetComponent<SphereCollider>().enabled = true;
                Camera.main.GetComponent<Rigidbody>().isKinematic = false;
                Camera.main.GetComponent<Rigidbody>().AddForce(new Vector3(21, 12, 10));
                Destroy(this.gameObject);
                dead = true;
                DeadMenu.SetActive(true);
            }
        } 
        
    }


    public void Animation()
    {
        if (!gameObject.GetComponent<Animation>().isPlaying)
        {
            gameObject.GetComponent<Animation>().Play();
            isAttack = true;
            dubinka = true;
        }

    }


    public void ActiveBlick()
    {
        StartCoroutine(Blick());
    }

    IEnumerator Blick()
    {
        fireImg.enabled = true;
        yield return new WaitForSeconds(0.15f);
        fireImg.enabled = false;
    }

}
