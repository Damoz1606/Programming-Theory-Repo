using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToMenuButton : MonoBehaviour
{
    public void BackToMenuEvent()
    {
        Managers.GameManager.SetState(GameState.GAME_MENU);
    }
}
