using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{

    int currentScore = 0;
    public TextMeshProUGUI scoreText;

    public void AddScore(int amount)
    {
        currentScore += amount;
        scoreText.text = currentScore.ToString();

        //Debug.Log("SCORE = " + currentScore);
    }
}
