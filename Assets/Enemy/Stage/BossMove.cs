using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    private float A = 0;
    private float B = 60;
    //private int C = 0;
    private float Sin;
    private float Cos;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Sin = Mathf.Sin(A);
        Cos = Mathf.Cos(B);
        
        A += 0.01f;
        B += 0.01f;
        if(timer >= 6 && timer < 16)
        {
            gameObject.transform.position += new Vector3(Sin , 1+Cos , 0);
        }
        if(timer >= 17 && timer < 27)
        {
            //Debug.Log("Chenge!");
            gameObject.transform.position = new Vector3(Cos , Sin+1 , 0);
        }
        Debug.Log("Sin="+Sin + "Cos=" + Cos);
    }
}
