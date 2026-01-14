using UnityEngine;


public class land : MonoBehaviour
{
    public int random;
    public GameObject objectToSpawn;
    public Transform currentPoint;

    private bool hasSpawnedTree;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        random = Random.Range(0, 100);
        if (random < 10 && !hasSpawnedTree)
        { 
            hasSpawnedTree = true;
            Instantiate(objectToSpawn, currentPoint.transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
