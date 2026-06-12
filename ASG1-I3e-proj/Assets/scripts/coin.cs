using UnityEngine;

public class coin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.AddPoint();
            Destroy(gameObject);
        }
    }

}
