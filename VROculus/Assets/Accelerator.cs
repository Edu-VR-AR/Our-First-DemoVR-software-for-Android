using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerator : MonoBehaviour
{
    public Quaternion calibrationQuaternion;
    float speed = 20.0f;
    //public Quaternion rotateQuaternion;

    // Start is called before the first frame update
    void Start()
    {
        CalibrateAccelerometr();
    }

    public void CalibrateAccelerometr()
    {
        Vector3 accelerationS = Input.acceleration;
       Quaternion rotateQuaternion= Quaternion.FromToRotation(new Vector3 (0.0f, 0.0f, -1.0f), accelerationS);
        calibrationQuaternion = rotateQuaternion;
        //calibrationQuaternion = Quaternion.Inverse(rotateQuaternion);
    }
    public Vector3 FixAcceleration( Vector3 acceleration)
    {
        Vector3 fixedAcceleraion = calibrationQuaternion * acceleration;
        return fixedAcceleraion;

    }

    private void FixedUpdate()
    {
        Vector3 accelerationRaw = Input.acceleration;
        Vector3 acceleration = FixAcceleration(accelerationRaw);
     }

    // Update is called once per frame
    void Update()
    {
        FixedUpdate();
        Vector3 dir ;
        dir.y = Input.acceleration.z;
        dir.x = -Input.acceleration.y;
        dir.z = Input.acceleration.x;
        //if (dir.sqrMagnitude > 1)
        //  dir.Normalize();
        dir *= Time.deltaTime;
        //  transform.Rotate(dir.x*speed,dir.z*speed,0.0f);
        transform.Translate(dir* speed);
        //transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward*speed);//нач положнеие т конечное


    }
}
