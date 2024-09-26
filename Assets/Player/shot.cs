using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    public float speed = 7.0f;
    public GameObject buletObj;
    private int shot_count = 0;
    Vector3 bulletPoint;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        bulletPoint = transform.Find("BulletPoint").localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        shot_count++;
        Power P_script = gameObject.GetComponent<Power>();
        if(Input.GetKey(KeyCode.Z) && shot_count%10 == 0){
            if(P_script.P < 2)
            {
                Instantiate(buletObj,transform.position + bulletPoint,Quaternion.identity);
            }
            if(P_script.P >= 2)
            {
                Instantiate(buletObj,transform.position + bulletPoint,Quaternion.Euler(0,0,2.5f));
                Instantiate(buletObj,transform.position + bulletPoint,Quaternion.Euler(0,0,-2.5f));
            }
        }
    }

}

