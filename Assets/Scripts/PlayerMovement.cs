using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Stats;
    private Rigidbody2D PlayerBody;
    public float moveSpeed;
    public float speed;
    public float maxSpeed;
    public float slowDown;
    // Start is called before the first frame update
    void Start()
    {
        PlayerBody = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        newStats();
        PlayerBody.velocity = Vector3.ClampMagnitude(PlayerBody.velocity, maxSpeed);
        speed = PlayerBody.velocity.magnitude;
        if(Input.GetKey("w"))
        {
            PlayerBody.AddForce(new Vector2(0, moveSpeed), ForceMode2D.Impulse); 
        }
        if (Input.GetKey("s"))
        {
            PlayerBody.AddForce(new Vector2(0, -moveSpeed), ForceMode2D.Impulse);
        }
        if (Input.GetKey("a"))
        {
            PlayerBody.AddForce(new Vector2(-moveSpeed, 0), ForceMode2D.Impulse);
        }
        if (Input.GetKey("d"))
        {
            PlayerBody.AddForce(new Vector2(moveSpeed, 0), ForceMode2D.Impulse);
        }
        if(!(Input.GetKey("w")|| Input.GetKey("s") || Input.GetKey("a") || Input.GetKey("d")))
        {
            PlayerBody.velocity = PlayerBody.velocity * slowDown;
            if(speed<0.5)
            {
                PlayerBody.velocity = PlayerBody.velocity * 0;
            }
        }
    }
    public void newStats()
    {
        moveSpeed = Stats.GetComponent<StatController>().acceleration;
        maxSpeed = Stats.GetComponent<StatController>().maxSpeeds;
    }
}
