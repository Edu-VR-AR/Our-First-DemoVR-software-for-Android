using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class SCHULT : MonoBehaviour
{
   
   // public Transform[] waypoints;
    float x= 2.5f, y=2.5f;
    int c = 24;
    //public GameObject fater;
   public Transform[] Child= new Transform [25];
    private Transform buf;
    
    void Start()
    {
        /*for (int i = 0; i < 26; i++)
        {
            Child[i] = fater.transform.GetChild(i);
         }*/

        for (int ay = 0; ay < 5; ay++)
        {
            for (int ax = 0; ax < 5; ax++)
            {
                int a = Random.Range(0, c);
               // if (Child[a] != null)
              //  {
                    Child[a].transform.position = new Vector3(x, y, 0f);
                    buf = Child[c];
                    Child[c] = Child[a];
                    Child[a] = buf;              
                    c =c- 1;
                //}
                x += 5;
            }
            x = 2.5f;
            y += 5;
        }
        /*for (int i = 1; i < 26; i++)
        {
            fon.transform.position=new Vector3(x,y,0f);
        }
        waypoints = new Transform[transform.childCount];
        int i = 0;

        foreach (Transform t in transform)
        {
            waypoints[i++] = t;
        }*/


    }

    // Update is called once per frame
    void Update()
    {
     
    }
   
}