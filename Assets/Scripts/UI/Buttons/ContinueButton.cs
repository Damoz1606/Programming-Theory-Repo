using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : MonoBehaviour
{
    public void ContinueEvent()
    {
        Managers.GameManager.SetState(GameState.GAME_RESUME);
    }

    public void ContinueWithAdEvent()
    {
        Managers.GameManager.SetState(GameState.GAME_PLAY);
    }
}
