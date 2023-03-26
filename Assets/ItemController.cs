using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public List<GameObject> Items = new List<GameObject>();
    public List<string> CollectedItems = new List<string>();
    public List<string> usedItems = new List<string>();
    public GameObject Stats;
    void Awake()
    { 
        Stats = GameObject.Find("StatController");
    }
       

    void Update()
    {
        while (CollectedItems.Count > 0)
        {
            foreach (string item in CollectedItems.ToArray())
            {
                if (item == "1739")
                {
                    Stats.GetComponent<StatController>().acceleration += 1;
                    Stats.GetComponent<StatController>().maxSpeeds += 1;
                    usedItems.Add(item);
                    
                   
                }
                if(item == "Trigun")
                {
                    Stats.GetComponent<StatController>().trigun = true;
                    usedItems.Add(item);
                }
                if (item == "EricKnife")
                {
                    Stats.GetComponent<StatController>().knife = true;
                    usedItems.Add(item);
                }
                foreach (GameObject item1 in Items.ToArray())
                    {
                        if( item1.GetComponent<Item>().itemTag == item)
                        {
                            Items.Remove(item1);
                        }
                    }
                CollectedItems.Remove(item);

            }
        }

    }
}
