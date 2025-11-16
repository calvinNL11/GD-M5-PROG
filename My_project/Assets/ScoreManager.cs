using UnityEngine;
using UnityEngine.UI; // Alleen nodig als je een UI-score wilt tonen

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance; 
    public int totalScore = 0;

    void Awake()
    {
      
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddPoints(int points)
    {
        totalScore += points;
        Debug.Log("Total Score: " + totalScore);
    }
}
