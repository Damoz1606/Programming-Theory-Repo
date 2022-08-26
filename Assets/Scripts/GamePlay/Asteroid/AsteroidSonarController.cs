using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSonarController : MonoBehaviour
{
    [SerializeField] private float _changingTime = 0.0f;
    private GameObject _sonarObject;

    public GameObject SonarObject { get { return _sonarObject; } }

    void Start()
    {
        this._sonarObject = Managers.UIManager.InGameUI.CreateSonarAsteroidSprite(this.transform.position);
    }

    private void Update()
    {
        if (this.SonarObject != null && this._sonarObject.activeSelf)
        {
            this._sonarObject.transform.position = WorldToUI.ScreenPosition(this.transform.position, 1.0f);
        }
    }

    public void AssignSonarObject(GameObject sonarObject)
    {
        this._sonarObject = sonarObject;
    }

    public void DetectedAsteroid()
    {
        StartCoroutine(this.DetectedAsteroidCoroutine());
    }

    private IEnumerator DetectedAsteroidCoroutine()
    {
        if (this._sonarObject != null) this._sonarObject.gameObject.SetActive(true);
        yield return new WaitForSeconds(_changingTime);
        if (this._sonarObject != null) this._sonarObject.gameObject.SetActive(false);

        yield break;
    }

    private void OnDestroy() {
        if (this._sonarObject != null) Destroy(this._sonarObject);
    }
}
