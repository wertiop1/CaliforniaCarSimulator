using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI scoreText;  

    [Header("Settings")]
    public float pointsPerSecond = 1f; 

    private float score = 0f;
    private bool  gameOver = false;

    void Update()
    {
        if (gameOver) return;

        score += pointsPerSecond * Time.deltaTime;
        scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
    }

    public void TriggerGameOver()
    {
        if (gameOver) return;
        gameOver = true;
        SceneManager.LoadScene(0);
    }
}