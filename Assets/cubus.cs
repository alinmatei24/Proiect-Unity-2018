using UnityEngine;
using System.Collections;

public class cubus : MonoBehaviour
{

    public float moveSpeed;
    public float jumpHeight;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded=true;
    Collider2D col;

    // Use this for initialization
    void Start()
    {
    }

    void fixedUpdate()
    {


        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

    }   
    // Update is called once per frame
    void Update()
    {
       

        Debug.Log(grounded);
        if (Input.GetKeyDown(KeyCode.W) && grounded)
        {
            Debug.Log("apasat butto");
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

    }
}