using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 0.7f;
    public GameObject BulletObj;

    Vector3 bulletPoint;

    void strat()
    {
        bulletPoint = transform.Find("BulletPoint").localPosition;
    }

    void Update()
    {
        
        if (Input.GetButton("space"))
        {
            if (Input.GetButton("Shot"))
            {
                Instantiate(BulletObj, transform.position + bulletPoint, Quaternion.identity);
            }
        }
        if (Input.GetButtonDown("Shot"))
        {
            //Debug.Log("a");
            Instantiate(BulletObj,transform.position + bulletPoint,Quaternion.identity);
        }
       
    }
}