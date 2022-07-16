using UnityEngine;

public class GroundMaker : MonoBehaviour
{
    // This script to place new ground at the end of earlier ground
    public GameObject groundPlane;
    Vector3 nextPlane;

    public void NextGroundPlane()
    {
       GameObject temp = Instantiate(groundPlane, nextPlane, Quaternion.identity);
        nextPlane = temp.transform.GetChild(1).transform.position;
    } 
    // Start is called before the first frame update
    private void Start()
    {
        // called the function NextGroundPlane to generate the plane at start
        for (int i=0; i<15;i++){
            NextGroundPlane();
        }
    }
}
