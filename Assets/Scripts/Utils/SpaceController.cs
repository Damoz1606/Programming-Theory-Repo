using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceController : MonoBehaviour
{
    [SerializeField] private GameObject spacePrefab;
    [SerializeField] private float speed = 1f;

    private GameObject _currentSpaceBG;
    private GameObject _nextSpaceBG;

    void Start()
    {
        this._currentSpaceBG = Instantiate(this.spacePrefab, Vector3.zero, Quaternion.identity);
        this._currentSpaceBG.transform.localEulerAngles = new Vector3(90, 0, 0);
        this._currentSpaceBG.transform.SetParent(this.transform);
        this._nextSpaceBG = Instantiate(this.spacePrefab, new Vector3(0, 0, this._currentSpaceBG.transform.localScale.y), Quaternion.identity);
        this._nextSpaceBG.transform.localEulerAngles = new Vector3(90, 0, 0);
        this._nextSpaceBG.transform.SetParent(this.transform);
    }

    void Update()
    {
        this.UpdateMovement();
    }

    private void UpdateMovement()
    {
        this._currentSpaceBG.transform.Translate(Vector3.down * this.speed * Time.deltaTime);
        this._nextSpaceBG.transform.Translate(Vector3.down * this.speed * Time.deltaTime);
        this.RemoveOnOffScreen();
    }

    private void RemoveOnOffScreen()
    {
        Vector3 position = Camera.main.WorldToViewportPoint(this._currentSpaceBG.transform.position);

        if (position.y < -1)
        {
            Destroy(this._currentSpaceBG);
            this._currentSpaceBG = this._nextSpaceBG;
            this._nextSpaceBG = Instantiate(this.spacePrefab, this._currentSpaceBG.transform.position + new Vector3(0, 0, this._currentSpaceBG.transform.localScale.y), Quaternion.identity);
            this._nextSpaceBG.transform.localEulerAngles = new Vector3(90, 0, 0);
            this._nextSpaceBG.transform.SetParent(this.transform);
        }
    }


}
