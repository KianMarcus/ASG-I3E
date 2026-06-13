using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public static PlayerHealth Instance;
 
    public int maxHealth = 100;
    public int currentHealth;
 
    void Awake()
    {
        Instance = this;
        currentHealth = maxHealth;
    }
 
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        Debug.Log("Health: " + currentHealth);
 
        if (currentHealth <= 0)
        {
            GetComponent<PlayerDeath>().Die();
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
