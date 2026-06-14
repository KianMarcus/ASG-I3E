using UnityEngine;
 
public class PlayerInteract : MonoBehaviour
{
    private Coin nearbyCoin;
    private Statue nearbyStatue;
    private Door2 nearbyDoor;
    private Win nearbyWin; // add this
 
    void OnTriggerEnter(Collider other)
    {
        nearbyCoin = other.GetComponent<Coin>();
        nearbyStatue = other.GetComponent<Statue>();
        nearbyDoor = other.GetComponent<Door2>();
        nearbyWin = other.GetComponent<Win>(); // add this
    }
 
    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Coin>()) nearbyCoin = null;
        if (other.GetComponent<Statue>()) nearbyStatue = null;
        if (other.GetComponent<Door2>()) nearbyDoor = null;
        if (other.GetComponent<Win>()) nearbyWin = null; // add this
    }
 
    void OnInteract()
    {
        if (nearbyCoin != null) nearbyCoin.Collect();
        if (nearbyStatue != null) nearbyStatue.Collect();
        if (nearbyDoor != null) nearbyDoor.Open();
        if (nearbyWin != null) nearbyWin.OnInteract(); // add this
    }
}
