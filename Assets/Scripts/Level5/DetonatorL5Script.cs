using UnityEngine;
using System.Collections;

public class DetonatorL5Script : MonoBehaviour {

    public Transform[] SpawnLocations;
    public GameObject[] SpawnPrefab;
    public Animator explosion;

    //spawns door
    void spawnDoor()
    {
        GameObject Door = Instantiate(SpawnPrefab[0], SpawnLocations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }
    // Use this for initialization
    void Start () {
        explosion.enabled = false;
    }

    //spwans door if collided with player
    public void OnTriggerEnter2D(Collider2D other)
    {
        spawnDoor();
    }
}
