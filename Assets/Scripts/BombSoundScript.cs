using UnityEngine;
using System.Collections;

public class BombSoundScript : MonoBehaviour {

    //creating variables for AudioSource and AudioClip
    private AudioSource _explosion;
    //make the variable public to select the clip from the Unity UI
    public AudioClip Explosion;

    void Start()
    {
        //equalizing variable created for the gameobject's AudioSource
        _explosion = GetComponent<AudioSource>();
        //Invokes the method in time seconds, then repeatedly every repeatRate seconds.
        InvokeRepeating("PlaySound", 0.0f, 0.2f);
    }

    //method that works when gameObject collides with another GameObject
    public void OnTriggerEnter2D(Collider2D other)
    {
        //works only if player collides with the gameobject
        if (other.name == "Player") {
            //audio plays once
            _explosion.PlayOneShot(Explosion);
            //destroys gameObject after 1 second delay
            Destroy(gameObject, 1);
        }
    }
}
