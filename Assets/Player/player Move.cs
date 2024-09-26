using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMove : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 _velocity;
    Vector3 stoper;
    GameObject resPos;
    float move_speed = 3.7f;
    void Start()
    {
        resPos = GameObject.Find("Player_Resurrection");
    }

    void OnMove(InputValue value)
    {
        var axis = value.Get<Vector2>();
        _velocity = new Vector2(axis.x,axis.y);
    }

    // Update is called once per frame
    

    void lowSpeed()
    {
        move_speed = 3.7f;
        if (Input.GetButton("Fire1")){
            move_speed = 2.5f;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        //Debug.Log("coll");        
         if (other.gameObject.CompareTag("Enemy_bullet") || other.gameObject.CompareTag("Enemy")){
//            Debug.Log("bullet");
            resurrection script = resPos.GetComponent<resurrection>();
            if(script.dieFlag == false){
                gameObject.SetActive(false);
            }
        }
    }

    void Update()
    {
        lowSpeed();
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = _velocity * move_speed;
        if (gameObject.activeSelf == false){
            _velocity = new Vector2(0,0);
        }
    }
   /* public void move_lim(Vector2 input_velocity,float input_Mspeed){
        input_velocity = _velocity;
        input_Mspeed = move_speed;
    }*/
}
