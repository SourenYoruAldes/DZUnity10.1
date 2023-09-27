using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class SpawnBat : MonoBehaviour
{
    [SerializeField] private float _spawnDelay;

    [SerializeField] private GameObject[] _spawners;

    private float _timeToSpawn;

    private BatSpawnerScript _batSpawnerScript;

    private void Start()
    {
        _timeToSpawn = _spawnDelay;
    }

    private void Update()
    {
        TrySpawn();
    }

    private void TrySpawn()
    {
        if (_timeToSpawn <= 0)
        {
            _batSpawnerScript = _spawners[GetRandomSpawnerIndex()].GetComponent<BatSpawnerScript>();
            _batSpawnerScript.SpawnBat();

            _timeToSpawn = _spawnDelay;
        }
        else
        {
            _timeToSpawn -= Time.deltaTime;
        }
    }

    private int GetRandomSpawnerIndex() => Random.Range(0, _spawners.Length);
}
