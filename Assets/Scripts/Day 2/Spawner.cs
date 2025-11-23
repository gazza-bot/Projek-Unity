using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public GameObject AsteroidsPrefab;
    public float SpawnInterval = 3f;
    private float SinceLastSpawn; // sebagai counter untuk spawner
    private float SpawnNewWave;
    private float TimeDifficult;
    public float spawnBoundaryY;
    public float spawnBoundaryX;

    void Update()
    {
        TimeDifficult += Time.deltaTime;
        // Debug.Log(TimeDifficult + " : detik" );
        SinceLastSpawn += Time.deltaTime;
        SpawnNewWave += Time.deltaTime;
        if(SinceLastSpawn >= SpawnInterval)
        {
            if(TimeDifficult >= 30f)
            {
                SpawnAsteroids();
                if(SpawnNewWave >= SpawnInterval - 1f)
                {
                    SpawnEnemy();
                    SpawnNewWave = 0f;
                }
            }
            SpawnEnemy();
            SinceLastSpawn = 0f;
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

    void SpawnAsteroids()
    {
        if(AsteroidsPrefab == null)
        {
            Debug.Log("Prefab Asteroid null");
            return;
        }
        float RandomY = Random.Range(-spawnBoundaryY,spawnBoundaryY);
        Vector3 spawnPosition = new Vector3(spawnBoundaryX,RandomY);
        // untuk melakukan spawning dapat menggunakan Instantiate() method,
        // Instantiation memiliki parameter game object, vector3, dan Quaternion
        GameObject asteroids = Instantiate(AsteroidsPrefab, spawnPosition, Quaternion.identity);
    }
}