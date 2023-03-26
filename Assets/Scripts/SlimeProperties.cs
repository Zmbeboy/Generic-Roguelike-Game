using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeProperties : MonoBehaviour
{
    public GameObject player;
    public float moveTime;
    public float moveSpeed;
    public float restTime;
    public float time;
    public float time2;
    public Animator animator;
    private bool bounce;
    private bool idle;
    public float SlimeDamage;
    public bool triggered;
    public bool knifed;
    public GameObject knifeOverlay;
    void Start()
    {
        player = GameObject.Find("Player");
        restTime += moveTime;
        bounce = true;
        idle = true;
        triggered = false;
        GetComponentInParent<RoomClear>().enemiesLeft.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        time2 += Time.deltaTime;
        if (time <= moveTime)
        {
            if (bounce)
            {
                animator.Play("Base Layer.Bounce", 0, 0);
            }
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
            bounce = false;
        }
        else
        {
            if (idle)
            {
                animator.Play("Base Layer.Slime_Idle", 0, 0);
            }
            idle = false;
        }
        if (time >= restTime)
        {
            time = 0;
            bounce = true;
            idle = true;
        }
        if(knifed)
        {
            knifeOverlay.SetActive(true);
        }
        //bleed effect
        if(knifed&&(time2 >= 2))
        {
            gameObject.GetComponent<EnemyHealth>().Health -= 1;
            time2 = 0;
        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.GetComponent<PlayerProperties>().IsImmune())
            {
                return;
            }
            else
            {
                collision.GetComponent<PlayerProperties>().Health -= SlimeDamage;
            }
        }
    }
    
}
