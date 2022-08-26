using UnityEngine;

[RequireComponent(typeof(AudioManager))]
[RequireComponent(typeof(CameraManager))]
[RequireComponent(typeof(GameManager))]
[RequireComponent(typeof(InputManager))]
[RequireComponent(typeof(ScoreManager))]
[RequireComponent(typeof(SpawnManager))]
[RequireComponent(typeof(UIManager))]

public class Managers : MonoBehaviour
{
    public static AudioManager _audioManager;
    private static CameraManager _cameraManager;
    private static GameManager _gameManager;
    private static InputManager _inputManager;
    private static ScoreManager _scoreManager;
    private static SpawnManager _spawnManager;
    private static UIManager _uiManager;

    
    public static AudioManager AudioManager { get { return _audioManager; } }
    public static CameraManager CameraManager { get { return _cameraManager; } }
    public static GameManager GameManager { get { return _gameManager; } }
    public static InputManager InputManager { get { return _inputManager; } }
    public static ScoreManager ScoreManager { get { return _scoreManager; } }
    public static SpawnManager SpawnManager { get { return _spawnManager; } }
    public static UIManager UIManager { get { return _uiManager; } }

    private void Awake()
    {
        _audioManager = GetComponent<AudioManager>();
        _cameraManager = GetComponent<CameraManager>();
        _gameManager = this.GetComponent<GameManager>();
        _inputManager = this.GetComponent<InputManager>();
        _scoreManager = this.GetComponent<ScoreManager>();
        _spawnManager = this.GetComponent<SpawnManager>();
        _uiManager = this.GetComponent<UIManager>();

        DontDestroyOnLoad(this.gameObject);
    }
}