using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // This script is to handle collision of player and obstacle, when player hits the obstacle player should die. 
    PlayerMovement playerMovement;

    // Start is called before the first frame update
    private void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        // Kill the player
        if (collision.gameObject.name == "Player"){
            playerMovement.Die();
        }

    }
}
