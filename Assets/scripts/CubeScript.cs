using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public Rigidbody cubeRigidBody;
    public float torqueUnit; // torque unit

    // Start is called before the first frame update
    void Start()
    {
        // ector3(0, 1, 0)
        this.cubeRigidBody.AddTorque(10f,10f,10f, ForceMode.Force );
    }

    // Update is called once per frame
    void Update()
    {
        // float turnY = Input.GetAxis("Vertical");
        // float turnX = Input.GetAxis("Horizontal");
        // this.cubeRigidBody.AddTorque(  turnY * torqueUnit , 0, -turnX * torqueUnit);
    }
}
