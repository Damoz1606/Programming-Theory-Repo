using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public void PauseEvent()
    {
        Managers.GameManager.SetState(GameState.GAME_PAUSE);
    }
}
