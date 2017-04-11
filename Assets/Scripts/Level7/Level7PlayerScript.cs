using UnityEngine;
using System.Collections;

public class Level7PlayerScript : MonoBehaviour {

    private Animator PlayerAnimator;
    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    //move speed is negative to reverse horizontal movement
    //all the rest is the same with regular player script
    float moveSpeed = -11f;

    void Start()
    {
        PlayerAnimator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        Rigidbody2D rigidBody2D = GetComponent<Rigidbody2D>();

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        PlayerAnimator.SetBool("Ground", grounded);
        PlayerAnimator.SetFloat("vSpeed", rigidBody2D.velocity.y);

        float move = Input.GetAxis("Horizontal");

        Vector3 localScale = transform.localScale;

        if (move > 0)
            localScale.x = 1f;
        else if (move < 0)
            localScale.x = -1f;

        transform.localScale = localScale;

        if (move != 0f)
        {
            PlayerAnimator.SetBool("IsRunning", true);
        }
        else
        {
            PlayerAnimator.SetBool("IsRunning", false);
        }

        if (gameObject.GetComponent<SpriteRenderer>().sortingOrder == -2)
        {
            gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            move = 0f;
        }

        rigidBody2D.velocity = new Vector2(move * moveSpeed, rigidBody2D.velocity.y);

    }

    void Update()
    {
        Rigidbody2D rigidBody2D = GetComponent<Rigidbody2D>();
        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            PlayerAnimator.SetBool("Ground", false);
            rigidBody2D.AddForce(new Vector2(0, 1200));
        }
    }

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
            moveSpeed = -11f;
    }
}
