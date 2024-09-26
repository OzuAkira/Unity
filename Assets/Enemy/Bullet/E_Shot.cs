using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Shot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,10);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Wall") || other.gameObject.CompareTag("bulia")){
            Destroy(gameObject,5.0f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
