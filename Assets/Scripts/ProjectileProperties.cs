using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileProperties : MonoBehaviour
{
    Rigidbody2D r;
    public string tag;
    public float slowDown;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(tag == "EKnife")
        {
            r.AddTorque(5f);
        }
        speed = r.velocity.magnitude;
        r.velocity = r.velocity * slowDown;
        if ( speed < 0.5)
        {
            r.velocity = r.velocity * 0;
        }
        if (speed == 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            if (tag == "Default")
            {
                collision.GetComponent<EnemyHealth>().Health -= 1;
                Destroy(gameObject);
            }
            else if(tag =="EKnife")
            {
                collision.GetComponent<EnemyHealth>().Health -= 1;
                collision.GetComponent<SlimeProperties>().knifed = true;
                Destroy(gameObject);
            }
        }
    }
}
