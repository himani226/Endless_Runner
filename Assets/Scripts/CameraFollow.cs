
using UnityEngine;

// This script is to camera should follow the player
public class CameraFollow : MonoBehaviour
{
    public Transform player;
    Vector3 offset;

    // Start is called before the first frame update
    private void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        // camera remain at center when player moving left and right
        Vector3 targetPosition =  player.position + offset;
        targetPosition.x = 0;
        transform.position = targetPosition;
    }
}
