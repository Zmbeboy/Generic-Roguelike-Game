using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomClear : MonoBehaviour
{
    public List<GameObject> enemiesLeft = new List<GameObject>();
    public bool isCleared;
    public List<GameObject> doors = new List<GameObject>();
    public float time;
    public float roomSpawnDelay;
    public void Start()
    {
        roomSpawnDelay = 0.5f;
       doors = GetComponentInParent<Room>().DoorsForRoomCheck;
    }
    private void Update()
    {
        if(enemiesLeft.Count == 0)
        {
            isCleared = true;
            DoorControl(isCleared);
        }
        else
        {
            isCleared = false;
            DoorControl(isCleared);
        }
       
    }
    public void DoorControl(bool passed)
    {
        if (!passed)
        {
            foreach (GameObject door in doors)
            {
                door.GetComponent<Collider2D>().isTrigger = false;
            }
        }
       else
        {
            foreach (GameObject door in doors)
            {
                door.GetComponent<Collider2D>().isTrigger = true;
            }
        }
    }
}
