using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    [SerializeField] GameObject[] ballPrefabs;
    [SerializeField] GameObject[] spawnPoints;
    [SerializeField] List<GameObject> instantiatedBalls = new();
    [SerializeField] int minSpawnTime;
    [SerializeField] int maxSpawnTime;

    private Transform _lastSpawnPoint;

    void Start()
    {
        foreach (GameObject ball in ballPrefabs)
        {
            var instantiatedBallOb = Instantiate(ball, transform.position, ball.transform.rotation);
            instantiatedBalls.Add(instantiatedBallOb);
            instantiatedBallOb.SetActive(false);
        }
        StartCoroutine(RandomSpawn());
    }

    private IEnumerator RandomSpawn()
    {
        while (true)
        {
            int spawnInterval = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(spawnInterval);
            SpawnRandomBall();
        }
    }

    void SpawnRandomBall()
    {
        GameObject _randomBall = instantiatedBalls[Random.Range(0, instantiatedBalls.Count)];
        Transform _randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)].transform;

        if (_randomBall.activeInHierarchy || (_randomSpawnPoint.transform == _lastSpawnPoint)) return;

        _lastSpawnPoint = _randomSpawnPoint.transform;
        _randomBall.transform.position = _randomSpawnPoint.position;
        _randomBall.SetActive(true);

    }

    
}
