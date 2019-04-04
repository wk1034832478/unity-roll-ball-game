using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBallScript : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // 根据转矩来移动小球
        float turnY = Input.GetAxis( "Vertical");
        float turnX = Input.GetAxis("Horizontal");
        this.rigidbody.AddTorque(turnY * speed ,0 , -turnX * speed );
    }
}
