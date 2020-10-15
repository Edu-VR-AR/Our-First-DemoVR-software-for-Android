using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GazeSelect : MonoBehaviour
{

    float speed = 30.0f;
    bool spin = false;
    bool bScale = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float sc = bScale ? 4.0f : 3.0f;

        transform.localScale = new Vector3(sc, sc, sc);

        if (spin)
        {
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }

       

        }

    public void GazeFocusStart()
    {
        spin = true;
    }

    public void GazeFocusEnd()
    {
        spin = false;
    }

    public void GazeFocusClick()
    {
        bScale = !bScale;
    }
}
