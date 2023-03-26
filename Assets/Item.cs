using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemTag;
    public GameObject ItemLord;
    private void Start()
    {
        ItemLord = GameObject.Find("ItemController");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ItemLord.GetComponent<ItemController>().CollectedItems.Add(itemTag);
            Destroy(gameObject);
        }
        else
        {
            return;
        }
    }
}

