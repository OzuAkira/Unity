using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using unseen;

public class DieFramCount : Sene
{
    // Start is called before the first frame updat
     public int DieFram = 0;
     public GameObject player_1;
    public void Start()
    {
      //var player_1 = Resources.Load("player 1");

    }

    
    // Update is called once per frame
    void Update()
    {
        if (dieflag == false)
        {
            DieFram++;
            if (DieFram > 600)
            {
                
              player_1.SetActive(true);
                DieFram = 0;
               // Debug.Log("die");
            }
        }
    }
}
