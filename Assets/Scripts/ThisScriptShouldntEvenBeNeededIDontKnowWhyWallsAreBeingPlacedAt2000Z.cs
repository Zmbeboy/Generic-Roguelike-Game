using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisScriptShouldntEvenBeNeededIDontKnowWhyWallsAreBeingPlacedAt2000Z : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 josh = gameObject.transform.position;
        josh.z = 0;
        gameObject.transform.position = josh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
