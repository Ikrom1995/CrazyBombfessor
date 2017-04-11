using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	private Animator PlayerAnimator;
	//variables for grounding
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
    //variables for moving
    float move;
    float moveSpeed = 11f;

    void Start () {
		PlayerAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //gets the rigidBody2D component of the gameobject to which script is attached
		Rigidbody2D rigidBody2D = GetComponent<Rigidbody2D> ();

        //checks if player is grounded
        //groundCheck.position checks the position of the groundCheck object from the game,
        //ground radius is the radius from groundCheck.position
        //whatIsGround is layers
        //checks if the layers are within the radius of the groundCheck's groundRadius and returns true or false
        grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		PlayerAnimator.SetBool ("Ground", grounded);
		PlayerAnimator.SetFloat ("vSpeed", rigidBody2D.velocity.y);

		//Disables user interaction while jumping or falling
		//if (!grounded) return;

		move = Input.GetAxis ("Horizontal");

		Vector3 localScale = transform.localScale;
        //turns player to the right or left
		if (move > 0)
			localScale.x = 1f;
		else if (move < 0)
			localScale.x = -1f;

		transform.localScale = localScale;

        //if horizontal input is not 0 turning on running animation
		if (move != 0f) {
			PlayerAnimator.SetBool ("IsRunning", true);
		} else {
			PlayerAnimator.SetBool ("IsRunning", false);
        }

        //if sortingOrder of SpriteRenderer = -2, then frezes the position of the player by all axes
        if (gameObject.GetComponent<SpriteRenderer>().sortingOrder == -2)
        {
            gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            move = 0f;
        }

        //moves player horizontally
        rigidBody2D.velocity = new Vector2 (move * moveSpeed, rigidBody2D.velocity.y);

	}

	void Update(){
        
		Rigidbody2D rigidBody2D = GetComponent<Rigidbody2D> ();
        //for jumping
        if (grounded && Input.GetKeyDown (KeyCode.Space) && Time.timeScale != 0)
        {
			PlayerAnimator.SetBool ("Ground", false);
			rigidBody2D.AddForce (new Vector2(0, 1200));
		}
	
	}

    //following methods enables and disables movement of the player by changing the mevement speed
    //if player collides with items listed in the method
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Border1" ||
            other.name == "Border2" ||
            other.name == "Border3" ||
            other.name == "Border4" ||
            other.name == "Border5" ||
            other.name == "Border6" ||
            other.name == "Border7" ||
            other.name == "Border8" ||
            other.name == "Border9" ||
            other.name == "Border10" ||
            other.name == "Border11" ||
            other.name == "Border12")
            moveSpeed = 0f;
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "Border1" ||
            other.name == "Border2" ||
            other.name == "Border3" ||
            other.name == "Border4" ||
            other.name == "Border5" ||
            other.name == "Border6" ||
            other.name == "Border7" ||
            other.name == "Border8" ||
            other.name == "Border9" ||
            other.name == "Border10" ||
            other.name == "Border11" ||
            other.name == "Border12")
            moveSpeed = 0f;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Border1" ||
            other.name == "Border2" ||
            other.name == "Border3" ||
            other.name == "Border4" ||
            other.name == "Border5" ||
            other.name == "Border6" ||
            other.name == "Border7" ||
            other.name == "Border8" ||
            other.name == "Border9" ||
            other.name == "Border10" ||
            other.name == "Border11" ||
            other.name == "Border12")
            moveSpeed = 11f;
    }
}
