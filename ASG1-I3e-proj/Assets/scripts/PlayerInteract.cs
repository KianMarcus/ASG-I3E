using UnityEngine;
 
public class PlayerInteract : MonoBehaviour
{
    private Coin nearbyCoin;
    private Door2 nearbyDoor;
 
    void OnTriggerEnter(Collider other)
    {
        nearbyCoin = other.GetComponent<Coin>();
        nearbyDoor = other.GetComponent<Door2>();
    }
 
    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Coin>()) nearbyCoin = null;
        if (other.GetComponent<Door2>()) nearbyDoor = null;
    }
 
    void OnInteract()
    {
        if (nearbyCoin != null) nearbyCoin.Collect();
        if (nearbyDoor != null) nearbyDoor.Open();
    }
}
