using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireMovement : Player
{
    void FixedUpdate()
    {
        Move(Input.GetAxisRaw("Horizontal"));
        if (isGrounded && Input.GetKeyDown(KeyCode.Space)) 
            Jump(10);
    }


    void Jump(float force)
    {
        playerRB.AddForce(new Vector2(movementSpeed * force, 0));
    }
}
