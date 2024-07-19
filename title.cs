using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void push()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(LoadScene());
        }
    }
    IEnumerator LoadScene()
    {

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("SampleScene");



        // ロードがまだなら次のフレームへ
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    // Update is called once per frame
    void Update()
    {
        push();
    }
}
