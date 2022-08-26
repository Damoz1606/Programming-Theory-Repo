using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarBar : ProgressiveBarController
{

    private void Start() {
        this.SetMaxValue(Managers.GameManager.Ship.ShipMovementController.SonarCooldown);
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