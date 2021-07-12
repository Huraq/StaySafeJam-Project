using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int lifePoints;
    public float movementSpeed;
    public Rigidbody  playerRB;
    public bool isGrounded = false;

    
    private void Awake()
    {
        playerRB = gameObject.GetComponent<Rigidbody>();
    }

    internal void Move(float force)
    {
        playerRB.AddForce(new Vector2(movementSpeed * force, 0));
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit");
        isGrounded = true;
        playerRB.velocity = new Vector2(0.0f, 0.0f);
    }
    
    IEnumerator Wait2Sec()
    {
        yield return new WaitForSeconds(2);
    }
    
}