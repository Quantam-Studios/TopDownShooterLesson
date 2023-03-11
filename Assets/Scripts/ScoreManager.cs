using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static TMP_Text scoreText;
    public static int score;

    void Start()
    {
        scoreText = transform.GetChild(0).gameObject.GetComponent<TMP_Text>();
        scoreText.text = "0";
    }

    public static void AddScore(int points)
    {
        score += points;
        scoreText.text = score.ToString();
    }

}
