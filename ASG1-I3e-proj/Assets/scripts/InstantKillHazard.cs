using UnityEngine;

public class InstantKillHazard : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth.Instance.TakeDamage(100);
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
