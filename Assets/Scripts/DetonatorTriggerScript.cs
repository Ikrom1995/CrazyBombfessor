using UnityEngine;
using System.Collections;

public class DetonatorTriggerScript : MonoBehaviour {
	// creating cariables
    //make them public to select items from unity ui
	public GameObject Door;
	public GameObject Bomb;
	public Animator explosion;

	void Start () {
        //turning off animation on start
		explosion.enabled = false;
	}

	public void OnTriggerEnter2D(Collider2D other){
        //destroys gameobject called "Door"
		Destroy(Door);
        //destroys gameObject to which the script attached after 1 second delay
        Destroy(gameObject, 1);
        //turns on animation
		explosion.enabled = true;
        //destroys gameobject called "Door" after 1 second delay
        Destroy(Bomb, 1);

	}
}
