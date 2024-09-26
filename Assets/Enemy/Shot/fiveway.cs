using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class fiveway : MonoBehaviour
{
    private float timer = 0;
    private int frame = 0;
    public GameObject bulletObj;
    private GameObject bullet;
    private Vector3 L_bullet = new Vector3(-1,0,0);
    private Vector3 leftbullet= new Vector3(-0.5f,-0.5f,0);
    private Vector3 center_bullet= new Vector3(0,-1,0);
    private Vector3 rightbullet= new Vector3(0.5f,-0.5f,0);
    private Vector3 R_bullet= new Vector3(1,0,0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        frame++;
        timer += Time.deltaTime;
        if(timer >= 18 && frame%120 == 0)
        {
            Shot();
            //bullet.transform.position;
        }
    }
    async void Shot()
    {
        for(int i=0;i<5;i++)
        {
            Instantiate(bulletObj,gameObject.transform.position + L_bullet,Quaternion.Euler(0,0,-20));
            Instantiate(bulletObj,gameObject.transform.position + leftbullet,Quaternion.Euler(0,0,-10));
            Instantiate(bulletObj,gameObject.transform.position + center_bullet,Quaternion.Euler(0,0,0));
            Instantiate(bulletObj,gameObject.transform.position + rightbullet,Quaternion.Euler(0,0,10));
            Instantiate(bulletObj,gameObject.transform.position + R_bullet,Quaternion.Euler(0,0,20));
            Debug.Log(i);
            await Task.Delay(5000);
        }   
    }
}
