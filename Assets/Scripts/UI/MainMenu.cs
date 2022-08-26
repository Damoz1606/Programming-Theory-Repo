using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _logo;
    [SerializeField] private GameObject _menuButtons;
    [SerializeField] private Image _panel;
    private HorizontalLayoutGroup _layout;
    private void Awake()
    {
        this._layout = GetComponent<HorizontalLayoutGroup>();
    }

    private void OnEnable()
    {
        this._logo.enabled = true;
        this._menuButtons.SetActive(true);
    }

    private void OnDisable()
    {
        this._logo.enabled = false;
        this._menuButtons.SetActive(false);
    }

    public void DisableMenuButtons()
    {
        this._menuButtons.SetActive(false);
    }

    public void MainMenuStartAnimation()
    {
    }

    public void MainMenuEndAnimation()
    {
    }
}
