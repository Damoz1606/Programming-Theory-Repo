using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovementController : MonoBehaviour
{
    [SerializeField] private Vector2 _forceRange = new Vector2(1, 2);
    private void Start()
    {
        this.Movement();
    }

    private void Movement()
    {
        Rigidbody _rigidbody = GetComponent<Rigidbody>();
        if (_rigidbody == null) return;
        int side = Random.Range(0, 4);
        Vector3 direction = Vector3.zero;

        switch (side)
        {
            case 0:
                direction = new Vector3(1, 0, Random.Range(-1, 1));
                break;
            case 1:
                direction = new Vector3(-1, 0, Random.Range(-1, 1));
                break;
            case 2:
                direction = new Vector3(Random.Range(-1, 1), 0, 1);
                break;
            case 3:
                direction = new Vector3(Random.Range(-1, 1), 0, -1);
                break;
        }

        _rigidbody.velocity = direction.normalized * Random.Range(_forceRange.x, _forceRange.y);
    }
}
