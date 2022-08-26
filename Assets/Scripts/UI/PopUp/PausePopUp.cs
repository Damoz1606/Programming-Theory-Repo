using UnityEngine;

public class PausePopUp : MonoBehaviour
{
    public void ReturnToMenu()
    {

    }

    public void ContinueGame()
    {
        Managers.GameManager.SetState(GameState.GAME_PLAY);
    }
}