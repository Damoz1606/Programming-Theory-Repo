using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int currentScore = 0;

    public int CurrentScore { get { return currentScore; } }

    void Start()
    {
        Managers.UIManager.InGameUI.UpdateScoreUI();
    }

    public void OnScore(int scoreIncreaseAmount)
    {
        currentScore += scoreIncreaseAmount;
        Managers.UIManager.InGameUI.UpdateScoreUI();
    }
}
