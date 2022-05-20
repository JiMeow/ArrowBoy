using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;

    public void AddScore(int score)
    {
        int currentScore = int.Parse(scoreText.text);
        currentScore += score;
        scoreText.text = currentScore.ToString();
    }
}
