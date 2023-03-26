using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Sprite leftOpen;
    public Sprite leftClosed;
    public Sprite rightOpen;
    public Sprite rightClosed;
    public Sprite topOpen;
    public Sprite topClosed;
    public Sprite bottomOpen;
    public Sprite bottomClosed;
    public string doorSide;
    public enum DoorType
    {
        left,right,top,bottom
    }
    public DoorType doorType;
    public void Update()
    {

        if (doorSide == "top")
        {
            if (GetComponent<BoxCollider2D>().isTrigger)
            {
                GetComponent<SpriteRenderer>().sprite = topOpen;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = topClosed;
            }
        }
        if (doorSide == "left")
        {
            if (GetComponent<BoxCollider2D>().isTrigger)
            {
                GetComponent<SpriteRenderer>().sprite = leftOpen;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = leftClosed;
            }
        }
        if (doorSide == "right")
        {
            if (GetComponent<BoxCollider2D>().isTrigger)
            {
                GetComponent<SpriteRenderer>().sprite = rightOpen;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = rightClosed;
            }
        }
        if (doorSide == "bottom")
        {
            if (GetComponent<BoxCollider2D>().isTrigger)
            {
                GetComponent<SpriteRenderer>().sprite = bottomOpen;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = bottomClosed;
            }
        }
    }
}
