using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Create a refrence to the RigiBody2D so we can manipulate it 
    Rigidbody2D playerObject;

    // Start is called before the first frame update
    void Start()
    {
        //Find the RigidBody2D component this is attached to the same object as this script
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Create a "float" that will be equal to the players horizontal input
        float movmentValueX = Input.GetAxis("horizontal");

        //Change the x velocity of the RigidBody2D to be equal to the movement value
        playerObject.velocity = new Vector2(movmentValueX, playerObject.velocity.y);

    }
}
