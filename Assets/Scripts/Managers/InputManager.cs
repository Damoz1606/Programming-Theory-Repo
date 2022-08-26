using UnityEngine;

public enum InputTypes
{
    KEYBOARD,
    TOUCH
}

public class InputManager : MonoBehaviour
{

    [SerializeField] private InputTypes _inputType = InputTypes.KEYBOARD;
    [SerializeField] private bool _isEnableInput = true;

    public InputTypes InputType { get { return _inputType; } }
    public bool IsEnableInput { get { return _isEnableInput; } set { _isEnableInput = value; } }

    private void Update()
    {
        switch (_inputType)
        {
            case InputTypes.KEYBOARD:
                this.KeyboardInput();
                break;
            case InputTypes.TOUCH:
                this.TouchInput();
                break;
        }
    }

    #region KEYBOARD
    private void KeyboardInput()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            Managers.GameManager.Ship.ShipMovementController.RotateShip(false);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Managers.GameManager.Ship.ShipMovementController.RotateShip(true);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Managers.GameManager.Ship.ShipMovementController.Shoot();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            Managers.GameManager.Ship.ShipMovementController.Sonar();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Managers.GameManager.SetState(GameState.GAME_PAUSE);
        }
    }
    #endregion

    #region TOUCH
    private void TouchInput()
    {
        
    }
    #endregion
}