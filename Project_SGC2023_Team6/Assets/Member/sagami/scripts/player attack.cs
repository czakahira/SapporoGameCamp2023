using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerattack : MonoBehaviour
{
    public GameObject prefabBullet;
    public Transform bulletPoint;

    public void Attack()
    {
        Instantiate(prefabBllet,bulletPoint.position,bulletPoint.rotation);
    }

    // Update is called once per frame

   
}