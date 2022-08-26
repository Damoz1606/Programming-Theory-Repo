using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayState : _StateBase
{
    public override void OnActivate()
    {
        Managers.UIManager.ActivateUI(UITypes.IN_GAME);
        Managers.GameManager.IsGameActive = true;
        Managers.CameraManager.ZoomIn();
        Managers.SpawnManager.SpawnShip();
        Debug.Log($"GamePlayState <Color=green>Status: </Color> activated");
    }

    public override void OnUpdate()
    {
        Debug.Log($"GamePlayState <Color=yellow>Status: </Color> updated");
    }

    public override void OnFixedUpdate()
    {
        Debug.Log($"GamePlayState <Color=orange>Status: </Color> fixed update");
    }

    public override void OnDeactivate()
    {
        Debug.Log($"GamePlayState <Color=red>Status: </Color> deactivated");
    }
}