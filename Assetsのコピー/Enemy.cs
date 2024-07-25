using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public int enemyHP = 1000;
   // public Vector2 = 
    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // 当たったのがプレイヤーの弾
        if (other.gameObject.CompareTag("player_bullet"))
        {
            if (enemyHP <= 0)
            {
                // 自身を消す
                Destroy(gameObject);
            }

            enemyHP--;
            // 弾も消す
            Destroy(other.gameObject);
        }
    }
}