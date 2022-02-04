using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipControlLeft : MonoBehaviour
{
    public float speed = 0f;
    private HingeJoint2D hingeJoint2D;
    private JointMotor2D jointMotor;

    void Start()
    {
        hingeJoint2D = GetComponent<HingeJoint2D>();
        jointMotor = hingeJoint2D.motor;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // set motor speed to max
        if (Input.GetKey("z"))
        {
            speed = -200f;
            jointMotor.motorSpeed = speed;
            hingeJoint2D.motor = jointMotor;
        }
       else
        {
            speed = 200f;
            jointMotor.motorSpeed = speed;
            hingeJoint2D.motor = jointMotor;
        }
        

    }
}
