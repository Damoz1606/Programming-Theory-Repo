using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootButton : MonoBehaviour
{
    public void ShootEvent()
    {
        Managers.GameManager.Ship.ShipMovementController.Shoot();
    }
}
