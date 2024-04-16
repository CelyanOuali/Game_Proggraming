using System.Collections;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText; // Reference to the score TextMeshProUGUI component
    private float score = 0f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        StartCoroutine(UpdateScore());
    }

    IEnumerator UpdateScore()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);

            // Increase the score by 1 every second
            score += 1;

            // Update the UI text to display the score
            UpdateScoreText();
        }
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            // Update the UI text to display the score
            scoreText.text = "Score: " + score.ToString();
        }
        else
        {
            Debug.LogError("Score Text component is not assigned in the Inspector.");
        }
    }
}
