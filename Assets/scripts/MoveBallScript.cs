using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveBallScript : MonoBehaviour
{
    public Text text;
    public Rigidbody rigidbody;
    public float speed;
    public const string SCORE_PREFIX = "当前分数为：";
    public int score;
    public const int SIZE = 9;
    public int count = 0;
    public float endTime;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log( "当前游戏时间：" + Time.realtimeSinceStartup );
        // 根据转矩来移动小球
        float turnY = Input.GetAxis( "Vertical");
        float turnX = Input.GetAxis("Horizontal");
        this.rigidbody.AddTorque(turnY * speed ,0 , -turnX * speed );
        
        if (this.count == 9)
        {
            this.text.text = "总用时：" + this.endTime ;
        }
        else {
            this.text.text = SCORE_PREFIX + score;
        }    
    }

    void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.CompareTag( "Box" ) ) {
            Debug.Log( "成功撞到小球啦！！" );
            Destroy( collision.gameObject );
            this.score++;
            this.count++;
            if ( this.count == 9 ) {
                this.endTime = Time.realtimeSinceStartup;
            }
        }
    }
}
