using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuState : _StateBase
{
    public override void OnActivate()
    {
        Managers.GameManager.IsGameActive = false;
        Managers.UIManager.ActivateUI(UITypes.MAIN_MENU);
        Managers.CameraManager.ZoomOut();
        Managers.UIManager.MainMenuUI.MainMenuStartAnimation();

        if (Managers.GameManager.Ship != null) Destroy(Managers.GameManager.Ship.gameObject);
        Debug.Log($"MenuState <Color=green>Status: </Color> activated");
    }

    public override void OnDeactivate()
    {
        Debug.Log($"MenuState <Color=red>Status: </Color> deactivated");
    }

    public override void OnFixedUpdate()
    {
        Debug.Log($"MenuState <Color=orange>Status: </Color> fixed update");
    }

    public override void OnUpdate()
    {
        Managers.UIManager.MainMenuUI.MainMenuEndAnimation();
        Debug.Log($"MenuState <Color=yellow>Status: </Color> updated");
    }
}
