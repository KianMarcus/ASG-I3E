using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int value = 1;
 
    public void Collect()
    {
        ScoreManager.Instance.score += value;
        Debug.Log("Score: " + ScoreManager.Instance.score);
        Destroy(gameObject);
    }
}
