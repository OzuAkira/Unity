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
        // ���������̂��v���C���[�̒e
        if (other.gameObject.CompareTag("player_bullet"))
        {
            if (enemyHP <= 0)
            {
                // ���g������
                Destroy(gameObject);
            }

            enemyHP--;
            // �e������
            Destroy(other.gameObject);
        }
    }
}