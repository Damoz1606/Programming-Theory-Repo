using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnOffScreen : MonoBehaviour
{
    void Update()
    {
        Vector3 position = Camera.main.WorldToViewportPoint(transform.position);

        if (position.x < 0 || position.x > 1 || position.y < 0 || position.y > 1)
        {
            OnBecameInvisible();
        }
    }
    
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
