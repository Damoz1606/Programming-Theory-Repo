using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject _shipPrefab;
    [SerializeField] private GameObject[] _asteroidPrefabs;
    [SerializeField] private float _spawnRate = 1.5f;
    [SerializeField] private Vector2 _forceRange = new Vector2(1, 2);

    private float _timer;
    private Camera _mainCamera;

    private void Start()
    {
        this._mainCamera = Camera.main;
    }

    private void FixedUpdate()
    {
        if (!Managers.GameManager.IsGameActive) return;
        this._timer -= Time.deltaTime;

        if (this._timer <= 0)
        {
            this.SpawnAsteroids();
            this._timer = this._spawnRate;
        }
    }

    private void SpawnAsteroids()
    {
        int side = Random.Range(0, 4);
        Vector2 spawnPoint = Vector2.zero;

        switch (side)
        {
            case 0:
                spawnPoint.x = 0;
                spawnPoint.y = Random.value;
                break;
            case 1:
                spawnPoint.x = 1;
                spawnPoint.y = Random.value;
                break;
            case 2:
                spawnPoint.x = Random.value;
                spawnPoint.y = 0;
                break;
            case 3:
                spawnPoint.x = Random.value;
                spawnPoint.y = 1;
                break;
        }

        Vector3 worldSpawnPoint = this._mainCamera.ViewportToWorldPoint(spawnPoint);
        worldSpawnPoint.y = 0;
        Quaternion rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
        GameObject asteroid = Instantiate(this._asteroidPrefabs[Random.Range(0, this._asteroidPrefabs.Length)], worldSpawnPoint, rotation);
    }

    public void SpawnShip()
    {
        GameObject ship = Instantiate(_shipPrefab, Vector3.zero, Quaternion.identity);
        Managers.GameManager.Ship = ship.GetComponent<Ship>();
    }
}
