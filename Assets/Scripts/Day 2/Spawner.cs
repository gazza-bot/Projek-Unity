using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float SpawnInterval = 3f;
    private float SinceLastSpawn; // sebagai counter untuk spawner
    public float spawnBoundaryY;
    public float spawnBoundaryX;

    void Update()
    {
        SinceLastSpawn += Time.deltaTime;
        if(SinceLastSpawn >= SpawnInterval)
        {
            SpawnEnemy();
            SinceLastSpawn = 0;
        }
    }
    void SpawnEnemy()
    {
        if(EnemyPrefab == null)
        {
            Debug.Log("Prefab Enemy null");
            return;
        }
        float RandomY = Random.Range(-spawnBoundaryY,spawnBoundaryY);
        Vector3 spawnPosition = new Vector3(spawnBoundaryX,RandomY);
        // untuk melakukan spawning dapat menggunakan Instantiate() method,
        // Instantiation memiliki parameter game object, vector3, dan Quaternion
        GameObject enemy = Instantiate(EnemyPrefab, spawnPosition, Quaternion.identity);
    }
}