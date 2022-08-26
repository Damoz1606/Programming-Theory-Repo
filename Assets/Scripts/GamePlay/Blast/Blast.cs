using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BlastMovementController))]
public class Blast : MonoBehaviour
{
    private BlastMovementController _blastMovementController;
    public BlastMovementController BlastMovementController { get { return _blastMovementController; } }

    void Awake() {
        _blastMovementController = this.GetComponent<BlastMovementController>();
    }

    public void DestroyBlast(){
        Destroy(this.gameObject);
    }
}
