using UnityEngine;

public class TriggerZone2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
    public Door3 door;
 
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && ScoreManager.Instance.score >= 8)
        {
            door.Open();
        }
    }
   

}
