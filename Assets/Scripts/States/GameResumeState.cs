using UnityEngine;

public class GameResumeState : _StateBase
{
    public override void OnActivate()
    {
        Managers.UIManager.ActivateUI(UITypes.IN_GAME);
        Managers.GameManager.IsGameActive = true;
        Managers.CameraManager.ZoomIn();
        Debug.Log($"GamePlayState <Color=green>Status: </Color> activated");
    }

    public override void OnDeactivate()
    {
        Debug.Log($"GamePlayState <Color=red>Status: </Color> deactivated");
    }

    public override void OnFixedUpdate()
    {
        Debug.Log($"GamePlayState <Color=orange>Status: </Color> fixed update");
    }

    public override void OnUpdate()
    {
        Debug.Log($"GamePlayState <Color=yellow>Status: </Color> updated");
    }
}