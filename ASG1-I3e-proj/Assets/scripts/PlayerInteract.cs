using UnityEngine;
 
public class PlayerInteract : MonoBehaviour
{
    private Coin nearbyCoin;
 
    void OnTriggerEnter(Collider other)
    {
        nearbyCoin = other.GetComponent<Coin>();
    }
 
    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Coin>())
            nearbyCoin = null;
    }
 
    void OnInteract()
    {
        if (nearbyCoin != null)
            nearbyCoin.Collect();
    }
}
