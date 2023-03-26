using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public bool done;
    public GameObject allHailTheItemLord;
    public List<GameObject> items;
    private void Start()
    {
        allHailTheItemLord = GameObject.Find("ItemController");
       items = allHailTheItemLord.GetComponent<ItemController>().Items;
       done = false; 
    }

    void Update()
    {
        if(GetComponentInParent<RoomClear>().isCleared==true)
        {
            SpawnItem(done);
        }
    }
    public void SpawnItem(bool Complete)
    {
        if(Complete)
        {
            return;
        }
        else
        {
            if (items.Count > 0)
            {
                done = true;
                int x = Random.Range(0, items.Count);
                GameObject ItemSpawned = Instantiate(items[x], gameObject.transform);
            }
            else
            {
                return;
            }
        }
    }
}
