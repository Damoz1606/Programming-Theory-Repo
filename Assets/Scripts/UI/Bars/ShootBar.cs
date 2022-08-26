using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBar : ProgressiveBarController
{
    private void Start() {
        this.SetMaxValue(Managers.GameManager.Ship.ShipMovementController.ShootCooldown);
    }

    public override void SetMaxValue(float maxValue)
    {
        this._slider.maxValue = maxValue;
        this._slider.value = maxValue;
    }

    public override void SetValue(float value)
    {
        this._slider.value = value;
    }

}