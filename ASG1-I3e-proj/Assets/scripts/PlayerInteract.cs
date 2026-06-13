using UnityEngine;
 
public class PlayerInteract : MonoBehaviour
{
    private Coin nearbyCoin;
    private Statue nearbyStatue;
    private Door2 nearbyDoor;
 
    void OnTriggerEnter(Collider other)
    {
        nearbyCoin = other.GetComponent<Coin>();
        nearbyStatue = other.GetComponent<Statue>();
        nearbyDoor = other.GetComponent<Door2>();
    }
 
    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Coin>()) nearbyCoin = null;
        if (other.GetComponent<Statue>()) nearbyStatue = null;
        if (other.GetComponent<Door2>()) nearbyDoor = null;
    }
 
    void OnInteract()
    {
        if (nearbyCoin != null) nearbyCoin.Collect();
        if (nearbyStatue != null) nearbyStatue.Collect();
        if (nearbyDoor != null) nearbyDoor.Open();
    }
}
