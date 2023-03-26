using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerProperties : MonoBehaviour
{
    public GameObject Stats;
    public float Health;
    private float healthCheck;
    public float maxHealth;
    public Image[] Hearts;
    public Sprite full;
    public Sprite half;
    public Sprite empty;
    public float safeFrames;
    public bool invincible;
    public float time;
    public GameObject ItemCont;
    private bool Eknife;
    void Start()
    {
        invincible = false;
        time = 0;
        healthCheck = Health;
    }

    // Update is called once per frame
    void Update()
    { 
        newStats();
        if(Health > maxHealth)
        {
            Health = maxHealth;
        }
        for(int i = 0; i < Hearts.Length;i++)
        {
            if(i+1<=Health/2)
            {
                Hearts[i].sprite = full;
            }
            else if(i+1-(Health/2) == 0.5)
            {        
                Hearts[i].sprite = half;
            }
            else
            {
                Hearts[i].sprite = empty;
            }
            if(i<maxHealth/2)
            {
                Hearts[i].enabled = true;
            }
            else
            {
                Hearts[i].enabled = false;
            }
        }
       
    }
    private void FixedUpdate()
    {
        if (invincible)
        {
            time += Time.fixedDeltaTime;
            if(time >=safeFrames)
            {
                invincible = false;
                time = 0;
            }
        }
        if(Health<healthCheck)
        {
            healthCheck = Health;
            invincible = true;
        }
        if (Health> healthCheck)
        {
            healthCheck = Health;
        }
    }
    public bool IsImmune()
    {
        return invincible == true;
    }
    public void newStats()
    {
        safeFrames = Stats.GetComponent<StatController>().safeFrame;
        maxHealth = Stats.GetComponent<StatController>().maxHealths;
    }
}
