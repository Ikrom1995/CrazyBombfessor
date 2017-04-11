using UnityEngine;
using System.Collections;

public class WalkingSoundScript : MonoBehaviour {
    private AudioSource _walking;
    public AudioClip WalkClip;
    // Use this for initialization
    void Start () {
        _walking = GetComponent<AudioSource>();
        InvokeRepeating("PlaySound", 0.0f, 0.35f);
	}
    //methods to play walksound
    void PlaySound() {
        if (Input.GetButton("Horizontal")) {
            _walking.PlayOneShot(WalkClip);
        }
    }
}
