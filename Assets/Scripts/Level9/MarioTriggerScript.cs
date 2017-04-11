using UnityEngine;
using System.Collections;

public class MarioTriggerScript : MonoBehaviour {

    public GameObject Platform;
    int count = 0;
    // Use this for initialization

    public void OnTriggerEnter2D(Collider2D other)
    {
        //if player collides with trigger 4 times platform destroys
        count++;
        if (count == 4)
        {
            Destroy(Platform);
        }
    }
}
