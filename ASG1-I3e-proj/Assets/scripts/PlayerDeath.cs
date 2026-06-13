using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
 
    public GameObject deathScreen;
    public MonoBehaviour playerMovement;
 
    public void Die()
    {
        playerMovement.enabled = false;
        deathScreen.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
 
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
