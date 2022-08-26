using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SonarBar))]
[RequireComponent(typeof(ShootBar))]

public class InGameUI : MonoBehaviour
{
    [SerializeField] private GameObject _sonarHolder;
    [SerializeField] private GameObject _sonarAsteroidPrefab;
    [SerializeField] private TextMeshProUGUI _score;
    [SerializeField] private Text _scoreLabel;
    private SonarBar _sonarBar;
    private ShootBar _shootBar;


    public SonarBar SonarBar { get { return _sonarBar; } }
    public ShootBar ShootBar { get { return _shootBar; } }
    public GameObject SonarHolder { get { return _sonarHolder; } }

    void Awake()
    {
        _sonarBar = GetComponent<SonarBar>();
        _shootBar = GetComponent<ShootBar>();
    }

    public void UpdateScoreUI()
    {
        if (_score != null) _score.text = Managers.ScoreManager.CurrentScore.ToString();
    }

    public GameObject CreateSonarAsteroidSprite(Vector2 position)
    {
        GameObject sonarAsteroid = Instantiate(this._sonarAsteroidPrefab, position, Quaternion.identity);
        sonarAsteroid.transform.position = position;
        sonarAsteroid.transform.SetParent(this._sonarHolder.transform);
        sonarAsteroid.SetActive(false);
        return sonarAsteroid;
    }

    public void StartAnimation()
    {

    }

    public void EndAnimation()
    {

    }
}
