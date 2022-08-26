using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastMovementController : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;

    public float Speed { get { return _speed; } }

    private void Start() {
        this.initMovement();
    }

    private void initMovement() {
        Rigidbody _rigidbody = this.GetComponent<Rigidbody>();
        if(_rigidbody != null) {
            _rigidbody.velocity = this.transform.forward * this.Speed;
        }
    }
}
