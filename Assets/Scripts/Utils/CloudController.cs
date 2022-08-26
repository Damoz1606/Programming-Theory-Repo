using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 1.0f;
    void Update()
    {
        this.transform.Rotate(0, this._rotationSpeed * Time.deltaTime, 0);
    }
}
