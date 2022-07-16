using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // This script to create coins when player collided with coin, the coin destroy and update the score.

    public float rotationSpeed = 90f; // Handles rotation speed of coin

    private void OnTriggerEnter(Collider other){
        // check that the coin collided with obstacle than destroy the coin object
        if (other.gameObject.GetComponent<Obstacle>() != null){
            Destroy(gameObject);
            return;
        }
        // check that the object we collided with is the player
        if (other.gameObject.name != "Player"){
            return;
        }
        // Add value to the player's score
        GameManger.inst.IncrementScore();

        // Destroy the coin object
        Destroy(gameObject);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0,0,rotationSpeed * Time.deltaTime);
    }
}
