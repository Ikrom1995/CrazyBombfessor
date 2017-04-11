using UnityEngine;
using System.Collections;

public class JumpSoundScript : MonoBehaviour {

    //creating variables
    private AudioSource _jump;
    public AudioClip Jump;
    // Use this for initialization
    void Start()
    {
        //getting audiosource of gameobject to which script is attached
        _jump = GetComponent<AudioSource>();
        InvokeRepeating("PlaySound", 0.0f, 0.001f);
    }

    void PlaySound()
    {
        //whenever player press "Space" sound will be played
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //plays audioclip once
            _jump.PlayOneShot(Jump);
        }
    }
}
