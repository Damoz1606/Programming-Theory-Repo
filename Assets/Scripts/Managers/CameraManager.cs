using System.Collections;
using UnityEngine;
using DG.Tweening;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private Camera _main;
    private float _inGameSize = 5.0f;
    private float _mainMenuSize = 9.0f;

    public Camera Main { get { return _main; } set { _main = value; } }

    public void ZoomIn()
    {
        if (this._main.orthographicSize != _inGameSize)
        {
            this._main.DOOrthoSize(_inGameSize, 0.5f).SetEase(Ease.Linear).OnComplete(() =>
            {
                StartCoroutine(this.StartGamePlay());
            });
        }
        else
        {
            Managers.GameManager.IsGameActive = true;
        }
    }

    public void ZoomOut()
    {
        if (this._main.orthographicSize != _mainMenuSize)
            this._main.DOOrthoSize(_mainMenuSize, 1f).SetEase(Ease.Linear);
    }

    private IEnumerator StartGamePlay()
    {
        yield return new WaitForEndOfFrame();
        if (!Managers.GameManager.IsGameActive)
        {
            Managers.GameManager.IsGameActive = true;
        }
        yield break;
    }
}