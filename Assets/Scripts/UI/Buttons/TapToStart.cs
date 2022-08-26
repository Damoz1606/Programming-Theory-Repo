using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToStart : MonoBehaviour
{
    public void StartGame() {
        Managers.GameManager.SetState(GameState.GAME_PLAY);
    }
}
