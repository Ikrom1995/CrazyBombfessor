using UnityEngine;
using System.Collections;

public class DetonatorL3Script : MonoBehaviour {

    // Use this for initialization
    public GameObject Door;
    public GameObject Bomb;
    public Animator explosion;
    private AudioSource _explosion;
    public AudioClip Explosion;
    int count = 0;
    void Start () {
        explosion.enabled = false;
        _explosion = GetComponent<AudioSource>();
        InvokeRepeating("PlaySound", 0.0f, 0.2f);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        count++;
        //as 2 colliders used in player
        //each time player collides with the gameobject count increases by 2
        //thus when player collides with the detonator 5 times
        //count = 10 and following is activated
        if(count == 10)
        {
            Destroy(Door);
            explosion.enabled = true;
            Destroy(Bomb, 1);
            _explosion.PlayOneShot(Explosion);
            Destroy(gameObject, 1);
        }
    }
}
