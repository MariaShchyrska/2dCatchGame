using System.Collections;
using UnityEngine;

public class CollectableSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _collectablesPrefabs;
    [SerializeField] private float _spawnInterval = 2f;
    [SerializeField] private float _spawnHeight = 10f;
    [SerializeField] private float _spawnXRange = 5;

    void Start()
    {
        StartCoroutine(SpawnInInterval());
    }

    private IEnumerator SpawnInInterval()
    {
        while(true)
        {
            SpawnCollectable();
            yield return new WaitForSeconds(_spawnInterval);
        }
    }

    private void SpawnCollectable()
    {
        float randomX = Random.Range(-_spawnXRange, _spawnXRange);
        Vector3 spawnPosition = new Vector3(randomX, _spawnHeight, 0);
        GameObject toSpawn = _collectablesPrefabs[Random.Range(0, _collectablesPrefabs.Length)];
        
        Instantiate(toSpawn, spawnPosition, Quaternion.identity);
    }
}