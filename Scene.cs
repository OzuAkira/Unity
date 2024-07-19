using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace unseen
{
    public class Sene : MonoBehaviour
    {
       // public GameObject Obj;
        public GameObject player;
        public GameObject bulia;
        // Start is called before the first frame update
        void Start()
        {
            // player = GameObject.Find("player");

        }
        public int Extend = 2;
        public int dieframe = 0;
        public bool dieflag = false;
        public int livefram = 0;

        // Update is called once per frame
        public void OnTriggerEnter2D(Collider2D other)
        {
            //var player = GameObject.Find("player");
            if (livefram >= 600)
            {
                
                bulia.SetActive(true);
                if (livefram % 10 == 0 )
                {
                    bulia.SetActive(false);
                }
                if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("enemy_Bullet"))
                {
                    if (Extend <= 0)
                    {
                        StartCoroutine(LoadScene());
                    }
                    else
                    {
                        Extend--;
                        die();
                        //Instantiate(Obj);


                    }
                }
                
                else
                {
                    bulia.SetActive(false);
                }
            }
            // シーンをロードする(非同期)
            IEnumerator LoadScene()
            {

                AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("GameOver");



                // ロードがまだなら次のフレームへ
                while (!asyncLoad.isDone)
                {
                    yield return null;
                }
            }
            void die()
            {
                dieflag = true;
                livefram = 0;
                //Instantiate(Obj);
                player.SetActive(false);
               // player.transform.position = new Vector3(0, 0, 0);

            }



        }
          void Update()
        {
                 livefram++;  
        }
    }
}