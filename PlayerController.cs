using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed;    // 移動値

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame

    float add_x;
    float add_y;
    void Update()
    {
        //if (Input.GetAxisRaw("Horizontal") != 0 && Input.GetAxisRaw("Vertical") != 0)
        
            // 横(�])方向の入力
            float fHorizontalInput = Input.GetAxisRaw("Horizontal");
            // 縦(Ｙ)方向の入力
            float fVerticalInput = Input.GetAxisRaw("Vertical");
        

        if (Input.GetButton("space"))
        {
                add_x = fHorizontalInput * MoveSpeed / 2;
                add_y = fVerticalInput * MoveSpeed / 2;
                transform.Translate(add_x, add_y, 0);
                //Debug.Log("horaizontal=" + fHorizontalInput);
                // Debug.Log("vertica=" + fVerticalInput);s

        }

        else{ 
            // 位置を更新
            add_x = fHorizontalInput * MoveSpeed;
            add_y = fVerticalInput * MoveSpeed;
            transform.Translate(add_x, add_y, 0);
            //Debug.Log("horaizontal=" + fHorizontalInput);
            //Debug.Log("vertica=" + fVerticalInput);
            }
        //Debug.Log("Key Code d =" + Input.GetKey(KeyCode.D));
        //void Move_B();
        
    }

}