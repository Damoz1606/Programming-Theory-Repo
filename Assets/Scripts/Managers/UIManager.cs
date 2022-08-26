using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UITypes
{
    MAIN_MENU,
    IN_GAME,
    PAUSE_MENU,
    GAME_OVER,
}

public class UIManager : MonoBehaviour
{
    [SerializeField] private InGameUI _inGameUI;
    [SerializeField] private MainMenu _mainMenuUI;
    [SerializeField] private PopUp _popUp;
    private GameObject _activePopUp;

    public InGameUI InGameUI { get { return _inGameUI; } }
    public MainMenu MainMenuUI { get { return _mainMenuUI; } }
    public PopUp PopUp { get { return _popUp; } }
    public GameObject ActivePopUp { set { this._activePopUp = value; } }

    private void Update()
    {
        if (this._activePopUp != null)
            Debug.Log("ActivePopUp action");
    }

    public void ActivateUI(UITypes uiType)
    {
        switch (uiType)
        {
            case UITypes.MAIN_MENU:
                StartCoroutine(this.ActivateMainMenu());
                break;
            case UITypes.IN_GAME:
                StartCoroutine(this.ActivateInGameUI());
                break;
        }
    }

    private IEnumerator ActivateInGameUI()
    {
        this._mainMenuUI.MainMenuEndAnimation();
        yield return new WaitForSeconds(0.3f);
        this._mainMenuUI.gameObject.SetActive(false);
        this._inGameUI.gameObject.SetActive(true);
        this._inGameUI.StartAnimation();
        //Animation
    }

    private IEnumerator ActivateMainMenu()
    {
        this._inGameUI.EndAnimation();
        yield return new WaitForSeconds(0.3f);
        this._inGameUI.gameObject.SetActive(false);
        Debug.Log("Disabling in game UI");
        this._mainMenuUI.gameObject.SetActive(true);
        this._mainMenuUI.MainMenuStartAnimation();
        Debug.Log("Enabling main menu UI");
    }
}
