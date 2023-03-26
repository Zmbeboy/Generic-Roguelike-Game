using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float Health;
    private float pastHealth;
    SpriteRenderer SR;
    public float time;
    public float colorTime;
    void Start()
    {
        pastHealth = Health;
        SR = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(Health <= 0 )
        {
            GetComponentInParent<RoomClear>().enemiesLeft.Remove(gameObject);
            Destroy(gameObject);
        }
        if(Health<pastHealth)
        {
            //do the red thing
            pastHealth = Health;
            SR.color = Color.red;
            time = 0;
        }
        if (Health > pastHealth)
        {
            //do the green thing
            pastHealth = Health;
            SR.color = Color.green;
            time = 0;
        }
        if(time >= colorTime)
        {
            SR.color = Color.white;
            time = 0;
        }
    }
}
