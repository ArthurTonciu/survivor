using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class RotationsObj : MonoBehaviour
{
    public Vector3 Dirrection;
    public float speed;
    

    
    void Update()
    {
        transform.Rotate(Dirrection * Time.deltaTime * speed);
    }
}
