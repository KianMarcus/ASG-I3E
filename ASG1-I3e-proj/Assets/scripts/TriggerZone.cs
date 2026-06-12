using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
    public Door door;
 
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && ScoreManager.Instance.score >= 4)
        {
            door.Open();
        }
    }
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
