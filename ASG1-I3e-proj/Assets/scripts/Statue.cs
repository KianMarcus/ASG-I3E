using UnityEngine;

public class Statue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public int value = 2;
 
    public void Collect()
    {
        ScoreManager.Instance.score += value;
        CollectibleUI.Instance.AddStatue();
        Debug.Log("Score: " + ScoreManager.Instance.score);
        Destroy(gameObject);
    }    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
