using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GazeCloo : MonoBehaviour
{
    public GameObject menu1;
    public GameObject menu2;
    float speed = 60.0f;
    bool spin = false;

    // Use this for initialization
    void Start()
    {
        menu2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (spin)
        {
            //SceneManager.LoadScene("Elcase");
            menu1.SetActive(false);
            menu2.SetActive(true);
            //transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }
    }

    public void OnClickStart()
    {
        spin = true;
    }

    public void OnClickStop()
    {
        spin = false;
    }
}