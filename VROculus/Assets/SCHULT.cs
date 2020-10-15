using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class SCHULT : MonoBehaviour
{
    public GameObject fon;
    Transform[] data;
    private Transform[] result;

    //public GameObject[] fonMas;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 1; i < 26; i++)
        {
            string sph;

            sph =  i.ToString();
            result[i] = gameObject.transform.Find(sph);

            if (result[i])
            {
                Debug.Log(sph);
            }
            else
            {
                Debug.Log("Did not find: " + sph);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
     
    }
    public void Rand()
    {
        for (int i = data.Length - 1; i >= 1; i--)
        {
            int j = Random.Range(0,25);
            // обменять значения data[j] и data[i]
            var temp = data[j];
            data[j] = data[i];
            data[i] = temp;
        }
    }
}