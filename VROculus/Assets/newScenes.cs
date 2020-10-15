using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newScenes : MonoBehaviour
{
    float speed = 60.0f;
    bool spin = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (spin)
        {
            SceneManager.LoadScene("Elcase");
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