using UnityEngine;


public class land : MonoBehaviour
{
    public int random;

    [Header("Object to Spawn")]
    public GameObject tree;
    public GameObject pine;
    public GameObject oak;
    public GameObject rock;
    public GameObject coal;
    public GameObject iron;

    public Transform currentPoint;

    private bool hasSpawned;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        random = Random.Range(0, 1000);
        if (random <= 10 && !hasSpawned)
        { 
            hasSpawned = true;
            Instantiate(tree, currentPoint.transform.position, Quaternion.identity);
        }
        else if (random <= 20 && !hasSpawned)
        { 
            hasSpawned = true;
            Instantiate(pine, currentPoint.transform.position, Quaternion.identity);
        }
        else if (random <= 30 && !hasSpawned)
        { 
            hasSpawned = true;
            Instantiate(oak, currentPoint.transform.position, Quaternion.identity);
        }
        else if (random < 40 && !hasSpawned)
        { 
            hasSpawned = true;
            Instantiate(rock, currentPoint.transform.position, Quaternion.identity);
        }
        else if (random < 50 && !hasSpawned)
        { 
            hasSpawned = true;
            Instantiate(coal, currentPoint.transform.position, Quaternion.identity);
        }
        else if (random < 60 && !hasSpawned)
        { 
            hasSpawned = true;
            Instantiate(iron, currentPoint.transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
