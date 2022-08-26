using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AsteroidMovementController))]
[RequireComponent(typeof(AsteroidSonarController))]
public class Asteroid : MonoBehaviour
{
    [SerializeField] private int _asteroidScore = 100;

    private AsteroidMovementController _asteroidMovementController;
    private AsteroidSonarController _asteroidSonarController;

    public AsteroidMovementController AsteroidMovementController { get { return _asteroidMovementController; } }
    public AsteroidSonarController AsteroidSonarController { get { return _asteroidSonarController; } }
    public int AsteroidScore { get { return _asteroidScore; } set { this._asteroidScore = value; } }

    void Awake()
    {
        this._asteroidMovementController = this.GetComponent<AsteroidMovementController>();
        this._asteroidSonarController = this.GetComponent<AsteroidSonarController>();
    }

    void Start()
    {
        this.transform.SetParent(Managers.GameManager.AsteroidHolder.transform);
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag(Constants.BLAST_TAG))
        {
            Blast blast = other.GetComponent<Blast>();
            if (blast != null)
            {
                Managers.ScoreManager.OnScore(this.AsteroidScore);
                Managers.AudioManager.PlayExplosionSound();
                this.DestroyAsteroid();
                blast.DestroyBlast();
            }
        }

        if (other.CompareTag(Constants.SHIP_TAG))
        {
            Ship ship = other.GetComponent<Ship>();
            if (ship != null)
            {
                Managers.AudioManager.PlayExplosionSound();
                this.DestroyAsteroid();
                ship.DestroyShip();
            }
        }
    }

    public void DestroyAsteroid()
    {
        Destroy(this.gameObject);
    }

}
