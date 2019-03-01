using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    // higher forwardForce to account for drag
    public float forwardForce = 4000f;
    // lower sidewaysForce since VelocityChange is being used for ForceMode
    public float sidewaysForce = 100f;


    // Update is called once per frame
    // Unity prefers to use FixedUpdate rather than Update when calculating
    // the physics of the world (i.e., adding forces, changing velocity, etc.) 
    void FixedUpdate()
    {
        // apply constant force in the z direction
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("a") )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Call EndGame() if block has fallen below -10 along the y axis
        if (rb.position.y < -5f)
        {
            // required if respawning the player into an existing level
            // not necessary in this game, but good tip from brackeys
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
