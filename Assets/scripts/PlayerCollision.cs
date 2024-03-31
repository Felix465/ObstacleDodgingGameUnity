
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<gameManeger>().EndGame();
        }
    }
}
