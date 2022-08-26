using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarButton : MonoBehaviour
{
    public void SonarEvent()
    {
        Managers.GameManager.Ship.ShipMovementController.Sonar();
    }
}
