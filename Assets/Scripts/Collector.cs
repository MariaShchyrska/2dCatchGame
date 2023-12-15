using UnityEngine;
using UnityEngine.SceneManagement;

public class Collector : MonoBehaviour
{
    [SerializeField] private Audio _audio;
    
    public int Points { get; private set; }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Points++;
            _audio.PlayCoinSound();
            Destroy(other.gameObject);
        }

        if(other.gameObject.CompareTag("BadThing"))
        {
            UpdateBestScore();
            RestartGame();
        }
    }

    private void UpdateBestScore()
    {
        float currentBestScore;
        if(PlayerPrefs.HasKey("BestScore"))
            currentBestScore = PlayerPrefs.GetFloat("BestScore");
        else
            currentBestScore = 0;
            
        if(Points > currentBestScore)
            PlayerPrefs.SetFloat("BestScore", Points);
    }

    private static void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}