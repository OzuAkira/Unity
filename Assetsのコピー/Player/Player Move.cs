using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Processors;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 _velocity;
    public float MoveSpeed;
    public GameObject BulletObj;
    public GameObject wall_1;
    public GameObject wall_2;
    public vector2 new_velocity;

    // bool w_cld = false;
    // bool h_cld = false;

    Vector3 bulletPoint;
    Vector3 secondPoint;

    void strat()
    {
       bulletPoint = transform.Find("BulletPoint").localPosition;
        
      // secondPoint = transform.Find("SecondPoint"+(-3,0,0)).localPosition;
       // Coroutine coroutine = StartCoroutine("DelayMethod", 1.0f);
     //   GetComponent<AudioChorusFilter>().delay = 1.5f;
        //Invoke("Instantiate", 10);
    }


    private void OnMove(InputValue value)
    {
        var axis = value.Get<Vector2>();
        Vector2 kbe1 = wall_1.transform.position;
        Vector2 kabe2 = wall_2.transform.position;
        //  slowMode = false;
        _velocity = new Vector3(axis.x, axis.y, 0);
       // _velocity.x = Mathf.Clamp(_velocity.x, kbe1.x, kabe2.x);
        //_velocity.y = Mathf.Clamp(_velocity.y, kbe1.x, kabe2.x);

    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wale"))
        {
            _velocity.x = Mathf.Clamp(_velocity.x,0,1);
            Debug.Log(Time.deltaTime);
        }
    }

    private int shotCount = 0;
    private int shotCount_2 = 0;

    //private void OnShot(InputValue value)
    //{

    //}

    // private void OnSlow(InputValue value)
    //{
    // slowMode = true;
    //}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += _velocity  * Time.deltaTime * MoveSpeed  /2; //Debug.Log(axis);
        }
        else
        {
            transform.position += _velocity * Time.deltaTime * MoveSpeed;
        }
       /* if (Input.GetKey(KeyCode.Space))
        {
            updateTime();
        }*/
        
        
            S_Count();
        
      // Debug.Log(velo);
        
        
    }
  //  public IEnumerator DelayMethod(float delay)
    //{
       // yield return new WaitForSeconds(delay);
       
  //  }
    public void updateTime()
    {

        Instantiate(BulletObj, transform.position + bulletPoint, Quaternion.identity);
        //Instantiate(BulletObj, transform.position + secondPoint, Quaternion.identity);
        //Debug.Log("SC=" + shotCount_2);
       // shotCount_2++;
    }
    public void S_Count()
    {
        if (shotCount == 1)
        {
            updateTime();
            shotCount_2++;
        }
        if (shotCount == 101)
        {
            shotCount = 0;
        }
        if (shotCount_2 <= 7 && shotCount < 70 && shotCount != 0)
        {
            shotCount = 71;
        }
        if (shotCount_2 == 5 && shotCount == 100)
        {
            shotCount_2 = 0;
            shotCount = 0;
        }
        shotCount++;
    }
    

}
