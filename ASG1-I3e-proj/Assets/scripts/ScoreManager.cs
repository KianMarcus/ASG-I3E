using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public static ScoreManager Instance;
    public int score = 0;
 
    void Awake()
    {
        Instance = this;
    }
 
    public void AddPoint()
    {
        score++;
        Debug.Log("Score: " + score);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
