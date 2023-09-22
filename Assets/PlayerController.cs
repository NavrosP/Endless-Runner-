using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject groundChecker;
    public LayerMask whatisground;

    public float maxSpeed = 10.0f;
    bool isOnGround = false;


    //create a refrence to rigidbody2d so we can manipulate it
    Rigidbody2D playerObject;

    // Start is called before the first frame update
    void Start()
    {
        //find the rigidbody2d component that is attached to the same object as this script
        playerObject = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        //create a "float" that will be equal to the players horizontal input
        float movementValueX = Input.GetAxis("Horizontal");
       
        //change the x velocity of the rigidbody2 to be equal to the movement value 
        playerObject.velocity = new Vector2(movementValueX*maxSpeed, playerObject.velocity.y);

        //check to see if the ground check object is touching the ground
        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 1.0f, whatisground);


    }
}
