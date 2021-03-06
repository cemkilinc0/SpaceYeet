using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Enemy Wave Config")]
public class WaveConfig : ScriptableObject
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject pathPrefab;
    [SerializeField] float timeBetweenSpawns = 0.5f;
    [SerializeField] float spawnRandomFactor = 0.3f;
    [SerializeField] float enemySpeed = 1f;
    [SerializeField] int numberOfEnemies = 5;

    public GameObject GetEnemyPrefab() { return enemyPrefab;}

    public List<Transform> GetWayPoints()
    {
        var waveWavePoints = new List<Transform>();

        foreach (Transform child in pathPrefab.transform)
        {
            waveWavePoints.Add(child);
        }

        return waveWavePoints;
    }

    public float GetTimeBetweenSpawns() { return timeBetweenSpawns; }
    public float GetSpawnRandomFactor() { return spawnRandomFactor; }
    public float GetEnemySpeed() { return enemySpeed; }
    public int GetNumberOfEnemies() { return numberOfEnemies; }

}
