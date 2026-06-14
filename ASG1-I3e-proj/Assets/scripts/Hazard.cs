using UnityEngine;

public class Hazard : MonoBehaviour
{
    public int damage = 10;
    public float damageInterval = 1f;

    private float timer;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timer += Time.deltaTime;

            if (timer >= damageInterval)
            {
                PlayerHealth.Instance.TakeDamage(damage);
                timer = 0f;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timer = 0f;
        }
    }
}
