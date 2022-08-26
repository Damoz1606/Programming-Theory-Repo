using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverState : _StateBase
{
    public override void OnActivate()
    {
        Managers.GameManager.IsGameActive = false;
        Managers.InputManager.IsEnableInput = false;
        Managers.UIManager.PopUp.ActivateGameOverPopUp();
        Debug.Log($"GameOverState <Color=green>Status: </Color> activated");
    }

    public override void OnUpdate()
    {
        Debug.Log($"GameOverState <Color=yellow>Status: </Color> updated");
    }

    public override void OnFixedUpdate()
    {
        Debug.Log($"GameOverState <Color=orange>Status: </Color> fixed update");
    }

    public override void OnDeactivate()
    {
        Managers.UIManager.PopUp.DisableGameOverPopUp();
        Debug.Log($"GameOverState <Color=red>Status: </Color> deactivated");
    }
}