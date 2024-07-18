using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//public class Player : MonoBehaviour; 

public class MoveSpeed : MonoBehaviour
{
    public float MoveSpeeda = 20.0f;
    // Start is called before the first frame update

    const float deleteDistance = 100;   // 削除距離
    GameObject playerObj = null;


    void Start()
    {
        transform.Rotate(0, 0, 90);
        playerObj = GameObject.Find("player");
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(MoveSpeeda * Time.deltaTime, 0, 0);
        float distance = (playerObj.transform.position - transform.position).sqrMagnitude;

        // 一定の距離が離れたら消す
        if (distance > deleteDistance)
            Destroy(gameObject);

        //Debug.Log("x=" + BulletObj.Transform.position.x);
        // 一定の距離が離れたら消す
        //if (bulletposition > deleteDistance)
        //{
        //  Destroy(gameObject);
        //}

    }
}
