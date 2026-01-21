using UnityEngine;

public class OOPscore : MonoBehaviour
{
    public static ScoreManager Instance;
    public int totalScore = 18;

    void Awake()
    {

        if (Instance == null)
        {
            
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
