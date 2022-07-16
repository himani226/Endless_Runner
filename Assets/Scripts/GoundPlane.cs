using UnityEngine;

public class GoundPlane : MonoBehaviour
{
    //This scripts is to generate the random Grounds, Obstacles and Coins, when player exits the ground destroy it.


    GroundMaker groundMaker;
    
    // Start is called before the first frame update
    private void Start()
    {
        groundMaker = GameObject.FindObjectOfType<GroundMaker>();
        ObstacleMaker();
        MakeCoins();
    }

    private void OnTriggerExit(Collider other)
    {
        groundMaker.NextGroundPlane();
        Destroy(gameObject,2);
    }

    public GameObject obstaclePrefab;
    
    void ObstacleMaker()
    {
        // Choose randowm point to place the obstacle 

        int obstacleMekeIndex = Random.Range(2,5);
        Transform makerPoint = transform.GetChild(obstacleMekeIndex).transform;

        // Place the obstacle on that position
        Instantiate(obstaclePrefab, makerPoint.position, Quaternion.identity,transform);
    }

    public GameObject coinPrefab;
    // Choose random point to place the coins on ground
    void MakeCoins()
    {
        int coinsToMake = 10;
        for (int i=0; i<coinsToMake;i++){
            GameObject temp = Instantiate(coinPrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    Vector3 GetRandomPointInCollider (Collider collider){
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
        );
        if(point != collider.ClosestPoint(point)){
            point = GetRandomPointInCollider(collider);
        }
        point.y = 1;
        return point;
    }










}
