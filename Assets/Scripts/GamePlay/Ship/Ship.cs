using UnityEngine;

[RequireComponent(typeof(ShipMovementController))]
public class Ship : MonoBehaviour
{
    private ShipMovementController _shipMovementController;

    public ShipMovementController ShipMovementController { get { return _shipMovementController; } }

    private void Awake()
    {
        _shipMovementController = this.GetComponent<ShipMovementController>();
    }

    public void DestroyShip()
    {
        Managers.InputManager.IsEnableInput = false;
        Managers.GameManager.SetState(GameState.GAME_OVER);
        Destroy(this.gameObject);
    }
}