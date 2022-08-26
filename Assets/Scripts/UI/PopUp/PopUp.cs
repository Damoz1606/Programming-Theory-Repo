using UnityEngine;

public class PopUp : MonoBehaviour
{

    [SerializeField] private GameObject pausePopUp;
    [SerializeField] private GameObject gameOverPopUp;
    [SerializeField] private GameObject settingsPopUp;

    public void ActivatePausePopUp()
    {
        pausePopUp.transform.parent.gameObject.SetActive(true);
        pausePopUp.SetActive(true);
        Managers.UIManager.ActivePopUp = pausePopUp;
    }

    public void ActivateGameOverPopUp()
    {
        gameOverPopUp.transform.parent.gameObject.SetActive(true);
        gameOverPopUp.SetActive(true);
        Managers.UIManager.ActivePopUp = gameOverPopUp;
    }

    public void ActivateSettingsPopUp()
    {
        settingsPopUp.transform.parent.gameObject.SetActive(true);
        settingsPopUp.SetActive(true);
        Managers.UIManager.ActivePopUp = settingsPopUp;
    }

    public void DisablePausePopUp()
    {
        pausePopUp.transform.parent.gameObject.SetActive(false);
        pausePopUp.SetActive(false);
        Managers.UIManager.ActivePopUp = null;
    }

    public void DisableGameOverPopUp()
    {
        gameOverPopUp.transform.parent.gameObject.SetActive(false);
        gameOverPopUp.SetActive(false);
        Managers.UIManager.ActivePopUp = null;
    }

    public void DisableSettingsPopUp()
    {
        settingsPopUp.transform.parent.gameObject.SetActive(false);
        settingsPopUp.SetActive(false);
        Managers.UIManager.ActivePopUp = null;
    }
        
}