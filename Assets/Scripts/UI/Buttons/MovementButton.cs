using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementButton : MonoBehaviour
{
    public void RotateLeft()
    {
        Managers.GameManager.Ship.ShipMovementController.RotateShip(false);
    }

    public void RotateRight()
    {
        Managers.GameManager.Ship.ShipMovementController.RotateShip(true);
    }
}
