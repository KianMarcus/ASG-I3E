using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject WinScreen;
    private bool playerNearby = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            playerNearby = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            playerNearby = false;
    }

    public void OnInteract()
    {
        if (playerNearby)
        {
            WinScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
