using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonar : MonoBehaviour
{
    [SerializeField] private Vector3 _maxRange = new Vector3(10.0f, 10.0f, 1.0f);
    [SerializeField] private float _speed = 1.0f;

    void Start()
    {
        this.transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
    }

    void Update()
    {
        this.ChangeCurrentScale();
        this.HasReachedMaxRange();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Constants.ASTEROID_TAG))
        {
            Asteroid asteroid = other.GetComponent<Asteroid>();
            if(asteroid != null) {
                asteroid.AsteroidSonarController.DetectedAsteroid();
            }
        }
    }

    private void ChangeCurrentScale()
    {
        this.transform.localScale = Vector3.Lerp(this.transform.localScale, this._maxRange, this._speed * Time.deltaTime);
    }

    private void HasReachedMaxRange()
    {
        if (Mathf.Round(this.transform.localScale.x) >= this._maxRange.x)
        {
            Destroy(this.gameObject);
        }
    }
}
