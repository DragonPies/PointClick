using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject playerPrefab;
    public void spawnPlayer()
    {
        Debug.Log("Spawning Player");
        Instantiate(playerPrefab, transform.position,transform.rotation);
    }
}
