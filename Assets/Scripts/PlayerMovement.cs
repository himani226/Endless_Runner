using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    // This script to handle the player movement i.e left, right and jump from arrow keys and space key.
    // When player die the game should restart after 2 seconds.
    bool alive = true;

    public float speed = 5; // default value for player speed has been set as 5
    public Rigidbody rb; 
    public float horizonatalInput = 2f;

    public float jumpForce = 400f;
    public GameObject gameOver;
    public LayerMask groundMask;

    private void FixedUpdate (){
        // Move the player in forward direction
        if (!alive) return;
        Vector3 moveForward = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * speed * horizonatalInput * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + moveForward + horizontalMove);
    }

    // Update is called once per frame
    private void Update()
    {
        horizonatalInput = Input.GetAxis("Horizontal");

        if(Input.GetKeyDown(KeyCode.Space)){
            Jump();
        }

        if (transform.position.y < -5)
        {
            Die();
        }

    }

    public void Die()
    {
        alive = false;
        gameOver.SetActive(true);
        Invoke("Restart",2);

       
    }

    public void Jump(){
        // Check whether we are at ground or not

        float height = GetComponent<Collider>().bounds.size.y;
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down,(height/2)+0.1f, groundMask);

        //if we are jumping
        rb.AddForce(Vector3.up * jumpForce);
    
    }

    public void Restart(){
         // Restart the Game
        gameOver.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

}
 