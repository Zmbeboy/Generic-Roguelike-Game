using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject Stats;
    public GameObject projectile;
    public GameObject defProjectile;
    public GameObject KnifeProjectile;
    public float shotSpeed;
    private float time;
    public float atkspeed;
    public bool notShot;
    public bool trigun;
    bool Eknife;
    void Start()
    {
        projectile = defProjectile;
        time = atkspeed;
        notShot = true;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        
        if(Eknife)
        {
            projectile = KnifeProjectile;
        }
        newStats();
        time += Time.fixedDeltaTime;
        if (time >= atkspeed)
        {
            if (trigun == false)
            {
                if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow) && notShot)
                {
                    GameObject Pellet = (GameObject)Instantiate(projectile) as GameObject;
                    Pellet.GetComponent<Rigidbody2D>().AddForce(new Vector2(-shotSpeed/1.5f, shotSpeed/1.5f), ForceMode2D.Impulse);
                    Pellet.transform.position = gameObject.transform.position;
                    notShot = false;
                    time = 0;
                }
                if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow) && notShot)
                {
                    GameObject Pellet = (GameObject)Instantiate(projectile) as GameObject;
                    Pellet.GetComponent<Rigidbody2D>().AddForce(new Vector2(shotSpeed / 1.5f, shotSpeed / 1.5f), ForceMode2D.Impulse);
                    Pellet.transform.position = gameObject.transform.position;
                    notShot = false;
                    time = 0;
                }
                if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow) && notShot)
                {
                    GameObject Pellet = (GameObject)Instantiate(projectile) as GameObject;
                    Pellet.GetComponent<Rigidbody2D>().AddForce(new Vector2(-shotSpeed / 1.5f, -shotSpeed / 1.5f), ForceMode2D.Impulse);
                    Pellet.transform.position = gameObject.transform.position;
                    notShot = false;
                    time = 0;
                }
                if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow) && notShot)
                {
                    GameObject Pellet = (GameObject)Instantiate(projectile) as GameObject;
                    Pellet.GetComponent<Rigidbody2D>().AddForce(new Vector2(shotSpeed / 1.5f, -shotSpeed / 1.5f), ForceMode2D.Impulse);
                    Pellet.transform.position = gameObject.transform.position;
                    notShot = false;
                    time = 0;
                }
                if (Input.GetKey(KeyCode.UpArrow) && notShot)
                {
                    GameObject Pellet = (GameObject)Instantiate(projectile) as GameObject;
                    Pellet.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, shotSpeed), ForceMode2D.Impulse);
                    Pellet.transform.position = gameObject.transform.position;
                    notShot = false;
                    time = 0;
                }
                if (Input.GetKey(KeyCode.DownArrow) && notShot)
                {
                    GameObject Pellet = (GameObject)Instantiate(projectile) as GameObject;
                    Pellet.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -shotSpeed), ForceMode2D.Impulse);
                    Pellet.transform.position = gameObject.transform.position;
                    notShot = false;
                    time = 0;
                }
                if (Input.GetKey(KeyCode.LeftArrow) && notShot)
                {
                    GameObject Pellet = (GameObject)Instantiate(projectile) as GameObject;
                    Pellet.GetComponent<Rigidbody2D>().AddForce(new Vector2(-shotSpeed, 0), ForceMode2D.Impulse);
                    Pellet.transform.position = gameObject.transform.position;
                    notShot = false;
                    time = 0;
                }
                if (Input.GetKey(KeyCode.RightArrow) && notShot)
                {
                    GameObject Pellet = (GameObject)Instantiate(projectile) as GameObject;
                    Pellet.GetComponent<Rigidbody2D>().AddForce(new Vector2(shotSpeed, 0), ForceMode2D.Impulse);
                    Pellet.transform.position = gameObject.transform.position;
                    notShot = false;
                    time = 0;
                }
                notShot = true;
            }
            //trigun starts here
            else
            {
                if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow) && notShot)
                {
                    GameObject Pellet1 = (GameObject)Instantiate(projectile) as GameObject;
                    GameObject Pellet2 = (GameObject)Instantiate(projectile) as GameObject;
                    GameObject Pellet3 = (GameObject)Instantiate(projectile) as GameObject;
                    Pellet1.GetComponent<Rigidbody2D>().AddForce(new Vector2(-shotSpeed / 1.5f, shotSpeed / 1.5f), ForceMode2D.Impulse);
                    Pellet2.GetComponent<Rigidbody2D>().AddForce(new Vector2(-shotSpeed, shotSpeed / 2f), ForceMode2D.Impulse);
                    Pellet3.GetComponent<Rigidbody2D>().AddForce(new Vector2(-shotSpeed / 2f, shotSpeed), ForceMode2D.Impulse);
                    Pellet1.transform.position = gameObject.transform.position;
                    Pellet2.transform.position = gameObject.transform.position;
                    Pellet3.transform.position = gameObject.transform.position;
                    notShot = false;
                    time = 0;
                }
                if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow) && notShot)
                {
                    GameObject Pellet1 = (GameObject)Instantiate(projectile) as GameObject;
                    GameObject Pellet2 = (GameObject)Instantiate(projectile) as GameObject;
                    GameObject Pellet3 = (GameObject)Instantiate(projectile) as GameObject;
                    Pellet1.GetComponent<Rigidbody2D>().AddForce(new Vector2(shotSpeed / 1.5f, shotSpeed / 1.5f), ForceMode2D.Impulse);
                    Pellet2.GetComponent<Rigidbody2D>().AddForce(new Vector2(shotSpeed / 2f, shotSpeed), ForceMode2D.Impulse);
                    Pellet3.GetComponent<Rigidbody2D>().AddForce(new Vector2(shotSpeed, shotSpeed / 2f), ForceMode2D.Impulse);
                    Pellet1.transform.position = gameObject.transform.position;
                    Pellet2.transform.position = gameObject.transform.position;
                    Pellet3.transform.position = gameObject.transform.position;
                    notShot = false;
                    time = 0;
                }
                if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow) && notShot)
                {
                    GameObject Pellet1 = (GameObject)Instantiate(projectile) as GameObject;
                    GameObject Pellet2 = (GameObject)Instantiate(projectile) as GameObject;
                    GameObject Pellet3 = (GameObject)Instantiate(projectile) as GameObject;
                    Pellet1.GetComponent<Rigidbody2D>().AddForce(new Vector2(-shotSpeed / 1.5f, -shotSpeed / 1.5f), ForceMode2D.Impulse);
                    Pellet2.GetComponent<Rigidbody2D>().AddForce(new Vector2(-shotSpeed / 2f, -shotSpeed), ForceMode2D.Impulse);
                    Pellet3.GetComponent<Rigidbody2D>().AddForce(new Vector2(-shotSpeed, -shotSpeed / 2f), ForceMode2D.Impulse);
                    Pellet1.transform.position = gameObject.transform.position;
                    Pellet2.transform.position = gameObject.transform.position;
                    Pellet3.transform.position = gameObject.transform.position;
                    notShot = false;
                    time = 0;
                }
                if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow) && notShot)
                {
                    GameObject Pellet1 = (GameObject)Instantiate(projectile) as GameObject;
                    GameObject Pellet2 = (GameObject)Instantiate(projectile) as GameObject;
                    GameObject Pellet3 = (GameObject)Instantiate(projectile) as GameObject;
                    Pellet1.GetComponent<Rigidbody2D>().AddForce(new Vector2(shotSpeed / 1.5f, -shotSpeed / 1.5f), ForceMode2D.Impulse);
                    Pellet2.GetComponent<Rigidbody2D>().AddForce(new Vector2(shotSpeed / 2f, -shotSpeed), ForceMode2D.Impulse);
                    Pellet3.GetComponent<Rigidbody2D>().AddForce(new Vector2(shotSpeed, -shotSpeed / 2f), ForceMode2D.Impulse);
                    Pellet1.transform.position = gameObject.transform.position;
                    Pellet2.transform.position = gameObject.transform.position;
                    Pellet3.transform.position = gameObject.transform.position;
                    notShot = false;
                    time = 0;
                }
                if (Input.GetKey(KeyCode.UpArrow) && notShot)
                {
                    GameObject Pellet1 = (GameObject)Instantiate(projectile) as GameObject;
                    GameObject Pellet2 = (GameObject)Instantiate(projectile) as GameObject;
                    GameObject Pellet3 = (GameObject)Instantiate(projectile) as GameObject;
                    Pellet1.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, shotSpeed), ForceMode2D.Impulse);
                    Pellet2.GetComponent<Rigidbody2D>().AddForce(new Vector2(shotSpeed / 2f, shotSpeed), ForceMode2D.Impulse);
                    Pellet3.GetComponent<Rigidbody2D>().AddForce(new Vector2(-shotSpeed / 2f, shotSpeed), ForceMode2D.Impulse);
                    Pellet1.transform.position = gameObject.transform.position;
                    Pellet2.transform.position = gameObject.transform.position;
                    Pellet3.transform.position = gameObject.transform.position;
                    notShot = false;
                    time = 0;
                }
                if (Input.GetKey(KeyCode.DownArrow) && notShot)
                {
                    GameObject Pellet1 = (GameObject)Instantiate(projectile) as GameObject;
                    GameObject Pellet2 = (GameObject)Instantiate(projectile) as GameObject;
                    GameObject Pellet3 = (GameObject)Instantiate(projectile) as GameObject;
                    Pellet1.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -shotSpeed), ForceMode2D.Impulse);
                    Pellet2.GetComponent<Rigidbody2D>().AddForce(new Vector2(shotSpeed / 2f, -shotSpeed), ForceMode2D.Impulse);
                    Pellet3.GetComponent<Rigidbody2D>().AddForce(new Vector2(-shotSpeed / 2f, -shotSpeed), ForceMode2D.Impulse);
                    Pellet1.transform.position = gameObject.transform.position;
                    Pellet2.transform.position = gameObject.transform.position;
                    Pellet3.transform.position = gameObject.transform.position;
                    notShot = false;
                    time = 0;
                }
                if (Input.GetKey(KeyCode.LeftArrow) && notShot)
                {
                    GameObject Pellet1 = (GameObject)Instantiate(projectile) as GameObject;
                    GameObject Pellet2 = (GameObject)Instantiate(projectile) as GameObject;
                    GameObject Pellet3 = (GameObject)Instantiate(projectile) as GameObject;
                    Pellet1.GetComponent<Rigidbody2D>().AddForce(new Vector2(-shotSpeed, 0), ForceMode2D.Impulse);
                    Pellet2.GetComponent<Rigidbody2D>().AddForce(new Vector2(-shotSpeed, -shotSpeed / 2f), ForceMode2D.Impulse);
                    Pellet3.GetComponent<Rigidbody2D>().AddForce(new Vector2(-shotSpeed, shotSpeed / 2f), ForceMode2D.Impulse);
                    Pellet1.transform.position = gameObject.transform.position;
                    Pellet2.transform.position = gameObject.transform.position;
                    Pellet3.transform.position = gameObject.transform.position;
                    notShot = false;
                    time = 0;
                }
                if (Input.GetKey(KeyCode.RightArrow) && notShot)
                {
                    GameObject Pellet1 = (GameObject)Instantiate(projectile) as GameObject;
                    GameObject Pellet2 = (GameObject)Instantiate(projectile) as GameObject;
                    GameObject Pellet3 = (GameObject)Instantiate(projectile) as GameObject;
                    Pellet1.GetComponent<Rigidbody2D>().AddForce(new Vector2(shotSpeed, 0), ForceMode2D.Impulse);
                    Pellet2.GetComponent<Rigidbody2D>().AddForce(new Vector2(shotSpeed, -shotSpeed / 2f), ForceMode2D.Impulse);
                    Pellet3.GetComponent<Rigidbody2D>().AddForce(new Vector2(shotSpeed, shotSpeed / 2f), ForceMode2D.Impulse);
                    Pellet1.transform.position = gameObject.transform.position;
                    Pellet2.transform.position = gameObject.transform.position;
                    Pellet3.transform.position = gameObject.transform.position;
                    notShot = false;
                    time = 0;
                } 
                notShot = true;
            }
        }
    }
    public void newStats()
    {
        atkspeed = Stats.GetComponent<StatController>().attackSpeed;
        shotSpeed = Stats.GetComponent<StatController>().shotSpeeds;
        trigun = Stats.GetComponent<StatController>().trigun;
        Eknife = Stats.GetComponent<StatController>().knife;
    }
}
