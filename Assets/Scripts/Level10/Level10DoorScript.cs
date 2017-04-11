using UnityEngine;
using System.Collections;

public class Level10DoorScript : MonoBehaviour {

    public GameObject Platform;
    int count = 0;

    public void OnTriggerEnter2D(Collider2D other)
    {
        count++;
        //when the player collides with the door 4 times door destroys
        //count == 8 as player has 2 colliders and each time player collied count increases by 2
        if (count == 8)
        {
            Destroy(Platform);
        }
    }
}
