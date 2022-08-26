using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePauseState : _StateBase
{
    public override void OnActivate()
    {
        Managers.GameManager.IsGameActive = false;
        Managers.InputManager.IsEnableInput = false;
        Managers.UIManager.PopUp.ActivatePausePopUp();
        Time.timeScale = 0.0f;
        Debug.Log($"GamePauseState <Color=green>Status: </Color> activated");
    }

    public override void OnDeactivate()
    {
        Managers.GameManager.IsGameActive = true;
        Managers.InputManager.IsEnableInput = true;
        Managers.UIManager.PopUp.DisablePausePopUp();
        Time.timeScale = 1.0f;
        Debug.Log($"<Color=red>Status: </Color> deactivated");
    }

    public override void OnFixedUpdate()
    {
        Debug.Log($"<Color=orange>Status: </Color> fixed update");
    }

    public override void OnUpdate()
    {
        Debug.Log($"<Color=yellow>Status: </Color> updated");
    }
}
