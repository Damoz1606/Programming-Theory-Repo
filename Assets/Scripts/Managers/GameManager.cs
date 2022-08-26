using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    GAME_RESUME,
    GAME_MENU,
    GAME_PLAY,
    GAME_OVER,
    GAME_PAUSE,
    GAME_WIN
}

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _asteroidHolder;
    [SerializeField] private GameObject _blastHolder;
    [SerializeField] private Ship _ship;
    private bool _isGameActive;
    private _StateBase _currentState;

    public GameObject AsteroidHolder { get { return _asteroidHolder; } }
    public GameObject BlastHolder { get { return _blastHolder; } }
    public Ship Ship { get { return _ship; } set { this._ship = value; } }
    public bool IsGameActive { get { return _isGameActive; } set { _isGameActive = value; } }

    private void Awake()
    {
        this._isGameActive = false;
    }

    private void Start()
    {
        this.SetState(GameState.GAME_MENU);
        Managers.AudioManager.PlayGameMusic();
    }

    private void Update()
    {
        if (this._currentState != null)
            this._currentState.OnUpdate();
    }

    private void FixedUpdate()
    {
        if (this._currentState != null)
            this._currentState.OnFixedUpdate();
    }

    public void SetState(GameState state)
    {
        System.Type newStateType = this.GetState(state);
        if (this._currentState != null)
        {
            this._currentState.OnDeactivate();
        }
        this._currentState = GetComponentInChildren(newStateType) as _StateBase;
        if (this._currentState != null)
        {
            this._currentState.OnActivate();
        }
    }

    private System.Type GetState(GameState state)
    {
        switch (state)
        {
            case GameState.GAME_MENU:
                return typeof(MenuState);
            case GameState.GAME_PLAY:
                return typeof(GamePlayState);
            case GameState.GAME_OVER:
                return typeof(GameOverState);
            case GameState.GAME_PAUSE:
                return typeof(GamePauseState);
            case GameState.GAME_RESUME:
                return typeof(GameResumeState);
            default:
                return null;
        }
    }
}