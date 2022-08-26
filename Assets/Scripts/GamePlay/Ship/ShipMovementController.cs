using UnityEngine;

public class ShipMovementController : MonoBehaviour
{
    [SerializeField] private GameObject _blastPrefab;
    [SerializeField] private GameObject _sonarPrefab;
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private float _rotationSpeed = 1.0f;
    [SerializeField] private float _shootCooldown = 1.0f;
    [SerializeField] private float _sonarCooldown = 5.0f;
    private float _lastTimeShoot = 0.0f;
    private float _lastTimeSonar = 0.0f;
    private Ship _ship;
    private bool _canMove = true;

    public bool CanMove { get { return _canMove; } set { _canMove = value; } }
    public float Speed { get { return _speed; } }
    public float RotationSpeed { get { return _rotationSpeed; } }
    public float ShootCooldown { get { return _shootCooldown; } }
    public float SonarCooldown { get { return _sonarCooldown; } }

    void Update()
    {
        if (Managers.UIManager.InGameUI.ShootBar && Time.time - this._lastTimeShoot <= this._shootCooldown)
        {
            Managers.UIManager.InGameUI.ShootBar.SetValue(Time.time - this._lastTimeShoot);
        }

        if (Managers.UIManager.InGameUI.SonarBar && Time.time - this._lastTimeSonar <= this._sonarCooldown)
        {
            Managers.UIManager.InGameUI.SonarBar.SetValue(Time.time - this._lastTimeSonar);
        }
    }

    public void RotateShip(bool isClockwise)
    {
        if (isClockwise)
        {
            this.transform.Rotate(Vector3.up, _rotationSpeed);
        }
        else
        {
            this.transform.Rotate(Vector3.up, -_rotationSpeed);
        }
    }

    public void Shoot()
    {
        if (Time.time - this._lastTimeShoot > this._shootCooldown)
        {
            GameObject blast = Instantiate(_blastPrefab, this.transform.position, this.transform.rotation);
            Managers.AudioManager.PlayLaserSound();
            if (Managers.GameManager.BlastHolder != null) blast.transform.parent = Managers.GameManager.BlastHolder.transform;
            this._lastTimeShoot = Time.time;
        }
    }

    public void Sonar()
    {
        if (Time.time - this._lastTimeSonar > this._sonarCooldown)
        {
            GameObject sonar = Instantiate(_sonarPrefab, this.transform.position, this.transform.rotation);
            Managers.AudioManager.PlaySonarSound();
            this._lastTimeSonar = Time.time;
        }
    }
}