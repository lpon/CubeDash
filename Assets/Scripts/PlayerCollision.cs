using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;


    // This function is called when this RigidBody/Collider 
    // collides with another RigidBody/Collider
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // required if respawning the player into an existing level
            // not necessary in this game, but good tip from brackeys
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
