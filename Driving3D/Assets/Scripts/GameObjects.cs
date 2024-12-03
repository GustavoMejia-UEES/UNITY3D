using UnityEngine;
using System.Collections.Generic;


public class GameObjects : MonoBehaviour
{

    public GameObject[] obstaclePrefabs; 
    public Transform carTransform;      
    public float spawnDistance = 10f;   
    public float spawnInterval = 2f;    
    public float obstacleLifetime = 5f; 
    private void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 0f, spawnInterval);
    }

    void SpawnObstacle()
    {
        if (obstaclePrefabs.Length == 0 || carTransform == null) return;

        Vector3 spawnPosition = carTransform.position + carTransform.forward * spawnDistance;

        int randomIndex = Random.Range(0, obstaclePrefabs.Length);

        GameObject newObstacle = Instantiate(obstaclePrefabs[randomIndex], spawnPosition, Quaternion.identity);

        Destroy(newObstacle, obstacleLifetime);
    }
}


