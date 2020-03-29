using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireMovement : MonoBehaviour
{
    Rigidbody playerRB;
    public float forceOfMovement;

    private void Awake()
    {
        playerRB = gameObject.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Move(Input.GetAxisRaw("Horizontal"));
    }


    void Move(float force)
    {
        playerRB.AddForce(new Vector2(forceOfMovement * force, 0));
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit");
        playerRB.velocity = new Vector2(0.0f, 0.0f);
    }

    IEnumerator Wait2Sec()
    {
        yield return new WaitForSeconds(2);
    }
}
